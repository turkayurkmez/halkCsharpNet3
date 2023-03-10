namespace usingTasks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selam");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            loop();

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://www.turkayurkmez.com");

            MessageBox.Show("Siteden veri çekildi");

            richTextBox1.Text = await response.Content.ReadAsStringAsync();




            MessageBox.Show("İşlem tamamlandı");
        }

        async Task loop()
        {
            await Task.Run(() =>
              {
                  for (int i = 0; i <= 10000; i++)
                  {
                      label1.Text = i.ToString();
                      progressBar1.Value = i / 1000;
                  }
              });
        }
    }
}