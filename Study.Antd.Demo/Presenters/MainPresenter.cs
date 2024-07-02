using Microsoft.VisualBasic.Logging;
using Study.Antd.Demo.Services;
using Study.Antd.Demo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Study.Antd.Demo.Presenters
{
    public class MainPresenter
    {
        //Fields
        private IMainView view;
        private IMainService service;

        public MainPresenter(IMainView view, IMainService service)
        {
            this.view = view;
            this.service = service;

            //Subsribe event handler methods to view events
            this.view.MaxEvent += Max;
            this.view.MinEvent += Min;
            this.view.CloseEvent += Close;

            // 显示主窗口
            this.view.Show();
        }

        private void Close(object? sender, EventArgs e)
        {
            this.view.CloseWindow();
            Application.Exit();
        }

        private void Min(object? sender, EventArgs e)
        {
            this.view.MinWindow();
        }

        private void Max(object? sender, EventArgs e)
        {
            this.view.MaxWindow();
        }
    }
}
