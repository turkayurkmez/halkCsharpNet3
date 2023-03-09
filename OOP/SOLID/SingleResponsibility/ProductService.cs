namespace SingleResponsibility
{
    public class ProductService
    {
        public int AddProduct(string name, decimal price)
        {
            string connectionString = "Data Source = (localdb)\\Mssqllocaldb; Initial Catalog = Northwind; Integrated Security = True";
            string commandText = "INSERT into Products (ProductName, UnitPrice) values (@name,@price)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@name", name },
                { "@price", price }
            };
            var dbHelper = new DbHelper(connectionString);
            int affectedRows = dbHelper.Execute(commandText, parameters);
            return affectedRows;
        }
    }
}
