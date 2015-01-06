using DocumentConsumer.Main.Handler;
using DocumentConsumer.Main.Model;
using DocumentConsumer.Main.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentConsumer.Main.Presenter
{
    class MainPresenter : IMainPresenter, IMainHandler
    {
        private readonly IMainModel _mainModel;
        private readonly IMainView _mainView;

        public MainPresenter(IMainModel mainModel, IMainView mainView)
        {
            _mainModel = mainModel;
            _mainView = mainView;
        }

        public void Initialize()
        {

        }

        public void ShowView()
        {
            _mainView.ShowView();
        }
    }
}
