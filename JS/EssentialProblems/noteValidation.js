let countValidNotes = 0;
let note;
let notes = 0;


while (countValidNotes < 2) {
  note = parseFloat(gets());

  if (note < 0 || note > 10) {
    console.log("nota invalida");
  }
  else {
    notes += note;
    ++countValidNotes;
  }
}


console.log("media = " + (notes / 2).toFixed(2));

