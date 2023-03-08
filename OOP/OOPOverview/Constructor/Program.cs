// See https://aka.ms/new-console-template for more information
using Constructor;

Console.WriteLine("Hello, World!");

ExcelReporter excelReporter = new ExcelReporter();
Console.WriteLine(excelReporter.DefaultFolder);
ExcelReporter excelReporter1 = new ExcelReporter("C:\\Desktop", "sales2023.rpt");
Console.WriteLine(excelReporter1.Path);

ExcelReporter excelReporter2 = new ExcelReporter { Title = "reportName", Path = "C:\\Images\\image.png" };
