using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatiskeEgenskaber
{
    class Program
    {
        static void Main(string[] args)
        {


            Person person = new Person();
            person.Fornavn = "Henrik";
            person.Efternavn = "Br";
            Console.WriteLine(person.Fuldtnavn);
            Console.ReadKey();


        }
    }


    public class Person
    {
        public String Fornavn { get; set; }

        private String _efternavn;

        public String Efternavn
        {
            get { return _efternavn; }
            set {if (value.Length < 3) value = "";
                _efternavn = value; }
        }

        private string _fuldtnavn;

        public string Fuldtnavn
        {
            get {
                _fuldtnavn = Fornavn + " " + Efternavn;
                return   _fuldtnavn; }
                //return Fornavn + " " + Efternavn;
            

        }



    }



}
