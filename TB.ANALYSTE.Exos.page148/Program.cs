using System;

namespace TB.ANALYSTE.Exos.page148
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice_01 - Suite Fibonacci

            //const int LIMIT = 25;
            //int fib1=0, fib2=1, result;
            //Console.WriteLine($"F0 : { fib1 }");
            //Console.WriteLine($"F1 : { fib2 }");

            //#region FOR
            //for (int cpt = 2; cpt < LIMIT; cpt++)
            //{
            //    result = fib1 + fib2;
            //    fib1 = fib2;
            //    fib2 = result;
            //    Console.WriteLine($"F{cpt} : { fib2 }");
            //}
            //#endregion

            //#region WHILE
            ////int cpt = 2;
            ////while (cpt <= LIMIT)
            ////{
            ////    result = fib1 + fib2;
            ////    fib1 = fib2;
            ////    fib2 = result;
            ////    Console.WriteLine($"F{cpt} : { fib2 }");
            ////    cpt++;
            ////}
            //#endregion

            //#region DO...WHILE
            ////int cpt = 2;
            ////do
            ////{
            ////    result = fib1 + fib2;
            ////    fib1 = fib2;
            ////    fib2 = result;
            ////    Console.WriteLine($"F{cpt} : { fib2 }");
            ////    cpt++;
            ////} while (cpt < LIMIT);
            //#endregion

            #endregion

            #region Exercice_02 - Factoriel

            //int number, result;
            //Console.WriteLine("Veuillez entrer un nombre :");
            //number = int.Parse(Console.ReadLine());
            //result = number;

            //for (int i = 2; i < number; i++)
            //{
            //    result = result * i; 
            //}

            int number, i;
            Console.WriteLine("Veuillez entrer un nombre :");
            number = int.Parse(Console.ReadLine());
            i = number;
            while (i > 2)
            {
                number *= --i;
            }
            Console.WriteLine(number);

            #endregion


        }
    }
}
