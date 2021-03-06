﻿using DocumentConsumer.Main.Presenter;

namespace DocumentConsumer.Main.Handler
{
    public interface IMainHandler
    {
        /// <summary>
        /// Handle when the Connect button is clicked
        /// </summary>
        /// <param name="url">URL of FHIR server to connect to</param>
        /// <param name="fhirFormat">Which format to use</param>
        void HandleConnect(string url, FhirFormat fhirFormat);

        /// <summary>
        /// Handle when the Document Reference button is clicked
        /// </summary>
        /// <param name="searchParameter">Search parameter</param>
        /// <param name="searchValue">Search value</param>
        void HandleDocumentReference(string searchParameter, string searchValue);

        /// <summary>
        /// Handle when the Document Manifest button is clicked
        /// </summary>
        /// <param name="searchParameter">Search parameter</param>
        /// <param name="searchValue">Search value</param>
        void HandleDocumentManifest(string searchParameter, string searchValue);

        /// <summary>
        /// Handle when the Binary link is clicked
        /// </summary>
        /// <param name="url">The URL to retrieve the file from</param>
        void HandleBinary(string url);

        /// <summary>
        /// Handle when a DataGridViewLinkCell is clicked
        /// </summary>
        /// <param name="cellText">Text from the cell</param>
        void HandleCellClick(string cellText);

        /// <summary>
        /// Handle when Request is clicked
        /// </summary>
        void HandleRequestClick();

        /// <summary>
        /// Handle when Response is clicked
        /// </summary>
        void HandleResponseClick();
    }
}