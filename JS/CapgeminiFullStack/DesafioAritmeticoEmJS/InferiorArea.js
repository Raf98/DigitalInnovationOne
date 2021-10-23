// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
// Abaixo segue um exemplo de código que você pode ou não utilizar

const isSum = gets() === "S";


const xL = 12,
  yL = 12;

let sum = 0.0,
  av = 0.0;

let inArray = [];
let line;  
  
for (let y = 0; y < yL; y++) {
  line = gets()

  if(line.split(" ").length > 1){
    let numbers = line.split(" ");
    numbers = numbers.filter(num => num.trim() != "");
    //console.log(numbers)
    for (let x = 0; x < xL; x++) {
      //console.log(numbers[x])
      inArray.push(Number(numbers[x]));
    }
  } else {
    inArray.push(Number(line))
    for (let x = 1; x < xL; x++) {
      inArray.push(Number(gets()))
    }
  }
  
    if(y > 6){
      for (let x = 1; x < 11; x++) {
        if (x < y && x > 11 - y) {
          sum += inArray[x];
          ++av;
        }
      }
    }
  
  inArray.splice(0, inArray.length);
}  

console.log((sum / (isSum ? 1 : av)).toFixed(1));
