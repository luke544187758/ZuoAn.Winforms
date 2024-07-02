using Study.Antd.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Antd.Demo.Services
{
    public interface ILoginService
    {
        bool Login(AccountModel account);
    }
}
