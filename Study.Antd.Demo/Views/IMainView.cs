using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Antd.Demo.Views
{
    public interface IMainView
    {
        event EventHandler CloseEvent;
        event EventHandler MaxEvent;
        event EventHandler MinEvent;
        void Show();
        void CloseWindow();
        void MaxWindow();
        void MinWindow();
    }
}
