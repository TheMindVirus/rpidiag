namespace RPiDiag
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.portBox = new System.Windows.Forms.TextBox();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.transparencyBox = new System.Windows.Forms.CheckBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // portBox
            // 
            this.portBox.BackColor = System.Drawing.Color.Black;
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portBox.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portBox.ForeColor = System.Drawing.Color.White;
            this.portBox.Location = new System.Drawing.Point(32, 60);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(221, 39);
            this.portBox.TabIndex = 2;
            this.portBox.Text = "COM1";
            this.portBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rateBox
            // 
            this.rateBox.BackColor = System.Drawing.Color.Black;
            this.rateBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rateBox.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateBox.ForeColor = System.Drawing.Color.White;
            this.rateBox.Location = new System.Drawing.Point(32, 160);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(221, 39);
            this.rateBox.TabIndex = 3;
            this.rateBox.Text = "115200";
            this.rateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // transparencyBox
            // 
            this.transparencyBox.AutoSize = true;
            this.transparencyBox.BackColor = System.Drawing.Color.Transparent;
            this.transparencyBox.Checked = true;
            this.transparencyBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.transparencyBox.Font = new System.Drawing.Font("Consolas", 15F);
            this.transparencyBox.ForeColor = System.Drawing.Color.White;
            this.transparencyBox.Location = new System.Drawing.Point(62, 215);
            this.transparencyBox.Name = "transparencyBox";
            this.transparencyBox.Size = new System.Drawing.Size(161, 27);
            this.transparencyBox.TabIndex = 4;
            this.transparencyBox.Text = "Transparency";
            this.transparencyBox.UseVisualStyleBackColor = false;
            this.transparencyBox.CheckedChanged += new System.EventHandler(this.transparencyBox_CheckedChanged);
            // 
            // portLabel
            // 
            this.portLabel.BackColor = System.Drawing.Color.Transparent;
            this.portLabel.Font = new System.Drawing.Font("Consolas", 20F);
            this.portLabel.ForeColor = System.Drawing.Color.White;
            this.portLabel.Location = new System.Drawing.Point(0, 15);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(285, 40);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Serial Port";
            this.portLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rateLabel
            // 
            this.rateLabel.BackColor = System.Drawing.Color.Transparent;
            this.rateLabel.Font = new System.Drawing.Font("Consolas", 20F);
            this.rateLabel.ForeColor = System.Drawing.Color.White;
            this.rateLabel.Location = new System.Drawing.Point(0, 115);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(285, 40);
            this.rateLabel.TabIndex = 6;
            this.rateLabel.Text = "Baud Rate";
            this.rateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.transparencyBox);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.portBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.Shown += new System.EventHandler(this.Settings_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox portBox;
        public System.Windows.Forms.TextBox rateBox;
        public System.Windows.Forms.CheckBox transparencyBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label rateLabel;
    }
}