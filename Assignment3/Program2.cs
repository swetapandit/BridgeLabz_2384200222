// using System;

// class Program1
// {
//     // Non-static function that returns multiple (touple) values (percentage and grade)
//     public (double percentage, string grade) CalculateGrade(int physics, int chemistry, int maths)
//     {
//         double totalMarks = physics + chemistry + maths;
//         double percentage = (totalMarks / 300) * 100;  // Assuming each subject is out of 100

//         string grade;

//         if (percentage >= 80) grade = "A";
//         else if (percentage >= 70 && percentage <= 79) grade = "B";
//         else if (percentage >= 60 && percentage <= 69) grade = "C";
//         else if (percentage >= 50 && percentage <= 59) grade = "D";
//         else if (percentage >= 40 && percentage <= 49) grade = "E";
// 	else grade = "F";

//         // Returning multiple elements using a tuple
//         return (percentage, grade);
//     }

//     static void Main()
//     {
//         // Input marks for Physics, Chemistry, and Maths
//         int physics = Convert.ToInt32(Console.ReadLine());
//         int chemistry = Convert.ToInt32(Console.ReadLine());
//         int maths = Convert.ToInt32(Console.ReadLine());

//         // Create an instance of Program1 to call the non-static method
//         Program1 program = new Program1();

//         // Get multiple values (percentage and grade) from the function
//         var (percentage, grade) = program.CalculateGrade(physics, chemistry, maths);

//         // Display the results
//         Console.WriteLine($"Average Mark: {percentage:F2}%");
//         Console.WriteLine($"Grade: {grade}");
//     }
// }
