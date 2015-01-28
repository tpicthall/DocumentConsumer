using DocumentConsumer.Main.Model;
using System.Collections.Generic;

namespace DocumentConsumer.Service
{
    internal interface IFhirService
    {
        bool CreateConnection(string endpoint);

        List<DocReference> SearchDocumentReference(string searchParameter, string searchValue);

        List<DocManifest> SearchDocumentManifest(string searchParameter, string searchValue);

        DocReference GetDocumentReference(string documentReferenceId);

        byte[] GetBinary(string url);
    }
}