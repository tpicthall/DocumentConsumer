namespace DocumentConsumer.Main.Handler
{
    public interface IMainHandler
    {
        /// <summary>
        /// Handle when the Connect button is clicked
        /// </summary>
        /// <param name="url">URL of FHIR server to connect to</param>
        void HandleConnect(string url);

        /// <summary>
        /// Handle when the Document Reference button is clicked
        /// </summary>
        /// <param name="subject">Subject to use</param>
        void HandleDocumentReference(string subject);

        /// <summary>
        /// Handle when the Document Manifest button is clicked
        /// </summary>
        /// <param name="subject">Subject to use</param>
        void HandleDocumentManifest(string subject);

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
    }
}