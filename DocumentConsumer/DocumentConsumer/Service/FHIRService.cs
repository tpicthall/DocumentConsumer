using System;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using DocumentConsumer.Main.Model;
using System.Collections.Generic;

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

        public List<DocReference> GetDocumentReference(string patientId)
        {
            try
            {
                ResourceEntry<DocumentReference> resourceEntry =
                    _fhirClient.Read<DocumentReference>(string.Format("DocumentReference/{0}", patientId));

                return new List<DocReference> {resourceEntry.Resource.Map()};
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<DocManifest> GetDocumentManifest(string patientId)
        {
            try
            {
                ResourceEntry<DocumentManifest> resourceEntry =
                _fhirClient.Read<DocumentManifest>(string.Format("DocumentManifest/{0}", patientId));

                return new List<DocManifest> {resourceEntry.Resource.Map()};
            }
            catch (Exception)
            {                
                return null;
            }
        }

        public byte[] GetBinary(string url)
        {
            try
            {
                ResourceEntry<Binary> binary = _fhirClient.Read<Binary>(url);

                return binary.Resource.Content;
            }
            catch (Exception)
            {
                return null;    
            }
        }
    }
}