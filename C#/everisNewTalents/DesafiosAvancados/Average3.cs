using System;

namespace Start
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d,avg;
            string[] values = Console.ReadLine().Split(' ');
            a = double.Parse(values[0])*2;
            b = double.Parse(values[1])*3;
            c = double.Parse(values[2])*4;
            d = double.Parse(values[3])*1;
            avg = (a + b + c + d)/10;
    
            Console.WriteLine("Media: " + avg.ToString("0.0"));
            
            if (avg >= 7)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if (avg < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (avg >= 5 && avg <= 6.9) 
            {
                Console.WriteLine("Aluno em exame.");
                double e = double.Parse(Console.ReadLine());
                Console.WriteLine("Nota do exame: " + e.ToString("0.0"));
                
                avg = (avg + e) / 2;
                if (avg >= 5)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else 
                {
                    Console.WriteLine("Aluno reprovado");
                }
                Console.WriteLine("Media final: " +avg.ToString("0.0"));
            }

            Console.ReadKey();
        }
    }
}
