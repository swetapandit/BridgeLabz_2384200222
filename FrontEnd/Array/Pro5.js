function findRepeatedDigitNumbers() {
    let repeatedNumbers = [];
    
    for (let i = 0; i <= 100; i++) {
        let strNum = i.toString();
        if (strNum.length === 2 && strNum[0] === strNum[1]) {
            repeatedNumbers.push(i);
        }
    }
    
    console.log("Numbers with repeated digits:", repeatedNumbers);
    return repeatedNumbers;
}

// Example Usage
findRepeatedDigitNumbers();
