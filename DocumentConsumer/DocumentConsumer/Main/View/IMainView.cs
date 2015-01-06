using DocumentConsumer.Main.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConsumer.Main.View
{
    interface IMainView
    {
        void SetMainHandler(IMainHandler mainHandler);

        void ShowView();

        void CloseView();
    }
}
