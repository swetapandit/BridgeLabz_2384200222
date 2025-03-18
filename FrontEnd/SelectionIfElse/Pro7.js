let num = parseInt(process.argv[2]);

if (num === 1) {
  console.log("Unit");
} else if (num === 10) {
  console.log("Ten");
} else if (num === 100) {
  console.log("Hundred");
} else if (num === 1000) {
  console.log("Thousand");
} else {
  console.log("Invalid input");
}
