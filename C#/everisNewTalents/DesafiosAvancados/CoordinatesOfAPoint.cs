using System; 

class CoordinatesOfAPoint {

    static void Main(string[] args) { 

      string[] input = Console.ReadLine().Split(" ");
      double x = Convert.ToDouble(input[0]);
      double y = Convert.ToDouble(input[1]);
      string quad = "Origem";
      
      if(x > 0 && y > 0){
        quad = "Q1";
      } else if (x < 0 && y > 0) {
        quad = "Q2";
      } else if (x < 0 && y < 0) {
        quad = "Q3";
      } else if (x > 0 && y < 0) {
        quad = "Q4";
      } else if (x != 0 && y == 0) {
        quad = "Eixo X";
      } else if (x == 0 && y != 0) {
        quad = "Eixo Y";
      }
      
      Console.WriteLine(quad);
    }

}
