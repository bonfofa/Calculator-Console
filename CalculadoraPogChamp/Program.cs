using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPogChamp
{
    internal class Program {  /*
         porno porno

        porno
           porno porno porno     porno porno
           porno porno porno     porno porno
     porno porno     porno porno porno po porno     pornorno porno
           porno      porno porno porno
        porno porno

        */

        static void FunnyUm()
        {
            string F1 = Console.ReadLine();
            if (!F1.All(Char.IsDigit))
            {
                Console.WriteLine("Porfavor use um numero \n Primeiro funny :");
                Console.ReadLine();
                Console.Clear();
                FunnyUm();
                return;
            }
            else
            {
                float a = float.Parse(F1);
                aPub = a;
            }
        }

        static void FunnyDois()
        {
            string F2 = Console.ReadLine();
            if (!F2.All(Char.IsDigit))
            {
                Console.WriteLine("Porfavor use um numero \n Segundo funny :");
                Console.ReadLine();
                Console.Clear();
                FunnyDois();
                return;
            }
            else
            {
                float b = float.Parse(F2);
                bPub = b;
            }
        }

        static float aPub;
        static float bPub;
        static string oPub;

        static string[] pargs;
        static void Main(string[] args)
        {
            #region Nerd
            pargs = args;
            #endregion
            Console.Clear();
            Console.WriteLine("Primeiro funny :");
            FunnyUm();

            Console.WriteLine("Operador (+ , - , / , *) :");
            string operador = Console.ReadLine();
            oPub = operador;

            Console.WriteLine("Segundo funny :");
            FunnyDois();

            Matematica(aPub, bPub, operador);
        }

        static void Matematica(float a, float b, string o)
        {
            float result;
            switch (o)
            {
                case "+":
                    result = a + b;
                    Console.WriteLine("\n : " + result);
                    Console.ReadLine();
                    Main(pargs);
                    return;

                case "-":
                    result = a - b;
                    Console.WriteLine("\n : " + result);
                    Console.ReadLine();
                    Main(pargs);
                    return;

                case "/":
                    result = a / b;
                    if (b != 0)
                    {
                        Console.WriteLine("\n : " + result);
                    }
                    else
                    {
                        Console.WriteLine("Quaisquer numero dividido por zero é infinito");
                    }
                    Console.ReadLine();
                    Main(pargs);
                    return;

                case "*":
                    result = a * b;
                    Console.WriteLine("\n : " + result);
                    Console.ReadLine();
                    Main(pargs);
                    return;
                default:
                    Console.WriteLine("Esse operador não existe, porfavor selecione um poggers");
                    Console.ReadLine();
                    Main(pargs);
                    return;
            }
        }
    }
}