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

        public int Vauhti { get; set; }

        public void Start()
        {
            Running = true;
            RadioOn = true;
        }

        public void Stop()
        {
            Running = false;
            Vauhti = 0;
        }
    }
}
