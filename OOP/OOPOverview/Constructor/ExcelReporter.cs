namespace Constructor
{
    public class ExcelReporter
    {
        public string Title { get; set; }
        public string Path { get; set; }

        public string DefaultFolder { get; set; }
        public ExcelReporter()
        {
            DefaultFolder = "C:\\Documents";
        }

        public ExcelReporter(string defaultFolder) : this(defaultFolder, "report1.rpt")
        {
            //constructor, constructor'u this aracılığıyla çağırır.
        }
        public ExcelReporter(string defaultFolder, string fileName)
        {
            DefaultFolder = defaultFolder;
            Path = System.IO.Path.Combine(DefaultFolder, fileName);
        }
    }
}
