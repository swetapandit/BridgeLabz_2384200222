function findSecondLargestAndSmallest() {
    let numbers = [];
    
    // Step a & b: Generate 10 random 3-digit numbers and store in an array
    for (let i = 0; i < 10; i++) {
        numbers.push(Math.floor(Math.random() * 900) + 100);
    }
    
    console.log("Generated Numbers:", numbers);
    
    // Step d: Sort the array and find 2nd largest & 2nd smallest
    numbers.sort((a, b) => a - b);
    console.log("Sorted Numbers:", numbers);
    console.log("Second Smallest:", numbers[1]);
    console.log("Second Largest:", numbers[numbers.length - 2]);
}

findSecondLargestAndSmallest();
