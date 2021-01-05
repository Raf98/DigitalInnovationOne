function isMultipleOf(multiplier, multiple){
  if(multiplier % multiple === 0) return true;
  return false;
}

let numberOfNumbers = parseInt(gets());
let numbers = gets().split(' ').map(Number);
let multiples = [2, 3, 4, 5]
let multiplesMap = new Map()

multiples.forEach((multiple) => {
  multiplesMap.set(multiple, {count: 0});
});


numbers.forEach((number) => {
  
  multiples.forEach((multiple) => {
    
    if(isMultipleOf(number, multiple)){
      multiplesMap.get(multiple).count++;    
    }
    
  });
});


multiples.forEach((multiple) => {
  console.log(multiplesMap.get(multiple).count + " Multiplo(s) de " + multiple);
});

  

