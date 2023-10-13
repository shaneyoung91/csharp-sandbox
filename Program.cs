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


// -------------- CODE CHALLENGE --------------
// Implement a method of the Math class that returns the larger of two numbers
// Use the method that you found to assign a value to the variable named largerValue.
// You should be able to pass the two integer values, firstValue and secondValue, to the method that you found.
    // The method should return a value of type int that represents the larger of the two arguments that you passed it.
// You can assign the return value to largerValue on a new code line or on the existing code line that's used to declare largerValue.

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);
// --------------------------------------------


// ------- Using if, else if, else, statements -------
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
//     if ((roll1 == roll2) && (roll2 == roll3)) {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16) {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10) {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7) {
//     Console.WriteLine("You win a trip for two!");
// } else {
//     Console.WriteLine("You win a kitten!");
// }
// ----------------------------------------------


// ----------------CODE CHALLENGE----------------
// Improve renewal rate of subscriptions.
// You've been asked to add a feature to your company's software. The feature is intended to improve the renewal rate of subscriptions to the software. 
    // Your task is to display a renewal message when a user logs into the software system and is notified their subscription will soon end. 
    // You'll need to add a couple of decision statements to properly add branching logic to the application to satisfy the requirements.

// Rule 1: Your code should only display one message.
    // The message that your code displays will depend on the other five rules. 
    // For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.

// Rule 2: If the user's subscription will expire in 10 days or less, display the message:
    // "Your subscription will expire soon. Renew now!"

// Rule 3: If the user's subscription will expire in five days or less, display the messages:
    // "Your subscription expires in _ days."
    // "Renew now and save 10%!"
        // Be sure to replace the _ character displayed in the message above with the value stored in the 
        // variable 'daysUntilExpiration' when you construct your message output.

// Rule 4: If the user's subscription will expire in one day, display the messages:
    // "Your subscription expires within a day!"
    // "Renew now and save 20%!"

// Rule 5: If the user's subscription has expired, display the message:
    // "Your subscription has expired."

// Rule 6: If the user's subscription doesn't expire in 10 days or less, display nothing.


// Implement your solution code using if statements
// Your solution must use separate if and if-else statements to implement the business rules. The if-else statement can include multiple else if parts.

    // 1. Create an if-else statement that displays a message about when the subscription will expire.

        //  Tip - Use an else if to ensure each expiration rule is accounted for.

    // 2. Create a separate if statement that displays a discount offer.
    // The business rules indicate when a discount should be offered.


Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration == 0) {
    Console.WriteLine("Your subscription has expired.");
} else if (daysUntilExpiration == 1) {
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!");
} else if (daysUntilExpiration <= 5) {
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
} else if (daysUntilExpiration <= 10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}


// -----------------------------------------
