namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //textBox5.Text += Environment.NewLine +
            //"Задание 3 ";
            //double x0 = double.Parse(textBox1.Text);

            //double xk = double.Parse(textBox2.Text);
            //double dx = double.Parse(textBox3.Text);
            //double b = double.Parse(textBox4.Text);
            //double x = x0;
            //Console.WriteLine();
            //while (x <= (xk + dx / b))
            //{
            //    double y = x0 * Math.Sin(Math.Abs(x0 + b - 0.0084));
            //    textBox5.Text += Environment.NewLine + "x=" + Convert.ToString(x0) +
            //    "; y=" + Convert.ToString(y) ;

            //    x = x + dx;
            //}
            // Считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст. Иванов М.А." +
            Environment.NewLine;
            // Цикл для табулирования функции
            double x = x0;
            while (x <= (xk + dx / 2))
            {

                double y = x * Math.Sin(Math.Abs(x + b - 0.0084));
                textBox5.Text += "x=" + Convert.ToString(x) +
                "; y=" + Convert.ToString(y) +
                Environment.NewLine;

                x = x + dx;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}