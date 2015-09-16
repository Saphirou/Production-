using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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


namespace WarsztatMalina
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BinaryFormatter bf = new BinaryFormatter();
        List<DaneLog> dl = new List<DaneLog>();
        
        public MainWindow()
        {
            //dl.Add(new DaneLog("admin", "admin1"));
            //dl.Add(new DaneLog("zzz", "xxx"));
            //serialize();
            deserialize();
            //lt.ItemsSource = dl;
            //lt.Items.Refresh();
            
            
            InitializeComponent();
        }
        private void MainWin_Loaded(object sender, RoutedEventArgs e)
        {
            LoginTB.Focus();
        }

        private void Zaloguj(object sender, RoutedEventArgs e)
        {
            LoginOkBT.IsDefault = false;

            if (LoginTB.Text=="m" && PasswordPB.Password=="a")
            {
                Panel_Administracji_Kontami admin = new Panel_Administracji_Kontami();
                admin.listaPomocnicza = dl;
                admin.ListaKont.ItemsSource = admin.listaPomocnicza;
                admin.ShowDialog();
                dl = admin.listaPomocnicza;
                serialize();
              
            }
#region
            else
            {
                var dictZmiennna = dl.ToDictionary(z => z.Name);

                //.Where(d => d.Name == LoginTB.Text);
                if (dictZmiennna.ContainsKey(LoginTB.Text))
                {
                    if (dictZmiennna[LoginTB.Text].Password == PasswordPB.Password)
                    {
                        //MessageBox.Show("Well Done!");
                        PanelLogowaniaGB.Visibility = Visibility.Hidden;
                        MainGrid.Visibility = Visibility.Visible;

                    }
                    else
                        //MessageBox.Show("Błędne hasło!");
                        PasswordPB.SetValue(Border.BorderBrushProperty, Brushes.Red);
                }
                else
                    LoginTB.SetValue(Border.BorderBrushProperty, Brushes.Red);
                //MessageBox.Show("Nieznany login.");
            }
#endregion 


        }

        void serialize()
        {
            using (Stream stream = File.Create("data1.bin"))
            {
                bf.Serialize(stream, dl);
            }
        }
        void deserialize()
        {
            using (Stream str = File.Open("data1.bin",FileMode.Open))
            {
                dl = (List<DaneLog>)bf.Deserialize(str);
                
            }
        }

        private void aas(object sender, RoutedEventArgs e)
        {
            lt.ItemsSource = dl;
            lt.Items.Refresh();
        }

        private void Szukaj(object sender, RoutedEventArgs e)
        {
            NewAuto dodajDaneOkno = new NewAuto();
            dodajDaneOkno.Show();
        }

        private void Usun_Dane_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //testy - wywal
            if (e.Key != Key.D1 && e.Key != Key.D2 && e.Key != Key.D3 && e.Key != Key.D4 && e.Key != Key.D5 && e.Key != Key.D6 && e.Key != Key.D7 && e.Key != Key.D8 && e.Key != Key.D9 && e.Key != Key.D0)
            {
                e.Handled = true;
            }
        }

        private void DoWyw(object sender, RoutedEventArgs e)
        {
            //testy do wyw
            var z = (TextBox)e.Source;
            z.ToolTip = z.Text;
            z.Text = "";
            e.Source = z;
        }

      

    }
}
