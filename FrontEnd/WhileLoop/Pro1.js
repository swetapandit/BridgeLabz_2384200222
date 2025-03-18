let n = parseInt(process.argv[2]);
let i = 0;
let powerOf2 = 1;

while (powerOf2 <= 256 && i <= n) {
  console.log(`2^${i} = ${powerOf2}`);
  i++;
  powerOf2 = Math.pow(2, i);
}
