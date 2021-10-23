fun main(args: Array<String>) {
    
    val N = readLine()!!.toInt()
    //readLine()
    for (i in 0..N-1) {
        val strs = readLine()!!.trim().split("").slice(1..3)
        val N1: Int = strs[0].toInt()
        val L1: String = strs[1]
        val N2: Int = strs[2].toInt()

        if(N1 == N2) println(N2 * N1)
        else if(L1 == L1.toUpperCase()) println(N2 - N1)
        else println(N1 + N2)
    }
}
