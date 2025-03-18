// Function to check if a number is prime
function isPrime(num) {
    if (num <= 1) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
      if (num % i === 0) return false;
    }
    return true;
  }
  
  // Function to get the palindrome of a number
  function getPalindrome(num) {
    let revNum = 0;
    let originalNum = num;
  
    while (num > 0) {
      revNum = revNum * 10 + num % 10;
      num = Math.floor(num / 10);
    }
  
    return revNum;
  }
  
  // Function to check if two numbers are palindromes
  function arePalindromes(num1, num2) {
    return getPalindrome(num1) === num2 && getPalindrome(num2) === num1;
  }
  
  // Function to check if the number's palindrome is prime
  function checkPrimeAndPalindrome(num) {
    if (!isPrime(num)) {
      console.log(`${num} is not a prime number.`);
      return;
    }
  
    let palindrome = getPalindrome(num);
    console.log(`Palindrome of ${num} is ${palindrome}`);
  
    if (isPrime(palindrome)) {
      console.log(`The palindrome number ${palindrome} is also prime.`);
    } else {
      console.log(`The palindrome number ${palindrome} is not prime.`);
    }
  }
  
  // Example of usage:
  let num = parseInt(process.argv[2]);
  
  checkPrimeAndPalindrome(num);
  
  // Example usage of checking two numbers for palindrome
  let num1 = 121; // Example number 1
  let num2 = 121; // Example number 2
  if (arePalindromes(num1, num2)) {
    console.log(`${num1} and ${num2} are palindromes of each other.`);
  } else {
    console.log(`${num1} and ${num2} are not palindromes of each other.`);
  }
  