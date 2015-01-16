using Hl7.Fhir.Model;

namespace DocumentConsumer.Service
{
    internal interface IFhirService
    {
        bool CreateConnection(string endpoint);

        DocumentReference GetDocumentReference(string patientId);

        void GetDocumentManifest(string patientId);

        byte[] GetBinary(string url);
    }
}