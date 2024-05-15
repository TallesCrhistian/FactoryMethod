using FactoryMethod.Interfaces;

namespace FactoryMethod.DocumentsTypes
{
    public class PdfDocumentProcessor : IDocumentProcessor
    {
        public void ReadMetadata()
        {
            Console.WriteLine("Reading metadata from PDF document");
        }

        public void ExtractText()
        {
            Console.WriteLine("Extracting text from PDF document");
        }
    }
}
