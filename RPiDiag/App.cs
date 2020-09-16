using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RPiDiag
{
    public partial class App : Form
    {
        public Settings settings = new Settings();
        public const int WM_PAINT = 0x000F;

        public static FontFamily fontFamily = new FontFamily("Orbitron");
        public static Font font = new Font(fontFamily, 42, FontStyle.Bold, GraphicsUnit.Pixel);
        public static Brush textColour = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
        public static Brush fillColour = new SolidBrush(Color.FromArgb(85, 255, 0, 127));

        public delegate void Print(string message);
        public static Print print;

        private void _print(string message)
        {
            outputBox.AppendText(message);
            outputBox.ScrollToCaret();
        }

        public App()
        {
            InitializeComponent();
            settingsButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void App_Shown(object sender, EventArgs e)
        {
            inputBox.Focus();
            print = _print;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Transparent);
            e.Graphics.FillRectangle(fillColour, ClientRectangle);
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;
            e.Graphics.DrawString("Raspberry Pi Diagnostics", font, textColour, 12, 8);
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_PAINT:
                {
                    if (settings.transparencyBox.Checked) { Neon.Enable(m.HWnd); }
                    else { Neon.Disable(m.HWnd); }
                    Invalidate();
                }
                break;
            }
            base.WndProc(ref m);
        }

        private void App_SizeChanged(object sender, EventArgs e)
        {
            inputBox.Width = Width - 175;
        }

        private void inputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { sendButton_Click(sender, e); }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try { serialPort.WriteLine(inputBox.Text); } catch { }
            inputBox.Text = "";
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                byte[] buffer = new byte[255];
                serialPort.Read(buffer, 0, serialPort.BytesToRead);
                Invoke(print, new object[] { Encoding.Default.GetString(buffer, 0, buffer.Length) });
            }
            catch { }
        }

        private void serialTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if ((serialPort.PortName != settings.portBox.Text)
                || ((serialPort.BaudRate != int.Parse(settings.rateBox.Text)))
                || (!serialPort.IsOpen))
                {
                    try { serialPort.Close(); } catch { }
                    serialPort.PortName = settings.portBox.Text;
                    serialPort.BaudRate = int.Parse(settings.rateBox.Text);
                    serialPort.Open();
                }
            }
            catch { }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings.StartPosition = FormStartPosition.CenterParent;
            settings.parent = this;
            settings.ShowDialog(this);
        }
    }
}
