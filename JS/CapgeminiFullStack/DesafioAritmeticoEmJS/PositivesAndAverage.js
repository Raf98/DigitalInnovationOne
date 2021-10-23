const positives = [];

let average = 0;

for (let i = 0; i < 6; i++) {
  const num = Number(gets());//Number(lines.shift());
	
  if (num >= 0) {
    positives.push(num);
    average += num;
  }
}

average /= positives.length;

console.log(positives.length + " valores positivos");
console.log(roundFloat(average));



function roundFloat(number){
  if((number.toFixed(1) - number) >= 0.049){
    //console.log(number.toFixed(1) - number)
    return Math.floor(number*10)/10;
  }
  return number.toFixed(1);
}
