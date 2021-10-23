using System; 

class VisitingTheFair{

    static void Main(string[] args) { 

            int a, b, x;
            String[] input = Console.ReadLine().Split(" ");
            a = Convert.ToInt32(input[0]);
            b = Convert.ToInt32(input[1]);

            x = a + b; 

            Console.WriteLine("X = {0}", x);

    }

}
