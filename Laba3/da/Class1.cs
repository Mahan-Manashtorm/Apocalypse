using System.Reflection.Metadata;

namespace da
{
    public class DocumentRepository
    {
        private static DocumentRepository instance;
        private List<Document> documents;

        private DocumentRepository()
        {
            documents = new List<Document>();
        }
        public static DocumentRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DocumentRepository();
                }
                return instance;
            }
        }
        public void AddDocument(Document document)
        {
            documents.Add(document);
        }

        public List<Document> GetDocuments()
        {
            return documents;
        }
    }
    public class Document
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
    }
}