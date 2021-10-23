using System;
using System.Collections;


class PedroBentoAndTheWorldOfOz {
  
  static void Main(string[] args) {
    
    string line;
    var distinctJewels = new ArrayList();
    
    while ((line = Console.ReadLine()) != null)
    {
      if(!distinctJewels.Contains(line))
      {
        distinctJewels.Add(line);
      } 
    }
    
    Console.WriteLine(distinctJewels.Count);
    // Utilize Console.ReadLine para leitura do input de cada linha
    // Utilize Console.WriteLine para fazer o output de cada linha
  }

}
