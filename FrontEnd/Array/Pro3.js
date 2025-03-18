function primeFactorization(n) {
    let factors = [];
    
    // Divide by 2 until n is odd
    while (n % 2 === 0) {
        factors.push(2);
        n = n / 2;
    }
    
    // Check for odd factors from 3 onwards
    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = n / i;
        }
    }
    
    // If n is still a prime number greater than 2
    if (n > 2) {
        factors.push(n);
    }
    
    console.log("Prime Factors:", factors);
    return factors;
}

// Example Usage
let number = 100;
console.log(`Prime factors of ${number}:`, primeFactorization(number));
