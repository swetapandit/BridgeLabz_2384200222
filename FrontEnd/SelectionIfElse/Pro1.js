let nums = [
    Math.floor(Math.random() * 900) + 100,
    Math.floor(Math.random() * 900) + 100,
    Math.floor(Math.random() * 900) + 100,
    Math.floor(Math.random() * 900) + 100,
    Math.floor(Math.random() * 900) + 100
  ];
  
  let min = Math.min(...nums);
  let max = Math.max(...nums);
  
  console.log("Min:", min);
  console.log("Max:", max);
  