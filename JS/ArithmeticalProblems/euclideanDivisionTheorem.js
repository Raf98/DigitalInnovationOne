let line = gets().split(' ')
let a = parseInt(line[0]);
let b = parseInt(line[1]);

let q = parseInt(a / b);

let r = parseInt(a % b);

if (r < 0) {
  r += Math.abs(b);
  //a = b*q + r;
  q = (a - r) / b;
}


console.log(q + " " + r);
