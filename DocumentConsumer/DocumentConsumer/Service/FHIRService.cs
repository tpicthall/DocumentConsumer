using System;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using DocumentConsumer.Main.Model;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace DocumentConsumer.Service
{
    internal class FhirService : IFhirService
    {
        private FhirClient _fhirClient;

        private readonly JavaScriptSerializer _jsSerializer = new JavaScriptSerializer();

        public string FhirRequest { get; private set; }
        public string FhirResponse { get; private set; }

        public bool CreateConnection(string endPoint)
        {
            _fhirClient = null;

            try
            {
                _fhirClient = new FhirClient(endPoint);
                _fhirClient.OnBeforeRequest += _fhirClient_OnBeforeRequest;
                _fhirClient.OnAfterResponse += _fhirClient_OnAfterResponse;
               // _fhirClient.PreferredFormat = ResourceFormat.Xml;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
  
        void _fhirClient_OnBeforeRequest(object sender, BeforeRequestEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            _jsSerializer.Serialize(e.RawRequest, sb);

            var obj = JsonConvert.DeserializeObject(sb.ToString());

            FhirRequest = JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        void _fhirClient_OnAfterResponse(object sender, AfterResponseEventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            _jsSerializer.Serialize(e.RawResponse, sb);

            var obj = JsonConvert.DeserializeObject(sb.ToString());

            FhirResponse = JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public List<DocReference> SearchDocumentReference(string searchParameter, string searchValue)
        {
            Query q = new Query();
            q.AddParameter(searchParameter, searchValue);
            q.ResourceType = "DocumentReference";
            Bundle responses = _fhirClient.Search(q);

            return (from ResourceEntry entry in responses.Entries
                where entry.Resource is DocumentReference
                select (entry.Resource as DocumentReference).Map()).ToList();
        }

        public List<DocManifest> SearchDocumentManifest(string searchParameter, string searchValue)
        {
            Query q = new Query();
            q.AddParameter(searchParameter, searchValue);
            q.ResourceType = "DocumentManifest";
            Bundle responses = _fhirClient.Search(q);

            return (from ResourceEntry entry in responses.Entries
                where entry.Resource is DocumentManifest
                select (entry.Resource as DocumentManifest).Map()).ToList();
        }

        public DocReference GetDocumentReference(string documentReferenceId)
        {
            ResourceEntry<DocumentReference> resouceEntry =
                _fhirClient.Read<DocumentReference>("DocumentReference/" + documentReferenceId);

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