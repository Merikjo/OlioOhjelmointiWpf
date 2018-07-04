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
using System.Windows.Threading;

namespace OlioOhjelmointiWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int luku = 123;

        //Car luokan alustaminen
        public Car auto1 = new Car(); //auto1 = muuttuja
        public Car auto2 = new Car();

        public DispatcherTimer VauhtiTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            //ominaisuuden asettaminen:
            //auto1 instanssille asetetaan Color ominaisuus punaiseksi:
            auto1.Color = "Punainen";
            auto2.Color = "Musta";

            VauhtiTimer.Tick += AutoKiihtyy_Tick;
            VauhtiTimer.Tick += AutoKiihtyy_Tick2;
            VauhtiTimer.Interval = new TimeSpan(0, 0, 1);
        }

        private void AutoKiihtyy_Tick(object sender, EventArgs e)
        {
            auto1.Vauhti = auto1.Vauhti + 1;
            lblVauhti.Content = auto1.Vauhti;
        }
        private void AutoKiihtyy_Tick2(object sender, EventArgs e)
        {
            auto2.Vauhti = auto2.Vauhti + 2;
            lblVauhti2.Content = auto2.Vauhti;
        }

        private void btnAuto1_Click(object sender, RoutedEventArgs e)
        {
            //määritellään apumuuttuja:
            string viesti = "Auto 1 on väriltään " +
                auto1.Color + ", auto on käynnissä: " +
                auto1.Running + " Matkustajaluettelo: " + auto1.Matkustajat +
                " auton vauhti on tällä hetkellä: " + auto1.Vauhti;

            MessageBox.Show(viesti);
        }

        private void btnAuto2_Click(object sender, RoutedEventArgs e)
        {
            //määritellään apumuuttuja:
            string viesti = "Auto 2 on väriltään " + auto2.Color + ", auto on käynnissä: " +
                auto2.Running + " Matkustajaluettelo: " + auto2.Matkustajat +
                " auton vauhti on tällä hetkellä: " + auto2.Vauhti; ;

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
            VauhtiTimer.Stop();
            lblVauhti.Content = auto1.Vauhti;
        }

        private void btnStopAuto2_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            auto2.Stop();
            VauhtiTimer.Stop();
            lblVauhti2.Content = auto2.Vauhti;
        }

        private void btnAjaAuto1_Click(object sender, RoutedEventArgs e)
        {
            if (auto1.Running)
            {
                VauhtiTimer.Start();
            }
            else
            {
                MessageBox.Show("Käynnistä auto ensin!");
            }
        }

        private void btnAjaAuto2_Click(object sender, RoutedEventArgs e)
        {
            if (auto2.Running)
            {
                VauhtiTimer.Start();
            }
            else
            {
                MessageBox.Show("Käynnistä auto ensin!");
            }
        }

        private void btnLisaaMatkustaja_Click(object sender, RoutedEventArgs e)
        {
            auto1.Matkustajat = txtMatkustajat.Text;
        }

        private void btnLisaaMatkustaja2_Click(object sender, RoutedEventArgs e)
        {
            auto2.Matkustajat = txtMatkustajat2.Text;
        }

        private void btnPoistaMatkustaja_Click(object sender, RoutedEventArgs e)
        {
            auto1.Matkustajat = "";
            txtMatkustajat.Text = "";
        }

        private void btnPoistaMatkustaja2_Click(object sender, RoutedEventArgs e)
        {
            auto2.Matkustajat = "";
            txtMatkustajat2.Text = "";
        }
    }
}
