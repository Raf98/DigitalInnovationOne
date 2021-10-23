let line = gets();
let time = parseInt(line.split(' ')[0]);
let speed = parseInt(line.split(' ')[1]);
const km_L = 12; 

const distance = time*speed;
const totalLiters = distance/km_L;

console.log(`${totalLiters.toFixed(3)}`);
