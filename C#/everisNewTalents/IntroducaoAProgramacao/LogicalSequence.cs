using System; 

class LogicalSequence{

    static void Main(string[] args) { 

            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; ++i)
            {
              Console.WriteLine(Math.Pow(i, 1) + " " + Math.Pow(i, 2) + " " + Math.Pow(i, 3));
              Console.WriteLine(Math.Pow(i, 1) + " " + (Math.Pow(i, 2) + 1) + " " + (Math.Pow(i, 3) + 1));
            }

    }

}
