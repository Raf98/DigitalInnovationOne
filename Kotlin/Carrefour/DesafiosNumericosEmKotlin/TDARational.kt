import java.util.Scanner
import kotlin.math.absoluteValue

fun main() {
    val scan = Scanner(System.`in`)
    val n: Int
    var n1: Int
    var d1: Int
    var n2: Int
    var d2: Int
    var nf = 0
    var df = 0
    var ns: Int
    var ds: Int
    var aux: String
    n = scan.nextInt()
    for (i in 1..n) {
        n1 = scan.nextInt()
        scan.next()
        d1 = scan.nextInt()
        aux = scan.next()
        n2 = scan.nextInt()
        scan.next()
        d2 = scan.nextInt()
        when (aux) {
            "+" -> {
            nf = (n1*d2 + n2*d1)
            df = (d1*d2);   
            }
            "-" -> {
            nf = (n1*d2 - n2*d1)
            df = (d1*d2)
            }
            "*" -> {
            nf = (n1*n2)
            df = (d1*d2)
            }
            "/" -> {
            nf = (n1*d2)
            df = (n2*d1)
            }
        }
        ns = nf
        ds = df
        var factor = GCD(ns.absoluteValue, ds.absoluteValue) /*if (ns.absoluteValue < ds.absoluteValue && ns != 0) ns.absoluteValue else ds.absoluteValue
        
        while (factor >= 1) {
            if (nf.absoluteValue%factor == 0 && df.absoluteValue%factor == 0){
              ns /= factor
              ds /= factor
              break;
            }
            --factor;
        }*/
        
        ns /= factor
        ds /= factor
        println("$nf/$df = $ns/$ds")
    }
    
    println()
}

fun GCD(A: Int, B: Int): Int
{
  var lesserNum: Int
  var greaterNum: Int

  if (B < A)
  {
    lesserNum = B
    greaterNum = A
  }
  else
  {
    lesserNum = A
    greaterNum = B
  }

  if (lesserNum == 0)
  {
    return greaterNum
  }

  return GCD(lesserNum, greaterNum % lesserNum)
}
