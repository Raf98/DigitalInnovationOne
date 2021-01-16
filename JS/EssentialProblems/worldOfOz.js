let jewel = gets();
let jewels = [];

jewels.push(jewel);
let count = 0;

while (jewel != "") {
  if (!jewels.includes(jewel))
    jewels.push(jewel);

  jewel = gets();
  ++count;
}

console.log(jewels.length);

