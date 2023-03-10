namespace AsynchronousProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread loopThread = null;
        //ThreadStart threadStart=null;


        private void button1_Click(object sender, EventArgs e)
        {
            loopThread = new Thread(new ThreadStart(countWithLoop));
            loopThread.Start();

            showResponse();

            MessageBox.Show("Ben de çalıştım");


        }

        private void showResponse()
        {
            MessageBox.Show("Ben çalıştım");
        }

        public void countWithLoop()
        {
            for (int i = 0; i <= 100000; i++)
            {
                label1.Text = i.ToString();
                progressBar1.Value = i / 1000;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj...");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}