function celsiusToFahrenheit(degC) {
    if (degC >= 0 && degC <= 100) {
      return (degC * 9 / 5) + 32;
    } else {
      console.log("Please enter a temperature between 0°C and 100°C.");
      return null;
    }
  }
  
  function fahrenheitToCelsius(degF) {
    if (degF >= 32 && degF <= 212) {
      return (degF - 32) * 5 / 9;
    } else {
      console.log("Please enter a temperature between 32°F and 212°F.");
      return null;
    }
  }
  
  let input = parseInt(process.argv[2]);
  let conversionType = process.argv[3]; // Either 'CtoF' or 'FtoC'
  
  switch (conversionType) {
    case 'CtoF': {
      let result = celsiusToFahrenheit(input);
      if (result !== null) {
        console.log(`${input} °C = ${result} °F`);
      }
      break;
    }
  
    case 'FtoC': {
      let result = fahrenheitToCelsius(input);
      if (result !== null) {
        console.log(`${input} °F = ${result} °C`);
      }
      break;
    }
  
    default:
      console.log("Invalid conversion type. Please use 'CtoF' or 'FtoC'.");
      break;
  }
  