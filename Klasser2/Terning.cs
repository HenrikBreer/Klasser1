using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser2
{
    class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public void Skriv()
        {
            System.Console.WriteLine("Værdi: [" + værdi.ToString()+"]");
        }

        public void Ryst()
        {
            if (snyd == false) { værdi = rnd.Next(1, 7); }
            else { værdi = 6; }

        }

        public Terning ()
        {
            værdi = 1;
            snyd = false;
        }

        public Terning(bool snyd)
        {
            værdi = 1;
            this.snyd = snyd;
        }
    }
}
