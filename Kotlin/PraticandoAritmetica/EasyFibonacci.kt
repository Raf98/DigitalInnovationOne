fun main(args: Array<String>) {
    
    val n = readLine()!!.toInt()
    var t1: Int = 0
    var t2: Int = 1
    var sum : Int
    
    for (i in 1..(n-1)) {
        print("$t1 ")
        
        sum = t1 + t2 
        t1 = t2 
        t2 = sum
    }
    print("$t1")
    println()
    
}
