using System;

namespace CoinCalculator
{
    class Program
    { 
        public static void CoinCount(double dollarAmont) 
        {
            int Centamout = Convert.ToInt32(dollarAmont * 100);
            int numP;
            int numN;
            int numD;
            int numQ;
            int numCents = (int)dollarAmont;
            numQ = Centamout / 25;
            int remainderQ = Centamout % 25;

            numD = remainderQ /10;
            int remainderD = remainderQ % 10;

            numN = remainderD /05;
            int remainderN = remainderD % 05;

            numP = remainderN;
            Console.WriteLine($"\n Quarter:{numQ} \n Dimes:{numD} \n Nickels:{numN} \n Pennies{numP}");
          
           
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine(1.37);
            CoinCount(1.37);
        }
    }
}
