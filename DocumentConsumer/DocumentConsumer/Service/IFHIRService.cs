
namespace DocumentConsumer.Service
{
    interface IFHIRService
    {
        void CreateConnection(string endpoint);

        void GetDocumentReference(string patientId, string assigningAuthority);

        void GetDocumentManifest();

        byte[] GetBinary();
    }
}
