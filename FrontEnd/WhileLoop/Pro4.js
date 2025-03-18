let money = 100;
let bet = 1;
let wins = 0;
let bets = 0;

while (money > 0 && money < 200) {
  bets++; // Increment the number of bets made
  
  // Simulate a 50% chance to win or lose
  let result = Math.random() < 0.5 ? 'win' : 'lose';
  
  if (result === 'win') {
    money += bet;
    wins++;
  } else {
    money -= bet;
  }

  console.log(`Money: Rs ${money}, Wins: ${wins}, Bets Made: ${bets}`);
}

if (money === 0) {
  console.log("Gambler went broke!");
} else {
  console.log("Gambler reached Rs 200!");
}

console.log(`Total Wins: ${wins}`);
console.log(`Total Bets Made: ${bets}`);
