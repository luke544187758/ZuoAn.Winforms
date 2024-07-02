using Study.Antd.Demo.Models;

namespace Study.Antd.Demo.Views
{
    public partial class LoginView : AntdUI.Window, ILoginView
    {
        //Fields
        private string message;
        private bool isSuccess;
        public LoginView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }


        // Properties
        public string Tenant { get => txbTenant.Text.Trim(); set => txbTenant.Text = value; }
        public string UserName { get => txbUsername.Text.Trim(); set => txbUsername.Text = value; }
        public string Password { get => txbPassword.Text.Trim(); set => txbPassword.Text = value; }
        public bool IsRemember { get => cbxRemember.Checked; set => cbxRemember.Checked = value; }
        public string Message { get => message; set => message = value; }
        public bool IsSuccess { get => isSuccess; set => isSuccess = value; }
        //Events
        public event EventHandler LoginEvent;
        public event EventHandler CloseEvent;
        public event EventHandler MaxEvent;
        public event EventHandler MinEvent;

        private void AssociateAndRaiseViewEvents()
        {
            btnSignin.Click += delegate
            {
                LoginEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccess == false) MessageBox.Show(Message);
            };
            btn_close.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to close the form?",
                     "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CloseEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btn_max.Click += delegate { MaxEvent?.Invoke(this, EventArgs.Empty); };
            btn_min.Click += delegate { MinEvent?.Invoke(this, EventArgs.Empty); };
        }
        // 加载并设置账户信息
        public void SetAccount(AccountModel account)
        {
            if (account != null)
            {
                if (account.IsRemember)
                {
                    cbxRemember.Checked = account.IsRemember;
                    txbTenant.Text = account.Tenant;
                    txbUsername.Text = account.UserName;
                    txbPassword.Text = account.Password;
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                btn_max.Image = Properties.Resources.app_max2b;
            else
                btn_max.Image = Properties.Resources.app_maxb;
            base.OnSizeChanged(e);
        }

        public void CloseWindow() => Close();
        public void MaxWindow() => MaxRestore();
        public void MinWindow() => Min();
        public void HideWindow()=>Hide();
        private static LoginView instance;
        public static LoginView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new LoginView();
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }


    }
}
