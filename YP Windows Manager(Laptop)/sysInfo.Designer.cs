﻿namespace YP_Windows_Manager_Computer_
{
    partial class sysInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sysInfo));
            this.sysdate__Info = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sysInfoList = new Telerik.WinControls.UI.RadListView();
            this.gpuAbout = new System.Windows.Forms.Label();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            ((System.ComponentModel.ISupportInitialize)(this.sysInfoList)).BeginInit();
            this.sysInfoList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // sysdate__Info
            // 
            this.sysdate__Info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sysdate__Info.AutoSize = true;
            this.sysdate__Info.BackColor = System.Drawing.Color.White;
            this.sysdate__Info.ForeColor = System.Drawing.Color.Black;
            this.sysdate__Info.Location = new System.Drawing.Point(15, 428);
            this.sysdate__Info.Name = "sysdate__Info";
            this.sysdate__Info.Size = new System.Drawing.Size(0, 17);
            this.sysdate__Info.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // sysInfoList
            // 
            this.sysInfoList.Controls.Add(this.gpuAbout);
            this.sysInfoList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sysInfoList.Location = new System.Drawing.Point(0, 0);
            this.sysInfoList.Name = "sysInfoList";
            this.sysInfoList.Size = new System.Drawing.Size(720, 454);
            this.sysInfoList.TabIndex = 2;
            this.sysInfoList.ThemeName = "TelerikMetroBlue";
            // 
            // gpuAbout
            // 
            this.gpuAbout.AutoSize = true;
            this.gpuAbout.BackColor = System.Drawing.Color.Transparent;
            this.gpuAbout.Location = new System.Drawing.Point(484, 12);
            this.gpuAbout.Name = "gpuAbout";
            this.gpuAbout.Size = new System.Drawing.Size(0, 17);
            this.gpuAbout.TabIndex = 0;
            // 
            // sysInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 454);
            this.Controls.Add(this.sysdate__Info);
            this.Controls.Add(this.sysInfoList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "sysInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Information";
            this.ThemeName = "Fluent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sysInfoList)).EndInit();
            this.sysInfoList.ResumeLayout(false);
            this.sysInfoList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label sysdate__Info;
        private System.Windows.Forms.Timer timer1;
        private Telerik.WinControls.UI.RadListView sysInfoList;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        private System.Windows.Forms.Label gpuAbout;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
    }
}