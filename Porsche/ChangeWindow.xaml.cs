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
    /// Interaction logic for ChangeWindow.xaml
    /// </summary>
    public partial class ChangeWindow : Window
    {
        // private object comboBoxKategorija;
        public Classes.Porsche Porsche = new Classes.Porsche();
        public Classes.Porsche oldPorsche = new Classes.Porsche();
        public static List<String> Kategorije = new List<string>() { "Taycan", "Carrera", "GT3 R Hybrid" };
        public ChangeWindow(Classes.Porsche p)
        {
            DataContext = this;
            InitializeComponent();
            Porsche = new Classes.Porsche(p.Porse_Modeli,p.Podnaslov,p.Tekst,p.Kategorija,p.Slika);
            oldPorsche = p;
            textBoxPodnaslov.Text = p.Podnaslov;
            textBoxPorse_Modeli.Text = p.Porse_Modeli;
            textBoxTekst.Text = p.Tekst;
            comboBoxKategorija.ItemsSource = Kategorije;
            comboBoxKategorija.SelectedItem = p.Kategorija;
            image1.Source = new BitmapImage(new Uri(p.Slika));
            bmp1 = new BitmapImage(new Uri(p.Slika));
            comboBoxKategorija.ItemsSource = Kategorije;
            op1.FileName = p.Slika;

        }
        static BitmapImage bmp1 = new BitmapImage();
        static OpenFileDialog op1 = new OpenFileDialog();

        private void buttonDodajSliku_Click(object sender, RoutedEventArgs e)
        {
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


        private void buttonIzmeni_Click(object sender, RoutedEventArgs e)
        {
            
           
            if (textBoxPorse_Modeli.Text.Trim().Equals("") )
            {
                labelPorse_Modeli_Greska.Content = "Morate uneti model porsea!";
                return;
            }
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

            Porsche = new Classes.Porsche(textBoxPorse_Modeli.Text, textBoxPodnaslov.Text, textBoxTekst.Text, comboBoxKategorija.SelectedItem.ToString(), op1.FileName);

            if (oldPorsche.Porse_Modeli == Porsche.Porse_Modeli && oldPorsche.Podnaslov == Porsche.Podnaslov && oldPorsche.Kategorija == Porsche.Kategorija && oldPorsche.Slika == Porsche.Slika && oldPorsche.Tekst == Porsche.Tekst)
            {
                MessageBox.Show("Nisi nista izmenio!");
                // this.Close();

            }
            else
            {
                MainWindow.Porsches.Remove(oldPorsche);
                MainWindow.Porsches.Add(Porsche);
                this.Close();
            }
          

        }
    }
}

