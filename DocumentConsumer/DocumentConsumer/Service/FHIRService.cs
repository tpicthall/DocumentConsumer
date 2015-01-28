using System;
using System.Linq;
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

        public List<DocReference> SearchDocumentReference(string subject)
        {
            Query q = new Query();
            q.AddParameter("subject", subject);
            q.ResourceType = "DocumentReference";
            Bundle responses = _fhirClient.Search(q);

            return (from ResourceEntry entry in responses.Entries
                where entry.Resource is DocumentReference
                select (entry.Resource as DocumentReference).Map()).ToList();
        }

        public List<DocManifest> SearchDocumentManifest(string subject)
        {
            Query q = new Query();
            q.AddParameter("subject", subject);
            q.ResourceType = "DocumentManifest";
            Bundle responses = _fhirClient.Search(q);

            return (from ResourceEntry entry in responses.Entries
                where entry.Resource is DocumentManifest
                select (entry.Resource as DocumentManifest).Map()).ToList();
        }

        public DocReference GetDocumentReference(string documentReferenceId)
        {
            ResourceEntry<DocumentReference> resouceEntry = _fhirClient.Read<DocumentReference>("DocumentReference/" + documentReferenceId);

            return resouceEntry.Resource.Map();
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