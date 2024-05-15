# Document Processing System
This repository contains a C# project that demonstrates the Factory Method pattern in the context of a document processing system. The project allows for the creation and processing of different types of documents, such as PDFs, Word documents, and plain text files, using the Factory Method pattern.

## Overview
The Factory Method pattern is a creational design pattern that provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. In this project, we use the Factory Method pattern to encapsulate the creation of document processors for different document types.

## Features
Support for processing different document types:
PDF documents
Word documents
Plain text files
Encapsulation of document processor creation logic using the Factory Method pattern.
Demonstrates how to extend the system with new document types without modifying existing code.
## Project Structure
Interfaces:

IDocumentProcessor: Defines methods for document processing operations.
Concrete Implementations:

PdfDocumentProcessor: Implements document processing for PDF documents.
WordDocumentProcessor: Implements document processing for Word documents.
PlainTextDocumentProcessor: Implements document processing for plain text files.
Factories:

DocumentProcessorFactory: Abstract class for creating document processors.
PdfDocumentProcessorFactory, WordDocumentProcessorFactory, PlainTextDocumentProcessorFactory: Concrete factory classes for each document type.
Main Program:

Program.cs: Demonstrates the usage of document processors with different document types.
## Usage
Clone this repository to your local machine.
Open the project in your preferred IDE (e.g., Visual Studio).
Compile and run the project to see the document processing system in action.
## Contribution
Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

Fork the repository.
Create your feature branch (git checkout -b feature/your-feature).
Commit your changes (git commit -am 'Add your feature').
Push to the branch (git push origin feature/your-feature).
Create a new Pull Request.
