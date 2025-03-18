function findSecondLargestAndSmallest() {
    let numbers = [];
    
    // Step a & b: Generate 10 random 3-digit numbers and store in an array
    for (let i = 0; i < 10; i++) {
        numbers.push(Math.floor(Math.random() * 900) + 100);
    }
    
    console.log("Generated Numbers:", numbers);
    
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;
    
    // Step c: Find 2nd largest and 2nd smallest without sorting
    for (let num of numbers) {
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }
    
    console.log("Second Largest:", secondLargest);
    console.log("Second Smallest:", secondSmallest);
}

findSecondLargestAndSmallest();
