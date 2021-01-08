let E = parseInt(gets());
let xValues = gets().split(' ').map(Number)

let lesserValue = xValues[0]
let lesserPos = 0

xValues.forEach((value, index) => {
  if (value < lesserValue) {
    lesserValue = value;
    lesserPos = index;
  }
});

console.log("Menor valor: " + lesserValue);
console.log("Posicao: " + lesserPos);
