using System; 

class Tweeting {

    static void Main(string[] args) { 

        string v = Console.ReadLine();
        if( v.Length  <=  140) 
          Console.WriteLine("TWEET");
        else
          Console.WriteLine("MUTE");

    }

}
