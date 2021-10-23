let t1 = 0
let t2 = 1
let sum = 0

let n = gets()
let str = ""

for (let i = 0; i < n-1; ++i) {
  str += t1 + " ";
        
  sum = t1 + t2; 
  t1 = t2; 
  t2 = sum;
}
    
str += t1
console.log(str)

