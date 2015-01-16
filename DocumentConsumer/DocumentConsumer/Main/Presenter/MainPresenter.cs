using System.Collections.Generic;
using DocumentConsumer.Main.Handler;
using DocumentConsumer.Main.Model;
using DocumentConsumer.Main.View;
using DocumentConsumer.Service;

namespace DocumentConsumer.Main.Presenter
{
    internal class MainPresenter : IMainPresenter, IMainHandler
    {
        private readonly IMainModel _mainModel;
        private readonly IMainView _mainView;
        private readonly IFhirService _fhirService;

        public MainPresenter(IMainModel mainModel, IMainView mainView, IFhirService fhirService)
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

        public void HandleConnect(string url)
        {
            bool result = _fhirService.CreateConnection(url);

            if (result)
            {
                _mainView.UpdateStatusBarConnection("Connected to:  " + url);
                _mainView.EnableDocumentButtons(true);
            }
            else
            {
                _mainView.UpdateStatusBarConnection("Could not connect to:  " + url);
                _mainView.EnableDocumentButtons(false);
            }
        }

        public void HandleDocumentReference(string patientId)
        {
            List<DocReference> docReferences = _fhirService.GetDocumentReference(patientId);

            _mainView.FillResults(docReferences);
        }

        public void HandleDocumentManifest(string patientId)
        {
            List<DocManifest> docManifests = _fhirService.GetDocumentManifest(patientId);
            
            _mainView.FillResults(docManifests);
        }

        public void HandleBinary(string url)
        {
            throw new System.NotImplementedException();
        }
    }
}