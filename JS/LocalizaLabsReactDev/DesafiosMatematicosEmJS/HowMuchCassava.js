let guestsGrams = [300, 1500, 600, 1000, 150];
let totalPortions = 225

for(let i = 0; i < guestsGrams.length; ++i){
  totalPortions += guestsGrams[i]*parseInt(gets()); 
}

console.log(totalPortions)

