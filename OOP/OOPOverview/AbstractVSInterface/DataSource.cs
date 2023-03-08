namespace AbstractVSInterface
{

    public interface IRecordableDataSource
    {
        void Write(string data);
    }
    public abstract class DataSource
    {
        // public abstract void WriteData(string data);
        public abstract string ReadData();

        public string ConnectionString { get; set; }
        public void Dispose()
        {
            Console.WriteLine("Datasource bellekten kaldırıldı");
        }


    }



    public class XMLDataSource : DataSource
    {
        public override string ReadData()
        {
            return "XML'den veri okunuyor";
        }

        //public override void WriteData(string data)
        //{
        //    Console.WriteLine($"{data}, XML kaynağına yazılıyor");
        //}

        public int NodeCount { get; set; }
    }

    public class DbDataSource : DataSource, IRecordableDataSource
    {
        public override string ReadData()
        {
            throw new NotImplementedException();
        }

        public void Write(string data)
        {
            Console.WriteLine($"{data}, DB kaynağına yazılıyor");

        }
    }

    public class ExcelDataSource : DataSource, IRecordableDataSource
    {
        public override string ReadData()
        {
            throw new NotImplementedException();
        }

        public void Write(string data)
        {
            throw new NotImplementedException();
        }
    }

    public class DataWriter
    {
        public void WriteDataToSource(string data, IRecordableDataSource recordable)
        {
            recordable.Write(data);

        }
    }
}
