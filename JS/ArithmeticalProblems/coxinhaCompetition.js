let line = gets();
let H = parseFloat(line.split(' ')[0]);
let P = parseFloat(line.split(' ')[1]);

const ratio = H/P;

console.log(`${ratio.toFixed(2)}`);
