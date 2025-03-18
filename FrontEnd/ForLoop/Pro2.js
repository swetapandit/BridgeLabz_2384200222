let n = parseInt(process.argv[2]);
let harmonicNumber = 0;

for (let i = 1; i <= n; i++) {
  harmonicNumber += 1 / i;
}

console.log(`The ${n}th harmonic number is: ${harmonicNumber}`);
