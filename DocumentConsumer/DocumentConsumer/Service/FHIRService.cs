using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace DocumentConsumer.Service
{
    class FHIRService : IFHIRService
    {
        private FhirClient _fhirClient;

        public void CreateConnection(string endPoint)
        {
            if (_fhirClient != null)
            {
                _fhirClient = null;
            }

            _fhirClient = new FhirClient(endPoint);
        }

        public void GetDocumentReference(string patientId, string assigningAuthority)
        {
            ResourceEntry<DocumentReference> resourceEntry = _fhirClient.Read<DocumentReference>(string.Format("DocumentReference?subject.id={0}|{1}&status=current", assigningAuthority, patientId));
        }

        public void GetDocumentManifest()
        {

        }

        public byte[] GetBinary()
        {
            return null;
        }
    }
}
