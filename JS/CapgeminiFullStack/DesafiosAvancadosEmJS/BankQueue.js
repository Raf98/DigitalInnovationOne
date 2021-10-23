// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
let N = parseInt(gets());
let M;
let P = new Array()

for(let i = 0; i < N; ++i){
  let M = parseInt(gets());
  P = new Array(M)
  
  P = gets().split(" ")/*.filter( pi => pi != " ")*/.map(pi => parseInt(pi));

  let ogP = []
  ogP = ogP.concat(P);
  P.sort((a, b) => b-a);

  console.log(countDiffs(ogP, P))
  
  P.splice(0, M);
  ogP.splice(0, M);
}

function countDiffs(arr1, arr2){
  let count = 0;
  
  for(let i = 0; i < arr1.length; ++i){
    if(arr1[i] == arr2[i])
      ++count;
  }
  
  return count;
}
