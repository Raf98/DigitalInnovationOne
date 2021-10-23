let n = []

for (let i = 0; i < 10; i++) {
  n.push(gets())
  console.log(`X[${i}] = ${n[i] <= 0 ? 1 : n[i]}`);
}
