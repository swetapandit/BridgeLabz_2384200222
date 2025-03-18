let low = 1;
let high = 100;

console.log("Think of a number between 1 and 100, and I will guess it!");

function guessMagicNumber() {
  let mid;
  let response = "";

  const askQuestion = () => {
    mid = Math.floor((low + high) / 2);
    console.log(`Is your number less than, equal to, or greater than ${mid}?`);
    // Here, you can manually input 'less', 'equal', or 'greater' in the console when running.
  };

  const handleResponse = (answer) => {
    if (answer === "equal") {
      console.log(`I guessed it! Your magic number is ${mid}.`);
    } else if (answer === "less") {
      high = mid - 1;
      askQuestion();
    } else if (answer === "greater") {
      low = mid + 1;
      askQuestion();
    } else {
      console.log("Invalid response, please enter 'less', 'equal', or 'greater'.");
    }
  };

  askQuestion();

  // Assuming you give inputs manually, use this for responses:
  // "less" or "greater" or "equal" based on your feedback.
}

guessMagicNumber();
