using DocumentConsumer.Main.Model;
using System.Collections.Generic;

namespace DocumentConsumer.Service
{
    internal interface IFhirService
    {
        string FhirRequest { get; }
        string FhirResponse { get; }

        bool CreateConnection(string endpoint);

        List<DocReference> SearchDocumentReference(string searchParameter, string searchValue);

        List<DocManifest> SearchDocumentManifest(string searchParameter, string searchValue);

        DocReference GetDocumentReference(string documentReferenceId);

        byte[] GetBinary(string url);
    }
}