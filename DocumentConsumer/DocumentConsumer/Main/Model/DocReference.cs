using System.ComponentModel;

namespace DocumentConsumer.Main.Model
{
    public class DocReference
    {
        public string Author { get; set; }
        public string Confidentiality { get; set; }

        [DisplayName("Document Status")]
        public string DocumentStatus { get; set; }

        public string Subject { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
    }
}