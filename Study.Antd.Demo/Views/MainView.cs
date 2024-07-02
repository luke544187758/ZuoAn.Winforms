using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study.Antd.Demo.Views
{
    public partial class MainView : AntdUI.Window,IMainView
    {
        public MainView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public event EventHandler CloseEvent;
        public event EventHandler MaxEvent;
        public event EventHandler MinEvent;

        private void AssociateAndRaiseViewEvents()
        {
            btnClose.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to close the form?",
                     "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    CloseEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            btnMax.Click += delegate { MaxEvent?.Invoke(this, EventArgs.Empty); };
            btnMin.Click += delegate { MinEvent?.Invoke(this, EventArgs.Empty); };
        }

        public void CloseWindow()=>Close();

        public void MaxWindow()=>MaxRestore();

        public void MinWindow() => Min();

        protected override void OnSizeChanged(EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                btnMax.Image = Properties.Resources.app_max2b;
            else
                btnMax.Image = Properties.Resources.app_maxb;
            base.OnSizeChanged(e);
        }

        private static MainView instance;
        public static MainView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
                instance = new MainView();
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
