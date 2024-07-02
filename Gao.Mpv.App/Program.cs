using Gao.Mpv.App._Repositories;
using Gao.Mpv.App.Models;
using Gao.Mpv.App.Presenters;
using Gao.Mpv.App.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gao.Mpv.App
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();
            new MainPresenter(view,sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
