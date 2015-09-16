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

namespace WarsztatMalina
{
    /// <summary>
    /// Interaction logic for Panel_Administracji_Kontami.xaml
    /// </summary>
    public partial class Panel_Administracji_Kontami : Window
    {
        public List<DaneLog> listaPomocnicza = new List<DaneLog>(); 
        
        public Panel_Administracji_Kontami()
        {
            InitializeComponent();
            
        }

        private void DodajKonto(object sender, RoutedEventArgs e)
        {
            if (NazwaUzyt.Text!="")
            {
                if (HasloUzyt.Text==HasloUzytPotw.Text)
                {
                    listaPomocnicza.Add(new DaneLog(NazwaUzyt.Text, HasloUzyt.Text));
                    ListaKont.Items.Refresh();
                    NazwaUzyt.BorderBrush = Brushes.Black;
                    HasloUzytPotw.BorderBrush = Brushes.Black;
                    HasloUzyt.BorderBrush = Brushes.Black;
                }
                else
                {
                    HasloUzyt.BorderBrush = Brushes.Red;
                    HasloUzytPotw.BorderBrush = Brushes.Red;
                }
            }
            else
            {
                NazwaUzyt.BorderBrush = Brushes.Red;
            }
            
        }

        private void ZmienDane(object sender, RoutedEventArgs e)
        {
            if (ListaKont.SelectedIndex >= 0)
            {
                if (NazwaUzyt.Text != "")
                {
                    if (HasloUzyt.Text == HasloUzytPotw.Text)
                    {

                        int z = ListaKont.SelectedIndex;
                        listaPomocnicza[z].Name = NazwaUzyt.Text;
                        listaPomocnicza[z].Password = HasloUzyt.Text;
                        ListaKont.Items.Refresh();
                        ListaKont.BorderBrush = Brushes.Black;
                        NazwaUzyt.BorderBrush = Brushes.Black;
                        HasloUzytPotw.BorderBrush = Brushes.Black;
                        HasloUzyt.BorderBrush = Brushes.Black;
                    }
                    else
                    {
                        HasloUzyt.BorderBrush = Brushes.Red;
                        HasloUzytPotw.BorderBrush = Brushes.Red;
                    }
                }
                else
                {
                    NazwaUzyt.BorderBrush = Brushes.Red;
                }
            }
            else
                ListaKont.BorderBrush = Brushes.Red;
        }

        private void Usun(object sender, RoutedEventArgs e)
        {
            if (ListaKont.SelectedIndex >= 0)
            {
                listaPomocnicza.RemoveAt(ListaKont.SelectedIndex);
                ListaKont.Items.Refresh();
                ListaKont.BorderBrush = Brushes.Black;
            }
            else
                ListaKont.BorderBrush = Brushes.Red;
        }

        private void SelectChanged(object sender, SelectionChangedEventArgs e)
        {
            var se = ListaKont.SelectedItem as DaneLog;
            NazwaUzyt.Text = se.Name;
            HasloUzyt.Text = se.Password;
            HasloUzytPotw.Text = se.Password;

        }


    }
}
