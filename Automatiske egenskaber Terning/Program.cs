using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automatiske_egenskaber_Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            Console.WriteLine(t1.Værdi);
            t1.Ryst();
            Console.WriteLine(t1.Værdi);
            t1.Ryst();
            Console.WriteLine(t1.Værdi);
            t1.Ryst();
            Console.WriteLine(t1.Værdi);
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();







            Console.ReadKey();
        }
    }


    public class Terning
    {
        private int _værdi;

        public int Værdi
        {
            get {
                Console.WriteLine("Værdi læses");
                return _værdi; }
            set
            {
                Console.WriteLine("Værdi sættes");
                if (value <1 || value > 6) { value = 1; }
                    _værdi = value;
            }
        }

        private static Random rnd = new Random();

        public void Ryst()
        {
            Værdi = rnd.Next(1,7);
        }

        public void Skriv()
        {
            Console.WriteLine("["+Værdi+"]");
        }







    }

}
