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
                
            int asddddddd=0;
            //elemszam: 5
            int[] tomb = new int[] { 5, 4, 9, 3, 7 };
                                   //0  1  2  3  4

            

            //Kiíratás rendezés előtt
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0} ", tomb[i]);
            }

            Console.WriteLine();

            //Buborék rendezés
            for (int i = tomb.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (tomb[j] > tomb[j + 1])
                    {
                        int temp = tomb[j + 1];
                        tomb[j + 1] = tomb[j];
                        tomb[j] = temp;
                    }
                }
            }

            /*i=4
              j=0-->SWAP
              {4,5,9,3,7]
              j=1
              j=2-->SWAP
              {4,5,3,9,7}
              j=3-->SWAP
              {4,5,3,7,9}
              -------------
              i=3
              j=0
              j=1-->SWAP
              {4,3,5,7,9}
              j=2
              ------------
              i=2
              j=0-->SWAP
              {3,4,5,7,9}


            */

            //Kiíratás rendezés után
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0} ", tomb[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
