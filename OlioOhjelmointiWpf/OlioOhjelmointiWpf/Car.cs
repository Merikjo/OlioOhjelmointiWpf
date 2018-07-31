using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlioOhjelmointiWpf
{
    public class Car
    {
        public string Color { get; set; }
        public string Matkustajat { get; set; }
        public bool Running { get; set; }
        public bool RadioOn { get; set; }
        public string Model { get; set; }

        private int maxSpeed; //kenttä, mikä on tyhjä. Kenttä on tiedon tallennuspaikka ja vie muistia. Ominaisuus ei vie muistia, koska se vain viittaa kenttään.

        public int MaxSpeed {
            get
            {
                return maxSpeed;
            }
            set
            {
                if ((value > 0) && (value < 500)) //value korvautuu sillä arvolla, joka sille asetetaan, joko käyttöliittymän kautta asetettu tai kovakoodattu arvo.
                {
                    maxSpeed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int Vauhti { get; set; }

        public void Start() //metodi
        {
            Running = true;
            RadioOn = true;
        }

        public void Stop() //metodi
        {
            Running = false;
            Vauhti = 0;
        }

        //internal void SetMaxSpeed(int max)
        //{
        //    if ((max > 0) && (max < 500))
        //    {
        //        MaxSpeed = max;
        //    }
            
        //    else
        //    {
        //        throw new ArgumentOutOfRangeException("max");
        //    }
        //}
    }
}
