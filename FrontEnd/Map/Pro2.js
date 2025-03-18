function generateBirthMonths() {
    let birthMonths = new Map();
    let numIndividuals = 50;

    // Generate birth months for 50 individuals
    for (let i = 1; i <= numIndividuals; i++) {
        let month = Math.floor(Math.random() * 12) + 1; // Random month between 1 and 12

        if (!birthMonths.has(month)) {
            birthMonths.set(month, []);
        }
        birthMonths.get(month).push(`Individual ${i}`);
    }

    // Print individuals sharing the same birth month
    console.log("Individuals with birthdays in the same month:");
    birthMonths.forEach((individuals, month) => {
        if (individuals.length > 1) {
            console.log(`Month ${month}: ${individuals.join(", ")}`);
        }
    });
}

generateBirthMonths();
