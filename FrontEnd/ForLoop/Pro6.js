let num = parseInt(process.argv[2]);

function primeFactors(n) {
  let factors = [];

  // Check for number of 2s that divide n
  while (n % 2 === 0) {
    factors.push(2);
    n = n / 2;
  }

  // n must be odd at this point, so we can skip even numbers
  for (let i = 3; i * i <= n; i += 2) {
    while (n % i === 0) {
      factors.push(i);
      n = n / i;
    }
  }

  // If n is still greater than 2, then it's prime
  if (n > 2) {
    factors.push(n);
  }

  return factors;
}

console.log(`Prime factors of ${num}:`, primeFactors(num));
