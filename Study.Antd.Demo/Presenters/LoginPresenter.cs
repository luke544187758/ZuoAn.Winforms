using Study.Antd.Demo.Helpers;
using Study.Antd.Demo.Models;
using Study.Antd.Demo.Services;
using Study.Antd.Demo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Study.Antd.Demo.Presenters
{
    public class LoginPresenter
    {
        //Fields
        private ILoginView _view;
        private ILoginService _loginService;
        private string cfgPath;

        public LoginPresenter(ILoginView view, ILoginService loginService)
        {
            this._view = view;
            this._loginService = loginService;

            //Subsribe event handler methods to view events
            this._view.LoginEvent += Login;
            this._view.MaxEvent += Max;
            this._view.MinEvent += Min;
            this._view.CloseEvent += Close;

            cfgPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "account.yaml");
            // 读取本地账户信息
            LoadLocalAccountConfig();
        }

        private void LoadLocalAccountConfig()
        {
            YamlHelper.InitialConfig();
            try
            {
                var account = YamlHelper.DeserializeFromFile<AccountModel>();
                if (account != null && account.IsRemember)
                {
                    this._view.Tenant = account.Tenant;
                    this._view.UserName = account.UserName;
                    this._view.Password = account.Password;
                    this._view.IsRemember = account.IsRemember;
                }
            }
            catch (Exception ex)
            {
            }
        }



        private void Close(object? sender, EventArgs e)
        {
            this._view.CloseWindow();
        }

        private void Min(object? sender, EventArgs e)
        {
            this._view.MinWindow();
        }

        private void Max(object? sender, EventArgs e)
        {
            this._view.MaxWindow();
        }

        private async void Login(object? sender, EventArgs e)
        {
            var model = new AccountModel();
            model.UserName = this._view.UserName;
            model.Password = this._view.Password;
            model.Tenant = this._view.Tenant;
            model.IsRemember = this._view.IsRemember;

            try
            {
                // 信息本地校验
                new Validations.ModelDataValidation().Validate(model);

                // 勾选记住，则保存信息
                YamlHelper.SerializeToFile(model);

                // 访问服务程序，进行身份验证
                var isSuccess = this._loginService.Login(model);
                if (isSuccess)
                {
                    ShowMainView();
                    this._view.IsSuccess = true;
                }
            }
            catch (Exception ex)
            {
                this._view.Message = ex.Message;
                this._view.IsSuccess = false;
            }
        }

        private void ShowMainView()
        {
            // 隐藏login view
            this._view.HideWindow();
            // 打开主窗体
            IMainView mainView = MainView.GetInstance();
            IMainService mainService = new MainService();
            new MainPresenter(mainView, mainService);
        }
    }
}
