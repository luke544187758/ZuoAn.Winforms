using Study.Antd.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Antd.Demo.Services
{
    public class LoginService : BaseService,ILoginService
    {
        public LoginService(string prefixUrl)
        {
            this.prefixUrl = prefixUrl;
        }
        public bool Login(AccountModel account)
        {
            if (account.UserName == "luke" && account.Password == "123456")
                return true;
            return false;
        }
    }
}
