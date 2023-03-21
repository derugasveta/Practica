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

        private void button1_Click(object sender, EventArgs e)
        {
            char i = char.Parse(textBox1.Text);
            char j = char.Parse(textBox2.Text);
            string str = (string)listBox1.Items[0];

            foreach (var item in str)
            {
                if(item == i)
                {
                    i = j;
                }
                else
                {
                  
                }
            }
            label3.Text += Environment.NewLine +  str;
        }
    }
}