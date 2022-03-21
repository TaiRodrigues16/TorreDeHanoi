using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorreDeHanoi
{
    class TorreDH
    {
        static int movecount = 0;

        static public void Mover2Discos(Pilha source, Pilha temp, Pilha dest)
        {

            temp.Push(source.Pop());

            movecount++;

            ImprimirPilhas();

            dest.Push(source.Pop());

            movecount++;

            ImprimirPilhas();

            dest.Push(temp.Pop());

            movecount++;

            ImprimirPilhas();

        }


        static public bool MoverTH(int nDiscs, Pilha source, Pilha temp, Pilha dest)
        {

            if (nDiscs <= 4)

            {

                if ((nDiscs % 2) == 0)

                {

                    Mover2Discos(source, temp, dest);

                    nDiscs = nDiscs - 1;

                    if (nDiscs == 1)

                        return true;



                    temp.Push(source.Pop());

                    movecount++;

                    ImprimirPilhas();

                    //new source is dest, new temp is source, new dest is temp;

                    Mover2Discos(dest, source, temp);

                    dest.Push(source.Pop());

                    movecount++;

                    ImprimirPilhas();

                    //new source is temp, new temp is source, new dest is dest;

                    MoverTH(nDiscs, temp, source, dest);

                }

                else
                {

                    if (nDiscs == 1)

                        return false;

                    Mover2Discos(source, dest, temp);

                    nDiscs = nDiscs - 1;

                    dest.Push(source.Pop());

                    movecount++;

                    ImprimirPilhas();

                    Mover2Discos(temp, source, dest);

                }

                return true;

            }

            else if (nDiscs >= 5)

            {

                MoverTH(nDiscs - 2, source, temp, dest);

                temp.Push(source.Pop());

                movecount++;

                ImprimirPilhas();

                MoverTH(nDiscs - 2, dest, source, temp);

                dest.Push(source.Pop());

                movecount++;

                ImprimirPilhas();

                MoverTH(nDiscs - 1, temp, source, dest);

            }


            return true;

        }

        static public Pilha A = new Pilha();

        static public Pilha B = new Pilha();

        static public Pilha C = new Pilha();


        static public void ImprimirPilhas()

        {

            if (countA != A.Count ||

                countB != B.Count ||

                countC != C.Count)

            {

                int diffA = A.Count - countA;

                int diffB = B.Count - countB;

                int diffC = C.Count - countC;

                if (diffA == 1)

                {

                    if (diffB == -1)

                        Console.Write("Move Disc " + A.Peek() + " From B To A");

                    else

                        Console.Write("Move Disc " + A.Peek() + " From C To A");

                }

                else if (diffB == 1)

                {

                    if (diffA == -1)

                        Console.Write("Move Disc " + B.Peek() + " From A To B");

                    else

                        Console.Write("Move Disc " + B.Peek() + " From C To B");

                }

                else //if (diffC == 1)

                {

                    if (diffA == -1)

                        Console.Write("Move Disc " + C.Peek() + " From A To C");

                    else

                        Console.Write("Move Disc " + C.Peek() + " From B To C");

                }

                countA = A.Count;

                countB = B.Count;

                countC = C.Count;

                Console.WriteLine();

            }



            //ImprimirPilha(A);

            Console.Write(" , ");

            //ImprimirPilha(B);

            Console.Write(" , ");

            //ImprimirPilha(C);

            Console.Write(" , ");

        }

        static int countA = 0;

        static int countB = 0;

        static int countC = 0;


        /*
        static public void ImprimirPilha(Pilha s)

        {

            Stack<int>.Enumerator et = s.GetEnumerator();

            Console.Write("[");

            string str = "";

            while (true)

            {

                if (et.MoveNext() == false)

                    break;

                str += et.Current.ToString();

            }

            for (int i = str.Length - 1; i >= 0; i--)

                Console.Write(str[i]);

            Console.Write("]");

        }
        */
    }
}
