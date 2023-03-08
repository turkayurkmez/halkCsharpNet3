// See https://aka.ms/new-console-template for more information
using AbstractVSInterface;

Console.WriteLine("Hello, World!");

DataSource source = new XMLDataSource();
XMLDataSource xmlData = (XMLDataSource)source;
DbDataSource dbDataSource = new DbDataSource();


DataWriter dataWriter = new DataWriter();
//dataWriter.WriteDataToSource("test", xmlData);
dataWriter.WriteDataToSource("test2", dbDataSource);