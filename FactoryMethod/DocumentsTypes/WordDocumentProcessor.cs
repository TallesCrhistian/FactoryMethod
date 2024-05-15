using FactoryMethod.Interfaces;

namespace FactoryMethod.DocumentsTypes
{
    public class WordDocumentProcessor : IDocumentProcessor
    {
        public void ReadMetadata()
        {
            Console.WriteLine("Reading metadata from Word document");
        }

        public void ExtractText()
        {
            Console.WriteLine("Extracting text from Word document");
        }
    }
}
