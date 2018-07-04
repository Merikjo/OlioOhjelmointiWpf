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

namespace OlioOhjelmointiWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Car luokan alustaminen
        public Car auto1 = new Car(); //auto1 = muuttuja
        public Car auto2 = new Car();

        public MainWindow()
        {
            InitializeComponent();
            //ominaisuuden asettaminen:
            //auto1 instanssille asetetaan Color ominaisuus punaiseksi:
            auto1.Color = "Punainen";
            auto2.Color = "Musta";
        }

        private void btnAuto1_Click(object sender, RoutedEventArgs e)
        {
            //määritellään apumuuttuja:
            string viesti = "Auto 1 on väriltään " + auto1.Color + ", auto on käynnissä: " +
                auto1.Running;

            MessageBox.Show(viesti);
        }

        private void btnAuto2_Click(object sender, RoutedEventArgs e)
        {
            //määritellään apumuuttuja:
            string viesti = "Auto 2 on väriltään " + auto2.Color + ", auto on käynnissä: " +
                auto2.Running;

            MessageBox.Show(viesti);
        }

        private void btnStartAuto1_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            //auto1.Running = true;
            auto1.Start();
        }

        private void btnStartAuto2_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            auto2.Start();
        }

        private void btnStopAuto1_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            auto1.Stop();
        }

        private void btnStopAuto2_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            auto2.Stop();
        }
    }
}
