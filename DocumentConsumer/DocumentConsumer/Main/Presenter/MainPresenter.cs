﻿using System.Collections.Generic;
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

        private readonly IMainModel _mainModel;
        private readonly IMainView _mainView;
        private readonly IFhirService _fhirService;

        private FhirCalls _currentFhirCall;
        private string _currentEndpoint;

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
                _currentEndpoint = url;
            }
            else
            {
                _mainView.UpdateStatusBarConnection("Could not connect to:  " + url);
                _mainView.EnableDocumentButtons(false);
                _currentEndpoint = string.Empty;
            }
        }

        public void HandleDocumentReference(string patientId)
        {
            _currentFhirCall = FhirCalls.DocumentReference;

            List<DocReference> docReferences = _fhirService.GetDocumentReference(patientId);

            _mainView.FillResults(docReferences);
        }

        public void HandleDocumentManifest(string patientId)
        {
            _currentFhirCall = FhirCalls.DocumentManifest;

            List<DocManifest> docManifests = _fhirService.GetDocumentManifest(patientId);

            _mainView.FillResults(docManifests);
        }

        public void HandleBinary(string url)
        {
            _currentFhirCall = FhirCalls.Binary;

            _fhirService.GetBinary(url);

            
        }

        public void HandleCellClick(string cellText)
        {
            //The cell text can either be a relative path, or full path.
            //Need a nice way to call the next FHIR Resource

            if (FhirCalls.DocumentManifest.Equals(_currentFhirCall))
            {
                HandleDocumentReference(cellText.Substring(cellText.IndexOf('/') + 1));
            }
            else
            {
                HandleBinary(cellText);
            }
        }
    }
}