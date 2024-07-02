
namespace Study.Antd.Demo.Views
{
    partial class LoginView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new AntdUI.In.FlowLayoutPanel();
            label1 = new AntdUI.Label();
            txbTenant = new AntdUI.Input();
            label2 = new AntdUI.Label();
            txbUsername = new AntdUI.Input();
            label3 = new AntdUI.Label();
            txbPassword = new AntdUI.Input();
            label4 = new AntdUI.Label();
            cbxRemember = new AntdUI.Checkbox();
            btnSignin = new AntdUI.Button();
            panelTop = new Panel();
            labelTitle = new Label();
            btn_min = new AntdUI.Button();
            btn_max = new AntdUI.Button();
            btn_close = new AntdUI.Button();
            flowLayoutPanel1.SuspendLayout();
            panelTop.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(txbTenant);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(txbUsername);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(txbPassword);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(cbxRemember);
            flowLayoutPanel1.Controls.Add(btnSignin);
            flowLayoutPanel1.Location = new Point(570, 170);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(292, 326);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI Light", 10F);
            label1.Location = new Point(8, 16);
            label1.Margin = new Padding(8, 16, 2, 4);
            label1.Name = "label1";
            label1.Size = new Size(33, 40);
            label1.TabIndex = 0;
            label1.Text = "租户";
            // 
            // txbTenant
            // 
            txbTenant.Location = new Point(45, 16);
            txbTenant.Margin = new Padding(2, 16, 8, 4);
            txbTenant.Name = "txbTenant";
            txbTenant.Size = new Size(237, 40);
            txbTenant.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft YaHei UI Light", 10F);
            label2.Location = new Point(8, 64);
            label2.Margin = new Padding(8, 4, 2, 4);
            label2.Name = "label2";
            label2.Size = new Size(33, 40);
            label2.TabIndex = 0;
            label2.Text = "用户";
            // 
            // txbUsername
            // 
            txbUsername.Location = new Point(45, 64);
            txbUsername.Margin = new Padding(2, 4, 8, 4);
            txbUsername.Name = "txbUsername";
            txbUsername.Size = new Size(237, 40);
            txbUsername.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft YaHei UI Light", 10F);
            label3.Location = new Point(8, 112);
            label3.Margin = new Padding(8, 4, 2, 8);
            label3.Name = "label3";
            label3.Size = new Size(33, 40);
            label3.TabIndex = 0;
            label3.Text = "密码";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(45, 112);
            txbPassword.Margin = new Padding(2, 4, 8, 8);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(237, 40);
            txbPassword.TabIndex = 1;
            // 
            // label4
            // 
            label4.Location = new Point(3, 163);
            label4.Name = "label4";
            label4.Size = new Size(284, 67);
            label4.TabIndex = 2;
            label4.Text = "";
            // 
            // cbxRemember
            // 
            cbxRemember.Location = new Point(8, 241);
            cbxRemember.Margin = new Padding(8, 8, 8, 4);
            cbxRemember.Name = "cbxRemember";
            cbxRemember.Size = new Size(233, 23);
            cbxRemember.TabIndex = 3;
            cbxRemember.Text = "记住用户名密码";
            // 
            // btnSignin
            // 
            btnSignin.Location = new Point(8, 272);
            btnSignin.Margin = new Padding(8, 4, 8, 16);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(273, 43);
            btnSignin.TabIndex = 4;
            btnSignin.Text = "登录";
            btnSignin.Type = AntdUI.TTypeMini.Primary;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(labelTitle);
            panelTop.Controls.Add(btn_min);
            panelTop.Controls.Add(btn_max);
            panelTop.Controls.Add(btn_close);
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
            // btn_min
            // 
            btn_min.BackActive = Color.FromArgb(172, 172, 172);
            btn_min.BackColor = Color.Transparent;
            btn_min.BackHover = Color.FromArgb(223, 223, 223);
            btn_min.Dock = DockStyle.Right;
            btn_min.Font = new Font("Microsoft YaHei UI Light", 18F);
            btn_min.Ghost = true;
            btn_min.Image = Properties.Resources.app_minb;
            btn_min.Location = new Point(742, 0);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(50, 40);
            btn_min.TabIndex = 6;
            // 
            // btn_max
            // 
            btn_max.BackActive = Color.FromArgb(172, 172, 172);
            btn_max.BackColor = Color.Transparent;
            btn_max.BackHover = Color.FromArgb(223, 223, 223);
            btn_max.Dock = DockStyle.Right;
            btn_max.Font = new Font("Microsoft YaHei UI Light", 18F);
            btn_max.Ghost = true;
            btn_max.Image = Properties.Resources.app_maxb;
            btn_max.Location = new Point(792, 0);
            btn_max.Name = "btn_max";
            btn_max.Size = new Size(50, 40);
            btn_max.TabIndex = 5;
            // 
            // btn_close
            // 
            btn_close.BackActive = Color.FromArgb(145, 31, 20);
            btn_close.BackColor = Color.Transparent;
            btn_close.Dock = DockStyle.Right;
            btn_close.Font = new Font("Microsoft YaHei UI Light", 20F);
            btn_close.Ghost = true;
            btn_close.Image = Properties.Resources.app_closeb;
            btn_close.ImageHover = Properties.Resources.app_close;
            btn_close.Location = new Point(842, 0);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(58, 40);
            btn_close.TabIndex = 4;
            // 
            // LoginView
            // 
            BackColor = Color.White;
            ClientSize = new Size(900, 540);
            Controls.Add(panelTop);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Microsoft YaHei UI Light", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(900, 540);
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JOYEA智能服务终端 客户端管理工具v1";
            flowLayoutPanel1.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.In.FlowLayoutPanel flowLayoutPanel1;
        private AntdUI.Label label1;
        private AntdUI.Input txbTenant;
        private AntdUI.Label label2;
        private AntdUI.Input txbUsername;
        private AntdUI.Label label3;
        private AntdUI.Input txbPassword;
        private AntdUI.Label label4;
        private AntdUI.Checkbox cbxRemember;
        private AntdUI.Button btnSignin;
        private Panel panelTop;
        private Label labelTitle;
        private AntdUI.Button btn_min;
        private AntdUI.Button btn_max;
        private AntdUI.Button btn_close;
    }
}
