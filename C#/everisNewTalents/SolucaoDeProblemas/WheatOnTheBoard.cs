using System; 
using System.Numerics;

class WheatOnTheBoard{

    static void Main(string[] args) { 

        int n = int.Parse(Console.ReadLine());
        ulong x;
        BigInteger totalGrams;
        
        for (int i = 0; i < n; ++i)
        {
          x = ulong.Parse(Console.ReadLine()); 
          totalGrams = new BigInteger((Math.Pow(2,x)/(12*1000)));
          Console.WriteLine($"{totalGrams} kg");
        }

    }

}
