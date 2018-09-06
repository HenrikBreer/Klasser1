using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndkapslingEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();
            v1.Navn = "Rugbrød";
            v1.Pris = 25.95;
            Console.WriteLine( v1.PrismedMoms());
            Console.WriteLine(v1.Navn);
            Console.WriteLine(v1.Pris);
            Console.ReadKey();


            Vare v2 = new Vare("Franskbrød", 18.95);
       
            Console.WriteLine(v2.PrismedMoms());
            Console.WriteLine(v2.PrisMedMomsProp);
            Console.WriteLine(v2.Navn);
            Console.ReadKey();
        }
    }


    class Vare {
        private string _navn;
        private double _pris;
        public double PrismedMoms()
        {
            double p = _pris * 1.25;
            return Math.Round(p, 2);
                                  }

        public Vare()
        { }
        public Vare(string navn, double pris)
        {
            this.Navn = navn;
            this.Pris = pris;

          

        }

        public string Navn
        {
            get {
                Console.WriteLine("Navn aflæses: " + _navn);
                return _navn; }
            set {
                Console.WriteLine("Navn sættes: " + value);
                _navn = value; }
        }

        public double Pris
        {
            get {
                Console.WriteLine("Pris aflæses: " + _pris);
                return _pris; }
            set {
                Console.WriteLine("Pris sættes: " + value);
                _pris = value; }
        }

        public double PrisMedMomsProp
        {
            get
            {
                Console.WriteLine("Pris m moms aflæses: " + _pris * 1.25);
                return _pris*1.25;
            }
            
        }



    }
}
