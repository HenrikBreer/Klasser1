using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] månedsløn = { 40000, 300,234,100, 200, 300, 400, 500, 600, 700, 800 };
            System.Array.Sort(månedsløn);
            foreach (var d in månedsløn)
            {
                Console.WriteLine($"Løn: {d:N2} ");
            }

            Console.ReadKey();


            string txt = "3;4;5;6;7;8;9";
            string[] tal = txt.Split(';');

            int tsum = 0;

            foreach (var t in tal)

            {
                Console.WriteLine(t);
                tsum = tsum + System.Convert.ToInt32(t);

            }
            Console.WriteLine("------------");
            Console.WriteLine(tsum);
            Console.ReadKey();


        }
    }
}
