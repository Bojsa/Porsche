using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace Porsche
{
    /// <summary>
    /// Interaction logic for ReadWindow.xaml
    /// </summary>
    public partial class ReadWindow : Window
    {
        static BitmapImage bmp1 = new BitmapImage();
        static OpenFileDialog op1 = new OpenFileDialog();
        public ReadWindow(Classes.Porsche p)
        {
            DataContext = this;
            InitializeComponent();

            textBoxPodnaslov.Text = p.Podnaslov;
            textBoxPorse_Modeli.Text = p.Porse_Modeli;
            textBoxTekst.Text = p.Tekst;
            textBoxKategorije.Text = p.Kategorija;
            image1.Source = new BitmapImage(new Uri(p.Slika));
            bmp1 = new BitmapImage(new Uri(p.Slika));

        }
        private void buttonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
    }
}
