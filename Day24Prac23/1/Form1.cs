using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

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

          
            string selectedText = listBox1.SelectedItem?.ToString();

            if (selectedText != null)
            {
                
                char charI = textBox1.Text.Length > 0 ? textBox1.Text[0] : '\0';

              
                char charJ = textBox2.Text.Length > 0 ? textBox2.Text[0] : '\0';

               
                string replacedText = ReplaceChars(selectedText, charI, charJ);

               
                label3.Text = replacedText;
            }
        }
        private string ReplaceChars(string text, char charI, char charJ)
        {
            
            char[] newChars = text.ToCharArray();

         
            for (int i = 0; i < newChars.Length; i++)
            {
                if (newChars[i] == charI)
                {
                    newChars[i] = charJ;
                }
               
            }

            return new string(newChars);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}