namespace CW_WinText_Getter_1
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.textv = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.nowstate = new DevComponents.DotNetBar.ButtonX();
            this.dotopmost = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.OfficeMobile2014;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))), System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(142)))), ((int)(((byte)(0))))));
            // 
            // textv
            // 
            this.textv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textv.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.textv.Border.Class = "TextBoxBorder";
            this.textv.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.textv.DisabledBackColor = System.Drawing.Color.White;
            this.textv.ForeColor = System.Drawing.Color.Black;
            this.textv.Location = new System.Drawing.Point(12, 13);
            this.textv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textv.MaxLength = 2147483647;
            this.textv.Multiline = true;
            this.textv.Name = "textv";
            this.textv.PreventEnterBeep = true;
            this.textv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textv.Size = new System.Drawing.Size(688, 392);
            this.textv.TabIndex = 0;
            // 
            // nowstate
            // 
            this.nowstate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.nowstate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nowstate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.nowstate.FocusCuesEnabled = false;
            this.nowstate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nowstate.Location = new System.Drawing.Point(587, 413);
            this.nowstate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nowstate.Name = "nowstate";
            this.nowstate.Size = new System.Drawing.Size(114, 35);
            this.nowstate.TabIndex = 1;
            this.nowstate.Click += new System.EventHandler(this.nowstate_Click);
            // 
            // dotopmost
            // 
            this.dotopmost.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.dotopmost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dotopmost.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.dotopmost.FocusCuesEnabled = false;
            this.dotopmost.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dotopmost.Location = new System.Drawing.Point(467, 413);
            this.dotopmost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dotopmost.Name = "dotopmost";
            this.dotopmost.Size = new System.Drawing.Size(114, 35);
            this.dotopmost.TabIndex = 1;
            this.dotopmost.Text = "Top Most";
            this.dotopmost.Click += new System.EventHandler(this.TopMost_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 461);
            this.Controls.Add(this.dotopmost);
            this.Controls.Add(this.nowstate);
            this.Controls.Add(this.textv);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CW WinText Getter 1.0.0";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevComponents.DotNetBar.Controls.TextBoxX textv;
        private DevComponents.DotNetBar.ButtonX nowstate;
        private DevComponents.DotNetBar.ButtonX dotopmost;

    }
}

