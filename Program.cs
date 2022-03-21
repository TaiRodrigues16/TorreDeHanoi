using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreDeHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
             Pilha A = new Pilha();

            Pilha B = new Pilha();

            Pilha C = new Pilha();

            while (true)

            {

                Console.Write("\nEnter the number of discs (-1 to exit): ");

                string s = Console.ReadLine();

                int movecount = 0;

                int maxdisc = Convert.ToInt32(s);

                if (maxdisc == -1)

                {

                    Console.WriteLine("Good Bye!");

                    return;

                }

                if (maxdisc <= 1 || maxdisc >= 10)

                {

                    Console.WriteLine("Enter between 2 - 9");

                    continue;

                }

                for (int i = maxdisc; i >= 1; i--)

                    TorreDH.A.Push(i);

                int countA = A.Count;

                int countB = B.Count;

                int countC = C.Count;

                TorreDH.ImprimirPilhas();

                TorreDH.MoverTH(maxdisc, A, B, C);

                Console.WriteLine("Total Moves = " + movecount);

                while (TorreDH.C.Count > 0)

                    TorreDH.C.Pop();

            }

        }
    }
}
