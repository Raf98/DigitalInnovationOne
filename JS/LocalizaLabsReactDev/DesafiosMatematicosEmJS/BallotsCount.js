let N = parseInt(gets());
let ballots = [100, 50, 20, 10, 5, 2 ,1]
let quantity = 0
let Nleft;

console.log(N)

for(let i = 0; i < ballots.length; ++i){
  Nleft = N%ballots[i]
  quantity = Math.floor(N/ballots[i]); 
  N -= quantity*ballots[i]
  console.log(quantity + " nota(s) de R$ " + ballots[i].toFixed(2).replace('.', ','));
}


