using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using DocumentConsumer.Main.Handler;
using DocumentConsumer.Main.Model;
using DocumentConsumer.Main.View;
using DocumentConsumer.Service;

namespace DocumentConsumer.Main.Presenter
{
    internal class MainPresenter : IMainPresenter, IMainHandler
    {
        private enum FhirCalls
        {
            Binary,
            DocumentManifest,
            DocumentReference
        };

        private readonly IMainView _mainView;
        private readonly IFhirService _fhirService;

        private FhirCalls _currentFhirCall;
        private string _currentEndpoint;

        public MainPresenter(IMainView mainView, IFhirService fhirService)
        {
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
                _currentEndpoint = url;
            }
            else
            {
                _mainView.UpdateStatusBarConnection("Could not connect to:  " + url);
                _mainView.EnableDocumentButtons(false);
                _currentEndpoint = string.Empty;
            }
        }

        public void HandleDocumentReference(string searchParameter, string searchValue)
        {
            _currentFhirCall = FhirCalls.DocumentReference;

            List<DocReference> docReferences = _fhirService.SearchDocumentReference(searchParameter, searchValue);

            _mainView.FillResults(docReferences);
        }

        public void HandleDocumentManifest(string searchParameter, string searchValue)
        {
            _currentFhirCall = FhirCalls.DocumentManifest;

            List<DocManifest> docManifests = _fhirService.SearchDocumentManifest(searchParameter, searchValue);

            _mainView.FillResults(docManifests);
        }

        public void HandleBinary(string url)
        {
            _currentFhirCall = FhirCalls.Binary;

            if (url.StartsWith(_currentEndpoint))
            {
                url = url.Replace(_currentEndpoint, string.Empty);
            }

            byte[] content = _fhirService.GetBinary(url);

            string s = Encoding.UTF8.GetString(content, 0, content.Length);

            XDocument doc = XDocument.Parse(s);

            _mainView.FillOutput(doc.ToString());
        }

        public void HandleCellClick(string cellText)
        {
            //The cell text can either be a relative path, or full path.
            //Need a nice way to call the next FHIR Resource

            if (FhirCalls.DocumentManifest.Equals(_currentFhirCall))
            {
                _currentFhirCall = FhirCalls.DocumentReference;

                DocReference docReference =
                    _fhirService.GetDocumentReference(cellText.Substring(cellText.IndexOf('/') + 1));

                _mainView.FillResults(new List<DocReference> {docReference});
            }
            else
            {
                HandleBinary(cellText);
            }
        }
    }
}