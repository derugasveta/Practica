using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Point(object sender, EventArgs e)
        {

        }

        private void Form_Point(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            string text = "Телефон";
            g.Clear(Color.Yellow);
            Rectangle rec = new Rectangle();
            SolidBrush sB = new SolidBrush(Color.Black);
            g.FillRectangle(sB, 8, 30, 130, 200);
         SolidBrush sB2 = new SolidBrush(Color.BlueViolet);
            g.FillRectangle(sB2, 20, 50, 105, 155);
            SolidBrush sB3 = new SolidBrush(Color.Gray);
            g.FillEllipse(sB3, 60, 208, 20, 20);

            Pen pen = new Pen(Color.Black, 2);
            g.DrawLine(pen, 80, 230,80,300);

;           g.DrawLine(pen, 80, 300, 60, 350);

            g.DrawLine(pen, 80, 300, 100, 350);

            SolidBrush sB4 = new SolidBrush(Color.Pink);
            g.FillEllipse(sB4, 53, 350, 15, 15);
            SolidBrush sB5 = new SolidBrush(Color.Pink);
            g.FillEllipse(sB5, 93, 350, 15, 15);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
