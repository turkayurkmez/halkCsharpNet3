namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Bir nesnenin; sadece bir sorumluluğu olmalı.
         * Eğer bir nesne içerisindeki kodlarda veya metodlarda değişiklik yapmak için birden fazla sebebiniz varsa, bu ilkeyi ihlal ediyorsunuz demektir.
         * Class adına; o classın sorumluluğunu sorun!
         */

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {

            string name = textBoxProductName.Text;
            decimal price = Convert.ToDecimal(textBoxPrice.Text);
            string message = AddProduct(name, price);
            MessageBox.Show(message);


        }

        private string AddProduct(string name, decimal price)
        {
            int affectedRows = new ProductService().AddProduct(name, price);
            string message = affectedRows > 0 ? "Başarılı" : "Kaydedilemedi";
            return message;
        }
    }
}