namespace Sample
{
    public partial class Form1 : Form
    {

        DateTime date = DateTime.Now.Date;



        public Form1()
        {
            InitializeComponent();
            label4.Text = date.Day.ToString();
            label3.Text = date.Month.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            date = date.AddMonths(1);
            UpDateLabels();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            date = date.AddMonths(-1);
            UpDateLabels();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            date = date.AddDays(1);
            UpDateLabels();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            date = date.AddDays(-1);
            UpDateLabels();
        }

        private void UpDateLabels()
        {
            label3.Text = date.Month.ToString();
            label4.Text = date.Day.ToString();            
        }
    }
}