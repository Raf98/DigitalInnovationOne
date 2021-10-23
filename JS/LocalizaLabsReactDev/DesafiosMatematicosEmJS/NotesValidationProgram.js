const isValid = value => value <= 10 && value >= 0;

let getout = false;

let numA = null;
let numB = null;


while (!getout) {
  const num = Number(gets());

  if (!isValid(num)) {
    console.log("nota invalida");
    continue;
  }

  if (numA == null) {
    numA = num;
    continue;
  }

  numB = num;
  
  const average = (numA + numB)/2
  
  let validResponse = false;
  
  numA = null;
  numB = null;
  
  console.log("media = " + average.toFixed(2));

  let response = null;
  
  
  do {
    console.log("novo calculo (1-sim 2-nao)");

    response = gets();

    switch (response) {
      case "1":
        validResponse = true
        break;
      case "2":
        validResponse = true
        getout = true;
        break;
        
    }
  } while (!validResponse);
}

