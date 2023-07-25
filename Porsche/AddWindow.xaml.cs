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
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        // private object comboBoxKategorija;
        public Classes.Porsche Porsche = new Classes.Porsche();
        public static List<String> Kategorije = new List<string>() { "Taycan", "Carrera", "GT3 R Hybrid" };
        static BitmapImage bmp1 = new BitmapImage();
        static OpenFileDialog op1 = new OpenFileDialog();
        public AddWindow()
        {
            DataContext = this;
            InitializeComponent();
            comboBoxKategorija.ItemsSource = Kategorije;
            op1.FileName = "X";

        }
       
        
        private void buttonDodajSliku_Click(object sender, RoutedEventArgs e)
        {
            op1.FileName = "X";
            op1.InitialDirectory = @"C:\Users\Bojsa\Desktop\Porsche";
            op1.Title = "Select a picture";
            op1.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op1.ShowDialog() == true)
            {
                image1.Source = new BitmapImage(new Uri(op1.FileName));
                bmp1 = new BitmapImage(new Uri(op1.FileName));
            }
        }

        private void buttonIzadji_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {
            
            if (textBoxPorse_Modeli.Text.Trim().Equals(""))
            {
                labelPorse_Modeli_Greska.Content = "Morate uneti model porsea!";
                return;
            }

            if (textBoxPodnaslov.Text.Trim().Equals(""))
            {
                labelPodnaslov_Greska.Content = "Morate uneti podnaslov!";
                return;
            }

            if (textBoxTekst.Text.Trim().Equals(""))
            {
                labelTekst_Greska.Content = "Morate uneti tekst!";
                return;
            }

            if (comboBoxKategorija.SelectedItem == null)
            {
                labelKategorija_Greska.Content = "Morate selektovati kategoriju!";
                return;
            }
            if (image1.Source == null)
            {
                labelSlika_Greska.Content = "Morate uneti Sliku!";
                return;
            }
      

            Porsche = new Classes.Porsche(textBoxPorse_Modeli.Text,textBoxPodnaslov.Text,textBoxTekst.Text,comboBoxKategorija.SelectedItem.ToString(), op1.FileName);
            MainWindow.Porsches.Add(Porsche);
            this.Close();

        }
    }

    
}
