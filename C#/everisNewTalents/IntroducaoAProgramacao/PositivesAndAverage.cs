using System; 

class PostivesAndAverage{

        public static void Main()
        {
            double a, b = 0, avg;
            int i, positives = 0;
            
            for (i = 0; i < 6; ++i)
            {
                a = double.Parse(Console.ReadLine());
                
                if (a > 0)
                {
                  b += a;
                  ++positives;
                }
            }
            
            avg = b / positives;
            Console.WriteLine("{0} valores positivos", positives);
            //Console.WriteLine("{0}", avg.ToString("0.0"));
            //Console.WriteLine(String.Format("{0:0.0}", Math.Truncate(avg)));
            Console.WriteLine(Math.Round(avg,1));

            Console.ReadLine();
        }

}
