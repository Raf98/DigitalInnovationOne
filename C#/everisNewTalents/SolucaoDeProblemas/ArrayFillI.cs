using System; 

class ArrayFillI{

    static void Main(string[] args) { 

            int valorLido = int.Parse(Console.ReadLine());
            int[] n = new int[10];
            
            n[0] = valorLido;
            for (int i = 1; i < 10; ++i)
            {
              n[i] = n[i-1] * 2; 
            }

            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine($"N[{i}] = {n[i]}");
            }

    }

}
