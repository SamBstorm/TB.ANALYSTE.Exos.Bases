using System;

namespace TB.ANALYSTE.Exos.page138
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercice_01
            int nb1, nb2, resultDiv, resultMod;
            double resultDivDec;
            Console.WriteLine("Veuillez entrer un premier nombre :");
            nb1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Veuillez entrer un second nombre :");
            nb2 = int.Parse(Console.ReadLine());

            resultDiv = nb1 / nb2;
            resultMod = nb1 % nb2;
            resultDivDec = (double)nb1 / nb2;

            Console.WriteLine($"Division entière : {resultDiv} - Reste de la division : {resultMod} - Division décimale : {resultDivDec}");
            #endregion
            #region Exercice_02
            string bban;
            ulong tenFirst;
            ushort twoLast;

            Console.WriteLine("Veuillez introduire votre BBAN :");
            bban = Console.ReadLine();
            tenFirst = ulong.Parse(bban.Substring(0, 10));
            twoLast = ushort.Parse(bban.Substring(10));

            if ((tenFirst % 97 == twoLast) || (tenFirst % 97 == 0 && twoLast == 97) ) Console.WriteLine("OK");
            else Console.WriteLine("KO");

            #endregion
            
        }
    }
}
