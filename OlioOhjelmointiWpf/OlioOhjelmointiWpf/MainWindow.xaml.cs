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
using System.Speech.Synthesis;

namespace OlioOhjelmointiWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Car luokan alustaminen - kutsutaan car -luokan konstruktoria /rakentajaa
        public Car auto1 = new Car(); //auto1 = muuttuja l. instanssi
        public Car auto2 = new Car();

        public DispatcherTimer VauhtiTimer = new DispatcherTimer();
        public DispatcherTimer VauhtiTimer2 = new DispatcherTimer();

        public SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
        public int luku = 123;

        //suoritetaan, kun sovellus käynnistyy ensimmäisen kerran
        public MainWindow()
        {
            InitializeComponent();
            //ominaisuuden asettaminen:
            //auto1 instanssille asetetaan Color ominaisuus punaiseksi:
            auto1.Color = "Punainen";
            auto2.Color = "Sininen";

            auto1.Model = "Volvo";
            auto2.Model = "Audi";

            int maxSpeed = int.Parse(maxSpeedTextBox.Text);

            VauhtiTimer.Tick += AutoKiihtyy_Tick;
            VauhtiTimer2.Tick += AutoKiihtyy_Tick2;
            VauhtiTimer.Interval = new TimeSpan(0, 0, 1);
            VauhtiTimer2.Interval = new TimeSpan(0, 0, 1);


            //auto1.SetMaxSpeed(160);
            auto1.MaxSpeed = 160;

            //auto1.SetMaxSpeed(200);
            auto2.MaxSpeed = 200;

            
              
        }

        #region Auto1

        private void btnAuto1_Click(object sender, RoutedEventArgs e)
        {
            //. = notaatio, jota seuraa joko ominaisuus tai metodi, jonka jälkeen tuleet sulut
            //määritellään apumuuttuja:
            string viesti = 
                auto1.Model + " Auto 1 on väriltään " + 
                auto1.Color + " Max nopeus: " + 
                auto1.MaxSpeed + ", Auto on käynnissä: " + 
                auto1.Running + " Matkustajaluettelo: " + 
                auto1.Matkustajat + " Auton vauhti on tällä hetkellä: " + 
                auto1.Vauhti;

            MessageBox.Show(viesti);
        }

        private void btnStartAuto1_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            //auto1.Running = true; //vaihtoehtoinen asettaminen
            auto1.Start();
            auto1.ValoPaalla(50);
            txtValoAuto1.Text = auto1.Valo;
            txtValoAuto1.Background = Brushes.Yellow;

            speechSynthesizer.Speak("Car 1 is running");
        }

        private void btnStopAuto1_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            auto1.Stop();
            VauhtiTimer.Stop();
            lblVauhti1.Content = auto1.Vauhti;
            auto1.ValoPois();
            txtValoAuto1.Text = auto1.Valo;
            txtValoAuto1.Background = Brushes.White;
        }

        private void btnLisaaMatkustaja_Click(object sender, RoutedEventArgs e)
        {
            auto1.Matkustajat = txtMatkustajat.Text;
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

        private void btnPoistaMatkustaja_Click(object sender, RoutedEventArgs e)
        {
            auto1.Matkustajat = "";
            txtMatkustajat.Text = "";
        }


        private void AutoKiihtyy_Tick(object sender, EventArgs e)
        {
            auto1.Vauhti = auto1.Vauhti + 1;
            lblVauhti1.Content = auto1.Vauhti;
        }

        private void BtnValoAuto1_Click(object sender, RoutedEventArgs e)
        {
            auto1.ValoPaalla(30);
            txtValoAuto1.Text = auto1.Valo;
            txtValoAuto1.Background = Brushes.LightBlue;
        }

        #endregion

        #region Auto2




        private void btnAuto2_Click(object sender, RoutedEventArgs e)
        {
            //määritellään apumuuttuja:
            string viesti = auto2.Model + " Auto 2 on väriltään " + auto2.Color + " Max nopeus: " + auto1.MaxSpeed 
                + ", auto on käynnissä: " + auto2.Running + " Matkustajaluettelo: " + auto2.Matkustajat +
                " auton vauhti on tällä hetkellä: " + auto2.Vauhti; ;

            MessageBox.Show(viesti);
        }

 

        private void btnStartAuto2_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            auto2.Start();
            auto2.ValoPaalla(50);
            txtValoAuto2.Text = auto2.Valo;
            txtValoAuto2.Background = Brushes.Yellow;

            speechSynthesizer.Speak("Car 2 is running");
        }

      

        private void btnStopAuto2_Click(object sender, RoutedEventArgs e)
        {
            //Metodin kutsuminen:
            auto2.Stop();
            VauhtiTimer2.Stop();
            lblVauhti2.Content = auto2.Vauhti;

            auto2.ValoPois();
            txtValoAuto2.Text = auto2.Valo;
            txtValoAuto2.Background = Brushes.White;
        }

        private void btnAjaAuto2_Click(object sender, RoutedEventArgs e)
        {
            if (auto2.Running)
            {
                VauhtiTimer2.Start();
            }
            else
            {
                MessageBox.Show("Käynnistä auto ensin!");
            }
        }

   

        private void btnLisaaMatkustaja2_Click(object sender, RoutedEventArgs e)
        {
            auto2.Matkustajat = txtMatkustajat2.Text;
        }

    

        private void btnPoistaMatkustaja2_Click(object sender, RoutedEventArgs e)
        {
            auto2.Matkustajat = "";
            txtMatkustajat2.Text = "";
        }

        private void AutoKiihtyy_Tick2(object sender, EventArgs e)
        {
            auto2.Vauhti = auto2.Vauhti + 1;
            lblVauhti2.Content = auto2.Vauhti;
        }

        #endregion

     
    }
}
