import java.util.Scanner;

fun main(args: Array<String>) {
    
    val C = readLine()!!.toInt()
    var sum = 0.0
    val T = readLine()!!.toUpperCase()
    val M = Array(12) { DoubleArray(12)}
    
    val reader = Scanner(System.`in`);
    
    for (i in 0..(M.size-1)) {
        for (j in 0..(M.size-1)) {
            M[i][j] = reader.nextDouble()
        }
    }
    
    for (k in 0.until(M.size)) {
        sum += M[k][C]
    }
    
    if (T.equals("M", true)) sum /= M.size
    println(sum.format(1))
}

private fun Double.format(digits: Int) = "%.${digits}f"
    .format(this)
