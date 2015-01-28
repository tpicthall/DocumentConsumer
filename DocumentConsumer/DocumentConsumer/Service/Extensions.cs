using System.Collections.Generic;
using System.Linq;
using DocumentConsumer.Main.Model;
using Hl7.Fhir.Model;

namespace DocumentConsumer.Service
{
    public static class DocumentReferenceExtensions
    {
        public static DocReference Map(this DocumentReference documentReference)
        {
            return new DocReference
            {
                Author = 
                    documentReference.Author == null ? null :
                    documentReference.Author.Aggregate(string.Empty,
                        (current, author) => current + (author.Display + ", ")).TrimEnd(new[] { ' ', ',' }),
                Confidentiality =
                    documentReference.Confidentiality.SelectMany(confidentiality => confidentiality.Coding)
                        .Aggregate(string.Empty, (current, coding) => current + (coding.Display + ", "))
                        .TrimEnd(new[] { ' ', ',' }),
                DocumentStatus = documentReference.DocStatus == null ? null : documentReference.DocStatus.Coding.Aggregate(string.Empty,
                        (current, coding) => current + (coding.Code + ", ")).TrimEnd(new[] { ' ', ',' }),
                Location = documentReference.Location,
                Subject = documentReference.Subject.Display,
                Type =
                    documentReference.Type.Coding.Aggregate(string.Empty,
                        (current, coding) => current + (coding.Display + ", ")).TrimEnd(new[] { ' ', ',' })
            };
        }

        public static List<DocReference> Map(this List<DocumentReference> documentReferences)
        {
            return documentReferences.Select(Map).ToList();
        }
    }

    public static class DocumentManifestExtensions
    {
        public static DocManifest Map(this DocumentManifest documentManifest)
        {
            return new DocManifest
            {
                Author = documentManifest.Author.Aggregate(string.Empty,
                    (current, author) => current + (author.Display + ", ")).TrimEnd(new[] {' ', ','}),
                Content =
                    documentManifest.Content.Aggregate(string.Empty,
                        (current, content) => current + (content.Reference + ", ")).TrimEnd(new[] {' ', ','}),
                Description = documentManifest.Description,
                Subject =
                    documentManifest.Subject.Aggregate(string.Empty,
                        (current, subject) => current + (subject.Reference + ", ")).TrimEnd(new[] {' ', ','}),
                Type = documentManifest.Type.Text
            };
        }

        public static List<DocManifest> Map(this List<DocumentManifest> documentManifests)
        {
            return documentManifests.Select(Map).ToList();
        }
    }
}
