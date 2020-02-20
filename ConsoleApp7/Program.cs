using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] tomb = new int[] { 5, 4, 9, 3, 7 };
            int n = tomb.Length;

            //Kiíratás rendezés előtt
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", tomb[i]);
            }

            Console.WriteLine();

            //Buborék rendezés
            for (int i = n - 1; i > 0; i--)
                for (int j = 0; j < i; j++)
                    if (tomb[j] > tomb[j + 1])
                    {
                        int tmp = tomb[j + 1];
                        tomb[j + 1] = tomb[j];
                        tomb[j] = tmp;
                    }

            //Kiíratás rendezés után
            for (int i = 0; i < n; i++)
                Console.Write("{0} ", tomb[i]);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
