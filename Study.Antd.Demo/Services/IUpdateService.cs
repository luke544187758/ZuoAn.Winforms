using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Antd.Demo.Services
{
    public interface IUpdateService
    {
        void CheckClientVersion();
        void DownloadUpdater();
    }
}
