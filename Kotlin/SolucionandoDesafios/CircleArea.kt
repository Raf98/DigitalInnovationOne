import java.math.BigDecimal
import java.math.RoundingMode
import kotlin.math.pow
import java.util.Scanner;

fun main(args: Array<String>) {
    
    val leitor = Scanner(System.`in`);

    val raio = leitor.nextDouble()
    val pi = 3.14159
    val area = pi*raio.pow(2)
    
    val resultado = BigDecimal(area).setScale(0, RoundingMode.HALF_EVEN)
    println("A=${"%.4f".format(area)}")
    
}
