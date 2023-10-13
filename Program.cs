// (1) Dice roller
// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);


// (2) Overloaded versions of Random.Next() method
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
//     // No set upper or lower limit, returns values from 0 - 2,147,483,647
// Console.WriteLine($"Second roll: {roll2}");
//     // Specifies the max value as the upper limit, returns values from 0 - 100
// Console.WriteLine($"Third roll: {roll3}");
//     // Specifies both min and max values, returns values from 50 - 100


// ------------ CODE CHALLENGE -------------
// Implement a method of the Math class that returns the larger of two numbers
// Use the method that you found to assign a value to the variable named largerValue.
// You should be able to pass the two integer values, firstValue and secondValue, to the method that you found.
    // The method should return a value of type int that represents the larger of the two arguments that you passed it.
// You can assign the return value to largerValue on a new code line or on the existing code line that's used to declare largerValue.

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);
