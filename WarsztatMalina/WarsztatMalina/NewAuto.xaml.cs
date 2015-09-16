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
    /// Interaction logic for NewAuto.xaml
    /// </summary>
    public partial class NewAuto : Window
    {
        public NewAuto()
        {
            InitializeComponent();
        }

        public void ValiNumberInput(KeyEventArgs e)
        {
            if (e.Key != Key.D1 && e.Key != Key.D2 && e.Key != Key.D3 && e.Key != Key.D4 && e.Key != Key.D5 && e.Key != Key.D6 && e.Key != Key.D7 && e.Key != Key.D8 && e.Key != Key.D9 && e.Key != Key.D0)
            {
                e.Handled = true;
            }
        }
        public void GotFocusStuff(RoutedEventArgs e)
        {
            var z = e.Source as TextBox;
            z.ToolTip = z.Text;
            z.Text = "";
            e.Source = z;
        }

        private void PrzebiegTb_KeyDown(object sender, KeyEventArgs e)
        {
            ValiNumberInput(e);
        }

        private void Nr_RejTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            NrRejCB.IsChecked = true;
        }

        private void MarkaTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
             MarkaCB.IsChecked = true;
        }

        private void ModelTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            ModelCB.IsChecked = true;
        
        }

        private void SilnikTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            SilnikCB.IsChecked = true;
        }

        private void PojemnoscTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            PojemCB.IsChecked = true;
        }

        private void RocznikTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            RocznikCB.IsChecked = true;
        }

        private void PoprzWizytaTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            PoprzWizytaCB.IsChecked = true;
        }

        private void KolBadanieTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            KolBadCB.IsChecked = true;
        }

        private void PrzebiegTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            PrzebiegCB.IsChecked = true;
        }

        private void TelTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            NrTelCB.IsChecked = true;
        }

        private void ImieTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            ImieCB.IsChecked = true;
        }

        private void NazwiskoTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            NazwiskoCB.IsChecked = true;
        }

        private void AdresTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            AdresCB.IsChecked = true;
        }

        private void UslOpisTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            UslOpisCB.IsChecked = true;
        }

        private void UsterkiOpisTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            UsterOpisCB.IsChecked = true;
        }

        private void NaprDataTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            NaprDataCB.IsChecked = true;
        }

        private void KosztUslTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            KosztUslCB.IsChecked = true;
        }

        private void WykonawcaTb_GotFocus(object sender, RoutedEventArgs e)
        {
            GotFocusStuff(e);
            WykonawcaCB.IsChecked = true;
        }






    }
}
