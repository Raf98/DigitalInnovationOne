fun main() {
    
    var input : List<Int>
    var min : Int 
    var output : List<Int> = mutableListOf<Int>()
    var limitExceeded : Boolean = false
    
    while (true) {
        
        try {
          input = readLine()!!.trim().split(" ").map { it.toInt() }
        } catch(e: Exception){
          println("Sorry! Output limit exceeded!")
          limitExceeded = true;
          break;
        }
        var (h1, m1, h2, m2 ) = input
 
        if (h1 == 0 && h2 == 0 && m1 == 0 && m2 == 0) { break }
        else {
            if(h2 < h1 || (h2 == h1 && m2 <= m1)) h2 += 24
            if(m2 < m1) {
            	if(h1 != h2) --h2
            	m2 += m1 + (60-m1)
            } 
            min = (h2*60 + m2) - (h1*60 + m1)
            output += min
            
            //println(min)
        }
    }
 
    if(!limitExceeded){   
    	for(item in output){
    		println(item)
    	}   
    }
    println()
}
