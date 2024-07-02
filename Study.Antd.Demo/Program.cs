using Study.Antd.Demo.Presenters;
using Study.Antd.Demo.Services;
using Study.Antd.Demo.Views;
using System.Configuration;

namespace Study.Antd.Demo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            ILoginView view = new LoginView();
            string prefixUrl = Properties.Settings.Default.PrefixUrl;
            ILoginService service = new LoginService(prefixUrl);
            new LoginPresenter(view, service);
            Application.Run((Form)view);
        }
    }
}