using FactoryMethod;
using FactoryMethod.ConcreteProcessorFactory;
using FactoryMethod.Interfaces;

DocumentProcessorFactory pdf = new PdfProcessorFactory();

IDocumentProcessor pdfProcessor = pdf.FactoryMethod();
pdfProcessor.ExtractText();
pdfProcessor.ReadMetadata();

DocumentProcessorFactory word = new WordProcessorFactory();

IDocumentProcessor wordProcessor = word.FactoryMethod();
wordProcessor.ExtractText();
wordProcessor.ReadMetadata();