using DocumentConsumer.Main.Model;
using System.Collections.Generic;

namespace DocumentConsumer.Service
{
    internal interface IFhirService
    {
        bool CreateConnection(string endpoint);

        List<DocReference> GetDocumentReference(string patientId);

        List<DocManifest> GetDocumentManifest(string patientId);

        byte[] GetBinary(string url);
    }
}