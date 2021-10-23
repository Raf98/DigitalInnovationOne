using System; 

class EuclideanDivisionTheorem {

    static void Main(string[] args) { 

            string[] valores = Console.ReadLine().Split();
            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int q, r = 0;
            
            q = a/b;
            r = a % b;
            
            //Console.WriteLine(r);
            
            if(r < 0){
              q = (int)Math.Ceiling((double)a/(double)b);
              r -= b;
            }
            
            

            Console.WriteLine("{0} {1}", q, r);

    }

}
