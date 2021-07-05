fun main(args: Array<String>) {

    val list = IntArray(10) { readLine()!!.toInt() }
    for ( x in 0..list.size-1 ) { if ( list[x] <= 0 ) list[x] = 1 }
    for ( i in 0..list.size-1 ) println("X[$i] = ${list[i]}")
    
}
