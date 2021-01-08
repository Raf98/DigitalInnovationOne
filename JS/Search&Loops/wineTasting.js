let wineType = parseInt(gets());
let answers = gets().split(' ').map(Number);

let correctAnswers = 0;
for (let i = 0; i < 5; i++) {
  if (wineType == answers[i]) {
    ++correctAnswers;
  }
}

console.log(correctAnswers);


