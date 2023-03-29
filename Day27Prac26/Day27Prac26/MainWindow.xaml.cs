using Day27Prac26.Models;
using Day27Prac26.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Day27Prac26
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var path = "D:\\кпияп\\практика по с#\\Practica\\Day27Prac26\\Day27Prac26\\File\\sweets.xml\\";
            SweetsSet sweets = new SweetsSet();
            XmlDocumentSweets xml = new XmlDocumentSweets();
            xml.Add(sweets);
        
           
        }
    }
}
