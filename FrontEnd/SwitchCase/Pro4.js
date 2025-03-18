let unit = parseInt(process.argv[2]);
let value = parseFloat(process.argv[3]);

switch(unit) {
  case 1: // Feet to Inch
    console.log(`${value} feet = ${value * 12} inches`);
    break;
  case 2: // Inch to Feet
    console.log(`${value} inches = ${value / 12} feet`);
    break;
  case 3: // Feet to Meter
    console.log(`${value} feet = ${value * 0.3048} meters`);
    break;
  case 4: // Meter to Feet
    console.log(`${value} meters = ${value / 0.3048} feet`);
    break;
  default:
    console.log("Invalid input");
}
