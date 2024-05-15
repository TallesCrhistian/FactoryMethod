using FactoryMethod.DocumentsTypes;
using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteProcessorFactory
{
    public class PdfProcessorFactory : DocumentProcessorFactory
    {
        public override IDocumentProcessor FactoryMethod()
        {
            return new PdfDocumentProcessor();
        }
    }
}
