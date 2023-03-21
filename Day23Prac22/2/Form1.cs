namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox4.Text += Environment.NewLine + "Задание 2";
            double x = double.Parse(textBox1.Text);
           
            textBox4.Text += Environment.NewLine +
            "X = " + x.ToString();
           

            double q = double.Parse(textBox2.Text);
         
            textBox4.Text += Environment.NewLine +
            "Q = " + q.ToString();

   
           
            double k;
            if ((Math.Abs(q*x)) > 10)
                k =Math.Log10(Math.Pow(x,2) + Math.Abs(q));
            else
            if ((Math.Abs(q * x)) < 10)
                k = Math.Pow(Math.E,Math.Pow(x,2) + q);
            else
                k = Math.Pow(x,2) + q;

            // Вывод результата
            textBox4.Text += Environment.NewLine + "K = " + k.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}