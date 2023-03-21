namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text += Environment.NewLine + "Задание 1 ";
            double x = double.Parse(textBox1.Text);

            textBox4.Text += Environment.NewLine +
            "X = " + x.ToString();
      
            double y = double.Parse(textBox2.Text);
     
            textBox4.Text += Environment.NewLine +
            "Y = " + y.ToString();


            double z = double.Parse(textBox3.Text);
       
            textBox4.Text += Environment.NewLine +
            "Z = " + z.ToString();

    
            double u = Math.Pow(2, -x);
            double b = Math.Sqrt(x + Math.Sqrt(Math.Abs(y)));
            double c = Math.Sqrt(Math.Pow(Math.E,x-(1/Math.Sin(z))));
            double a = u * b * c;
       
            textBox4.Text += Environment.NewLine +
            "Результат A = " + a.ToString();
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
    }
}