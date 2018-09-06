using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser3Static
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = Beregninger.Lægsammen(1, 2);
            System.Console.WriteLine(i.ToString());
            i = Beregninger.TrækFra(2, 3);
            System.Console.WriteLine(i);
            
            

            Console.ReadKey();
        }




    }

    static class  Beregninger
    {
        public static int Lægsammen(int a, int b)
        {
            return a + b;
        }

        public static int TrækFra(int a, int b)
        {
            return a - b;

        }
    }


}
