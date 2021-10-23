import java.util.Scanner
import kotlin.math.sqrt

fun main(/*args: Array<String>*/) {
  val scan = Scanner(System.`in`)
  val n = scan.nextLong()
  var x : Long
  var countDivs = 2  
    
    for (i in 0..n-1) {
      x = scan.nextLong()
      
      for(j in 2..sqrt(x.toDouble()).toLong()){
        if(x%j == 0L) ++countDivs
      }
      
      if(countDivs > 2){
        println("Not Prime")
      } else {
        println("Prime")
      }
      
      countDivs = 2;
    }
    
}
