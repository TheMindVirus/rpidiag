using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPiDiag
{
    public partial class Settings : Form
    {
        public const int WM_PAINT = 0x000F;
        public App parent = null;

        public Settings()
        {
            InitializeComponent();
        }

        public void Settings_Shown(object sender, EventArgs e)
        {
            portLabel.Focus();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Transparent);
        }

        [System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_PAINT:
                {
                    if (transparencyBox.Checked) { Neon.Enable(m.HWnd); }
                    else { Neon.Disable(m.HWnd); }
                    Invalidate();
                }
                break;
            }
            base.WndProc(ref m);
        }

        private void transparencyBox_CheckedChanged(object sender, EventArgs e)
        {
            Refresh();
            if (parent != null) { parent.Refresh(); };
        }
    }
}
