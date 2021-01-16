const salary = parseFloat(gets()).toFixed(2);

let tax = 0;

if (salary >= 2000.01) {
  tax = 0.08 * 1000;

  if (salary >= 3000.01) {
    if (salary <= 4500.00)
      tax += 0.18 * (salary - 3000);
    else
      tax += 0.18 * 1500 + 0.28 * (salary - 4500);
  }
  console.log(`R$ ${tax.toFixed(2)}`);
}
else {
  console.log("Isento");
}
