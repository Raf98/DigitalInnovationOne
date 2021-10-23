// a função gets é implementada dentro do sistema para ler as entradas(inputs) dos dados
// Abaixo segue um exemplo de código que você pode ou não utilizar

let totalDays = parseInt(gets())
let totalYears = Math.floor(totalDays/365);
let totalMonths = Math.floor(totalDays%365/30);
let daysLeft = totalDays%365%30;

console.log(totalYears + " ano(s)" + "\n" +
            totalMonths + " mes(es)" + "\n" +
            daysLeft + " dia(s)");
