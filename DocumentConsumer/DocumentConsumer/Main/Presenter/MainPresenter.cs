using System.Collections.Generic;
using DocumentConsumer.Main.Handler;
using DocumentConsumer.Main.Model;
using DocumentConsumer.Main.View;
using DocumentConsumer.Service;
using Hl7.Fhir.Model;

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
            var result = _fhirService.GetDocumentReference(patientId);

            _mainView.FillResults(typeof(DocumentReference), new List<DocumentReference> {result});

        }

        public void HandleDocumentManifest(string patientId)
        {
            _fhirService.GetDocumentManifest(patientId);
        }

        public void HandleBinary(string url)
        {
            throw new System.NotImplementedException();
        }
    }
}