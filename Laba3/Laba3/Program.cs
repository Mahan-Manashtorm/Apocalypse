using da;

DocumentRepository documentRepository = DocumentRepository.Instance;
Document document = new Document
{
    Id = 1,
    Name = "Документ 1",
    Content = "Содержимое документа 1"
};
documentRepository.AddDocument(document);
List<Document> documents = documentRepository.GetDocuments();
foreach (var doc in documents)
{
    Console.WriteLine($"ID: {doc.Id}, Name: {doc.Name}, Content: {doc.Content}");
}

Console.ReadLine();