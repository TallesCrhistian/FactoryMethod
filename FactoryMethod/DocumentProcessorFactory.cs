using FactoryMethod.Interfaces;

namespace FactoryMethod
{
    public abstract class DocumentProcessorFactory
    {
        public abstract IDocumentProcessor FactoryMethod();       
    }
}
