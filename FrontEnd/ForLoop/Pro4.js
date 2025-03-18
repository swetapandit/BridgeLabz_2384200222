let start = parseInt(process.argv[2]);
let end = parseInt(process.argv[3]);

function isPrime(num) {
  if (num <= 1) {
    return false;
  }
  for (let i = 2; i <= Math.sqrt(num); i++) {
    if (num % i === 0) {
      return false;
    }
  }
  return true;
}

console.log(`Prime numbers between ${start} and ${end}:`);
for (let i = start; i <= end; i++) {
  if (isPrime(i)) {
    console.log(i);
  }
}
