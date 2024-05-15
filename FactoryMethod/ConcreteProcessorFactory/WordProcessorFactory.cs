using FactoryMethod.DocumentsTypes;
using FactoryMethod.Interfaces;

namespace FactoryMethod.ConcreteProcessorFactory
{
    public class WordProcessorFactory : DocumentProcessorFactory
    {
        public override IDocumentProcessor FactoryMethod()
        {
            return new WordDocumentProcessor();
        }
    }
}
