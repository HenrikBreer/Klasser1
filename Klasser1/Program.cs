using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Console.WriteLine(p1.fornavn);
            Console.WriteLine(p1.FuldtNavn());
            
            p1.efternavn = "Hansen";
            Console.WriteLine(p1.FuldtNavn());

            Person p2 = new Person("Ole", "Breer", 1968);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());
            Console.ReadKey();
        }
    }

    class Person
    {
        public string fornavn;
        public string efternavn;
        public int fødselsår;
        public string FuldtNavn() 
        {
            return fornavn + " " + efternavn;
        }

        public int Alder()
        {
            return DateTime.Now.Date.Year - fødselsår;
        }

        public Person()
        {   fornavn = "Henrik";
            efternavn = "Breer";
        }

        public Person(string fornavn, string efternavn, int fødselsår)
        {
            this.fornavn = fornavn;
            this.efternavn = efternavn;
            this.fødselsår = fødselsår;
        }


    }
}
