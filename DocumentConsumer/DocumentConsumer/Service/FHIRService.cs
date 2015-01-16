using System;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace DocumentConsumer.Service
{
    internal class FhirService : IFhirService
    {
        private FhirClient _fhirClient;

        public bool CreateConnection(string endPoint)
        {
            _fhirClient = null;

            try
            {
                _fhirClient = new FhirClient(endPoint);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DocumentReference GetDocumentReference(string patientId)
        {
            try
            {
                ResourceEntry<DocumentReference> resourceEntry =
                    _fhirClient.Read<DocumentReference>(string.Format("DocumentReference/{0}", patientId));

                return resourceEntry.Resource;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void GetDocumentManifest(string patientId)
        {
            try
            {
                ResourceEntry<DocumentManifest> resourceEntry =
                _fhirClient.Read<DocumentManifest>(string.Format("DocumentManifest/{0}", patientId));
            }
            catch (Exception)
            {                
                throw;
            }
            
        }

        public byte[] GetBinary(string url)
        {
            
            return null;
        }
    }
}