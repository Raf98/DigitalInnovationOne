// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados

let R = parseInt(gets());

let V = parseInt(gets());



while (V <= R) {

  V = parseInt(gets());

}



let newR = R;

let numOfSummedValues = 1;



for (let i = 1; newR <= V; ++i) {

  newR += (R + i);

  ++numOfSummedValues;

}



console.log(numOfSummedValues)
