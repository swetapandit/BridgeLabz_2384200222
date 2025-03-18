// (a) Inch to Feet Conversion
let inches = 42;
let feet = inches / 12;
console.log("42 inches =", feet.toFixed(2), "feet");

// (b) Rectangular Plot Conversion (Feet to Meters)
let lengthFeet = 60;
let widthFeet = 40;
let feetToMeter = 0.3048; // 1 foot = 0.3048 meter
let lengthMeters = lengthFeet * feetToMeter;
let widthMeters = widthFeet * feetToMeter;
console.log("Rectangular Plot:", lengthMeters.toFixed(2), "m x", widthMeters.toFixed(2), "m");

// (c) Area of 25 such plots in Acres
let areaOnePlotMeters = lengthMeters * widthMeters;
let totalAreaMeters = areaOnePlotMeters * 25;
let meterToAcre = 0.000247105; // 1 square meter = 0.000247105 acre
let totalAreaAcres = totalAreaMeters * meterToAcre;
console.log("Total area of 25 plots:", totalAreaAcres.toFixed(4), "acres");
