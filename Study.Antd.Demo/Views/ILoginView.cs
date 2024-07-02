using Study.Antd.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Antd.Demo.Views
{
    public interface ILoginView
    {
        // Fields
        string Tenant { get; set; } // 租户
        string UserName { get; set; }   //用户名
        string Password { get; set; }   // 密码
        bool IsRemember { get; set; }   //是否记住
        string Message { get; set; }    // 错误信息
        bool IsSuccess { get; set; }

        //Events
        event EventHandler LoginEvent;
        event EventHandler CloseEvent;
        event EventHandler MaxEvent;
        event EventHandler MinEvent;

        //Methods
        void SetAccount(AccountModel account);
        void Show();
        void CloseWindow();
        void MaxWindow();
        void MinWindow();
        void HideWindow();
    }
}
