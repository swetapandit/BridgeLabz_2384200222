function rollDie() {
    return Math.floor(Math.random() * 6) + 1;
}

function rollUntilLimit() {
    let rolls = new Map();
    let maxRolls = 10;
    
    for (let i = 1; i <= 6; i++) {
        rolls.set(i, 0);
    }
    
    let reached = null;
    while (!reached) {
        let roll = rollDie();
        rolls.set(roll, rolls.get(roll) + 1);
        
        if (rolls.get(roll) === maxRolls) {
            reached = roll;
        }
    }
    
    console.log("Roll counts:", rolls);
    
    let minNumber = 1;
    let minCount = rolls.get(1);
    
    for (let [num, count] of rolls) {
        if (count < minCount) {
            minNumber = num;
            minCount = count;
        }
    }
    
    console.log("Number that reached 10 times first:", reached);
    console.log("Number with the minimum rolls:", minNumber);
}

rollUntilLimit();
