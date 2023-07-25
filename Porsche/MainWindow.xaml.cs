using Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Porsche
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static BindingList<Classes.Porsche> Porsches { get; set; }
        private DataIO serializer = new DataIO();

        public MainWindow()
        {
            
            Porsches = serializer.DeSerializeObject<BindingList<Classes.Porsche>>("stanje_sistema.xml");
            if(Porsches == null)
                Porsches = new BindingList<Classes.Porsche>();

            DataContext = this;                     //najbitnija linija,ovde ce se rezolvovati sve promene u nasoj listi
            InitializeComponent();
        }
        
        private void buttonChange_Click(object sender, RoutedEventArgs e)
        {
            Classes.Porsche p = (Classes.Porsche)dataGridPorsche.CurrentItem;
            new ChangeWindow(p).ShowDialog();
        }
        private void buttonRead_Click(object sender, RoutedEventArgs e)
        {
            Classes.Porsche p = (Classes.Porsche)dataGridPorsche.CurrentItem;
            new ReadWindow(p).ShowDialog();
        }
       
        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            Classes.Porsche p = (Classes.Porsche)dataGridPorsche.CurrentItem;
            Porsches.Remove(p);
        }

        private void buttonIzlaz_Click(object sender, RoutedEventArgs e)
        {
            serializer.SerializeObject<BindingList<Classes.Porsche>>(Porsches, "stanje_sistema.xml");
            this.Close();
        }

        private void buttonDodaj_Click(object sender, RoutedEventArgs e)
        {
            AddWindow newWindow = new AddWindow();
            newWindow.ShowDialog();
           // dataGridPorsche.Items.Refresh();
        }

       

    }
}
