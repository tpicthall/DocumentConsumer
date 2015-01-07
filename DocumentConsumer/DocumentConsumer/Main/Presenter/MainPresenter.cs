using DocumentConsumer.Main.Handler;
using DocumentConsumer.Main.Model;
using DocumentConsumer.Main.View;
using DocumentConsumer.Service;

namespace DocumentConsumer.Main.Presenter
{
    class MainPresenter : IMainPresenter, IMainHandler
    {
        private readonly IMainModel _mainModel;
        private readonly IMainView _mainView;
        private readonly IFHIRService _fhirService;

        public MainPresenter(IMainModel mainModel, IMainView mainView, IFHIRService fhirService)
        {
            _mainModel = mainModel;
            _mainView = mainView;
            _fhirService = fhirService;

            _mainView.SetMainHandler(this);
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
