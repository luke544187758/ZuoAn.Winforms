namespace Study.Antd.Demo.Views
{
    partial class MainView
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
            panelTop = new Panel();
            labelTitle = new Label();
            btnMin = new AntdUI.Button();
            btnMax = new AntdUI.Button();
            btnClose = new AntdUI.Button();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Controls.Add(btnMin);
            panelTop.Controls.Add(btnMax);
            panelTop.Controls.Add(btnClose);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(900, 40);
            panelTop.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.Dock = DockStyle.Fill;
            labelTitle.Font = new Font("Microsoft YaHei UI Light", 10F);
            labelTitle.Location = new Point(0, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Padding = new Padding(10, 0, 0, 0);
            labelTitle.Size = new Size(742, 40);
            labelTitle.TabIndex = 7;
            labelTitle.Text = "JOYEA智能服务终端 客户端管理工具v1";
            labelTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMin
            // 
            btnMin.BackActive = Color.FromArgb(172, 172, 172);
            btnMin.BackColor = Color.Transparent;
            btnMin.BackHover = Color.FromArgb(223, 223, 223);
            btnMin.Dock = DockStyle.Right;
            btnMin.Font = new Font("Microsoft YaHei UI Light", 18F);
            btnMin.Ghost = true;
            btnMin.Image = Properties.Resources.app_minb;
            btnMin.Location = new Point(742, 0);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(50, 40);
            btnMin.TabIndex = 6;
            // 
            // btnMax
            // 
            btnMax.BackActive = Color.FromArgb(172, 172, 172);
            btnMax.BackColor = Color.Transparent;
            btnMax.BackHover = Color.FromArgb(223, 223, 223);
            btnMax.Dock = DockStyle.Right;
            btnMax.Font = new Font("Microsoft YaHei UI Light", 18F);
            btnMax.Ghost = true;
            btnMax.Image = Properties.Resources.app_maxb;
            btnMax.Location = new Point(792, 0);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(50, 40);
            btnMax.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.BackActive = Color.FromArgb(145, 31, 20);
            btnClose.BackColor = Color.Transparent;
            btnClose.Dock = DockStyle.Right;
            btnClose.Font = new Font("Microsoft YaHei UI Light", 20F);
            btnClose.Ghost = true;
            btnClose.Image = Properties.Resources.app_closeb;
            btnClose.ImageHover = Properties.Resources.app_close;
            btnClose.Location = new Point(842, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(58, 40);
            btnClose.TabIndex = 4;
            // 
            // MainView
            // 
            BackColor = Color.White;
            ClientSize = new Size(1920, 1080);
            Controls.Add(panelTop);
            Font = new Font("Microsoft YaHei UI Light", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(900, 540);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JOYEA智能服务终端 客户端管理工具v1";
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private Label labelTitle;
        private AntdUI.Button btnMin;
        private AntdUI.Button btnMax;
        private AntdUI.Button btnClose;
    }
}