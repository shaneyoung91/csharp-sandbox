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

/*
// -------------- CODE CHALLENGE --------------
// Implement a method of the Math class that returns the larger of two numbers
// Use the method that you found to assign a value to the variable named largerValue.
// You should be able to pass the two integer values, firstValue and secondValue, to the method that you found.
// The method should return a value of type int that represents the larger of the two arguments that you passed it.
// You can assign the return value to largerValue on a new code line or on the existing code line that's used to declare largerValue.

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
// -------------------------------------------- */


/*
// ------- LESSON: Using if, else if, else, statements -------
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16) {
    Console.WriteLine("You win a new car!");
}
else if (total >= 10) {
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7) {
    Console.WriteLine("You win a trip for two!");
} else {
    Console.WriteLine("You win a kitten!");
}
// ---------------------------------------------- */


/*
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
// ----------------------------------------- */


// ----------- LESSON: Arrays --------------

/*
// Declare a new array of strings
string[] fraudulentOrderIDs = new string[3];

// Assign values to elements of an array
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

/*
// Initialize an array
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Retrieve values from elements of an array
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassign value of an array
fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Use the Length property of an array
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

/*
// Implement the forEach statement
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int items in inventory) {
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running Total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/


// ------------ CODE CHALLENGE --------------
/* Report the Order IDs that need further investigation
    Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. 
    You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". 
    This will be used by the fraud team to investigate further.

1. Declare an array and initialize it to contain the following elements:

        B123
        C234
        A345
        C15
        B177
        G3003
        C235
        B179

These values represent the fraudulent Order ID data that your application use.

2. Create a foreach statement to iterate through each element of your array.

3. Report the Order IDs that start with the letter "B".
    You need to evaluate each element of the array. Report the potentially fraudulent Order IDs by detecting the orders that start with the letter "B". 
    To determine whether or not an element starts with the letter "B", use the String.StartsWith() method. 
    Here's a simple example of how to use the String.StartsWith() method that you can adapt for your code:

        string name = "Bob";
        if (name.StartsWith("B")) {
            Console.WriteLine("The name starts with 'B'!");
        }

    Your output should match the following:

        B123
        B177
        B179

Here's a hint: As you loop through each element in your array, you'll need an if statement. 
The if statement will need to use a method on the string class to determine if a string starts with a specific letter. 
If you're not sure how to use an if statement, please see the module "Add decision logic to your code using the if-elseif-else statement in C#".
*/

/*
string[] fraudulentOrderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach (string order in fraudulentOrderIDs) {
    if (order.StartsWith("B")) {
        Console.WriteLine(order);
    }
}
// --------------------------------------------- */



// ------------- CODE CHALLENGE --------------
/* Apply style guidelines to improve readability */

/*
string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");
*/

// ---------- Solution -------------
/* This code reverses a message, counts the number of times 
    a particular character appears, then prints the results
    to the console window. */

/*
string origMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = origMessage.ToCharArray();
Array.Reverse(message);

int count = 0;
foreach (char letter in message)
{ 
    if (letter == 'o')
    { 
        count++; 
    } 
}

string new_message = new String(message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {count} times.");
*/
// ----------------------------------


/* -------- LESSON: Evaluating Expressions ------------- */

// --------- Equality ----------
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// --------- Inequality ---------
// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");


// --------- Comparison -----------
// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);


// --------- Boolean ----------
// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));


// --------- Logical Negation -----------
// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));


// --------- Conditional Operator ---------
// int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");


// ------------------ CODE CHALLENGE -----------------------
// Write code to display the result of a coin flip. The resulting decision logic will display either heads or tails.
// Use the Random class to generate a value.
// Based on the value generated, use the conditional operator to display either heads or tails
// Your code should be easy to read, but with as few lines as possible.

/*
    Random coin = new Random();
    int flip = coin.Next(2);
    string result = flip == 0 ? "Heads" : "Tails";
    Console.WriteLine($"Result of Coin Flip: {result}");
*/


// ------------------ CODE CHALLENGE -----------------------
// Implement decision logic based on a series of business rules.
// You will need to use the Contains() helper method to determine whether the value assigned to the permission string contains 
// one of the permission values specified by the "business rules". For example, the expression permission.Contains("Admin") 
// will return true when using the initial data values specified in the code above.

/* --------  BUSINESS RULES THAT YOUR SOLUTION MUST SATISFY ---------
    If the user is an Admin with a level greater than 55, output the message:
        Welcome, Super Admin user.
    If the user is an Admin with a level less than or equal to 55, output the message:
        Welcome, Admin user.
    If the user is a Manager with a level 20 or greater, output the message:
        Contact an Admin for access.
    If the user is a Manager with a level less than 20, output the message:
        You do not have sufficient privileges.
    If the user is not an Admin or a Manager, output the message:
        You do not have sufficient privileges.
*/

/* ---------------- SOLUTION -------------------
string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}
*/


/* -------- LESSON: CONTROL VARIABLE SCOPE AND LOGIC USING CODE BLOCKS ------------- */

// Variable inside and outside a code block
/*
    bool flag = true;
    int value = 0;

    if (flag)
    {
        value = 10;
        Console.WriteLine("Inside of code block: " + value);
    }
    Console.WriteLine("Outside of code block: " + value);
*/

// Remove code blocks from if statements
/*
    string name = "steve";

    if (name == "bob")
        Console.WriteLine("Found Bob");
    else if (name == "steve")
        Console.WriteLine("Found Steve");
    else
        Console.WriteLine("Found Chuck");
*/

// ------------------ CODE CHALLENGE -----------------------
/*  UPDATE PROBLEMATIC CODE
int[] numbers = { 4, 8, 15, 16, 23, 42 };

foreach (int number in numbers)
{
    int total;

    total += number;

    if (number == 42)
    {
       bool found = true;

    }

}

if (found) 
{
    Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
*/

/* ------------ SOLUTION ----------------
    int[] numbers = { 4, 8, 15, 16, 23, 42 };
    int total = 0;
    bool found = false;

    foreach (int number in numbers)
    {
        total += number;
        if (number == 42)
            found = true;
    }

    if (found) 
        Console.WriteLine("Set contains 42");

    Console.WriteLine($"Total: {total}");
*/


/* -------- LESSON: BRANCHING LOGIC (SWITCH-CASE CONSTRUCT) ------------- */
// A switch statement is C# selection statement that provides an alternative to an if-elseif-else branching construct.
// The switch statement provides advantages over an if-elseif-else construct when evaluating a single value against a list of known matching values.
// The switch statement chooses one section of code to execute from a list of possible switch sections.
// The selected switch sections is chosen based on a pattern match with the statement's match expression.

/* Example
    switch (fruit)
    {
        case "apple":
            Console.WriteLine($"App will display information for apple.");
            break;
        
        case "banana":
            Console.WriteLine($"App will display information for bananas.");
            break;

        case "cherry":
            Console.WriteLine($"App will display information for cherry.");
            break;
    }
*/

// Create and test a switch statement
/*
    int employeeLevel = 100;
    string employeeName = "John Smith";

    string title = "";

    switch (employeeLevel)
    {
        case 100: // both case labels for 100 and 200 are now paired with the Senior Associate title
        case 200:
            title = "Senior Associate";
            break;
        case 300:
            title = "Manager";
            break;
        case 400:
            title = "Senior Manager";
            break;
        default:
            title = "Associate";
            break;
    }

    Console.WriteLine($"{employeeName}, {title}");
*/

// ------------------ CODE CHALLENGE -----------------------
// Rewrite if-elseif-else using a switch statement

/* ------ ORIGINAL CODE -----
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
} else if (product[0] == "02")
{
    type = "T-Shirt";
} else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
} else if (product[1] == "MN")
{
    color = "Maroon";
} else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
} else if (product[2] == "M")
{
    size = "Medium";
} else if (product[2] == "L")
{
    size = "Large";
} else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");
*/

// ------------- SOLUTION --------------
/*
    // SKU = Stock Keeping Unit. 
    string sku = "01-MN-L";

    string[] product = sku.Split('-');

    string type = "";
    string color = "";
    string size = "";

    switch (product[0])
    {
        case "01":
            type = "Sweat shirt";
            break;
        case "02":
            type = "T-Shirt";
            break;
        case "03":
            type ="Sweat pants";
            break;
        default:
            type = "Other";
            break;
    }

    switch (product[1])
    {
        case "BL":
            color = "Black";
            break;
        case "MN":
            color = "Maroon";
            break;
        default:
            color = "White";
            break;
    }

    switch (product[2])
    {
        case "S":
            size = "Small";
            break;
        case "M":
            size = "Medium";
            break;
        case "L":
            size = "Large";
            break;
        default:
            size = "One Size Fits All";
            break;
    }

    Console.WriteLine($"Product: {size} {color} {type}");
*/


/* -------- LESSON: FOR LOOPS ------------- */

// Loop through each element of an array (backwards)
// string[] names = {"Alex", "Eddie", "David", "Michael"};
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// Limitations of foreach statement
// string[] names = {"Alex", "Eddie", "David", "Michael"};
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

// Overcoming limitation of foreach using the for statement
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David")
//         names[i] = "Sammy";

// foreach (var name in names)
//     Console.WriteLine(name);

// ------------------ CODE CHALLENGE -----------------------
// FizzBuzz challenge
/*
    Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
    When the current value is divisible by 3, print the term Fizz next to the number.
    When the current value is divisible by 5, print the term Buzz next to the number.
    When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number
*/

// ----------------- SOLUTION ------------------
/*
    for (int i = 1; i < 101; i++)
    {
        if (i % 3 == 0 && i % 5 == 0)
            Console.WriteLine($"{i} - FizzBuzz");
        else if (i % 3 == 0)
            Console.WriteLine($"{i} - Fizz");
        else if (i % 5 == 0)
            Console.WriteLine($"{i} - Buzz");
        else
            Console.WriteLine(i);
    }
*/


/* ------------- LESSON: DO-WHILE AND WHILE LOOPS ------------- */
/*  The do-while statement executes a statement or a block of statements while a specified Boolean expression evaluates to true.
    Because that expression is evaluated after each execution of the loop, a do-while loop executes one of more times.

        do
        {
            // This codes executes at least one time
        } while (true)
    
    The flow of execution starts inside the curly brackets. The code executes at least one time, then the Boolean expression next to the while keyword
    is evaluated. If the Boolean expression returns true, the code block is executed again. By hard coding the Boolean expression to true, we've created an infinite loop.
*/

// Write a do-while statement to break when a certain random number is generated
// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// Write a while statement that iterates only while a random number is greater than some value
// Random random = new Random();
// int current = random.Next(1, 11);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// Use the continue statement to step directly to the Boolean expression
// The continue statement transfers execution to the end of the current iteration.
// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);
//     if (current >= 8) continue;
//     Console.WriteLine(current);
// } while (current != 7);

// ------------------ CODE CHALLENGE -----------------------
// Role playing game battle challenge
/*  Rules to implement in your code:
        You must use either the do-while statement or the while statement as an outer game loop.
        The hero and the monster will start with 10 health points.
        All attacks will be a value between 1 and 10.
        The hero will attack first.
        Print the amount of health the monster lost and their remaining health.
        If the monster's health is greater than 0, it can attack the hero.
        Print the amount of health the hero lost and their remaining health.
        Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
        Print the winner.
*/

/* Code solution should produce a similar output:
        Monster was damaged and lost 1 health and now has 9 health.
        Hero was damaged and lost 1 health and now has 9 health.
        Monster was damaged and lost 7 health and now has 2 health.
        Hero was damaged and lost 6 health and now has 3 health.
        Monster was damaged and lost 9 health and now has -7 health.
        Hero wins!
*/

/*  ------------- SOLUTION --------------
    Random attack = new Random();
    int heroHealth = 10;
    int monsterHealth = 10;

    do
    {
        int roll = attack.Next(1, 11);
        monsterHealth -= roll;
        Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monsterHealth} health.");

        if (monsterHealth <= 0) continue;

        roll = attack.Next(1, 11);
        heroHealth -= roll;
        Console.WriteLine($"Hero was damaged and lost {roll} health and now has {heroHealth} health.");

    } while (monsterHealth > 0 && heroHealth > 0);

    Console.WriteLine(heroHealth > monsterHealth ? "Hero wins!": "Monster wins!");
*/


// ------------------ CODE CHALLENGE (1 of 3) -----------------------
// Write code that validates integer input
/*
    Your solution must include either a do-while or while iteration.
    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
    Inside the iteration block:
        Your solution must use a Console.ReadLine() statement to obtain input from the user.
        Your solution must ensure that the input is a valid representation of an integer.
        If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
        Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
    Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

/* Code solution should produce a similar output:
    Enter an integer value between 5 and 10
        two
    Sorry, you entered an invalid number, please try again
        2
    You entered 2. Please enter a number between 5 and 10.
        7
    Your input value (7) has been accepted.
*/

/* ---------- SOLUTION (1 of 3) -------------
    string? readResult;
    bool validEntry = false;
    int numericValue = 0;
    bool validNumber = false;
    Console.WriteLine("Enter an integer value between 5 and 10");
    do
    {
        readResult = Console.ReadLine();
        validNumber = int.TryParse(readResult, out numericValue);

        if (validNumber == false)
        {
            Console.WriteLine("Sorry, you entered an invalid number, please try again.");
        }
        
        if (numericValue < 5 || numericValue > 10)
        {
            Console.WriteLine($"You entered {readResult}. Please enter a number between 5 and 10.");
        } else if (numericValue >= 5 && numericValue <= 10)
        {
            validEntry = true;
            Console.WriteLine($"Your input value ({readResult}) has been accepted.");
            break;
        } 

    } while (validEntry == false);
*/


// ------------------ CODE CHALLENGE (2 of 3) -----------------------
// Write code that validates string input
/*
    Your solution must include either a do-while or while iteration.
    Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User
    Inside the iteration block:
        Your solution must use a Console.ReadLine() statement to obtain input from the user.
        Your solution must ensure that the value entered matches one of the three role options.
        Your solution should use the Trim() method on the input value to ignore leading and training space characters.
        Your solution should use the ToLower() method on the input value to ignore case.
        If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
    Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.
*/

/* Code solution should produce a similar output:
    Enter your role name (Administrator, Manager, or User)
        Admin
    The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
        Administrator
    Your input value (Administrator) has been accepted.
*/

/* ---------- SOLUTION (2 of 3) -------------
    string? readResult;
    bool validEntry = false;
    string userEntry = "";
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            userEntry = readResult.Trim().ToLower();

            if (userEntry == "administrator" || userEntry == "manager" || userEntry == "user")
            {
                Console.WriteLine($"Your input value ({userEntry}) has been accepted.");
                validEntry = true;
            } else
                Console.WriteLine($"The role that you entered, '{userEntry}' is not valid. Enter your role name (Administrator, Manager, or User)");
        }
    } while (validEntry == false);
*/


// ------------------ CODE CHALLENGE (3 of 3) -----------------------
// Write code that process the contents of a string array
/*
    Your solution must use the following string array to represent the input to your coding logic:
        string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.
    Your solution must include an outer foreach or for loop that can be used to process each string element in the array. 
        The string variable that you'll process inside the loops should be named myString.
    In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable.
        The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.
    Your solution must include an inner do-while or while loop that can be used to process the myString variable.
    In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.
    In the inner loop, your solution must not display the period character.
    In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information.
*/

/* Code solution should produce a similar output:
    I like pizza
    I like roast chicken
    I like salad
    I like all three of the menu choices
*/

// ---------- SOLUTION (3 of 3) -----------------
/*
    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

    int periodLocation;

    foreach (string myString in myStrings)
    {    
        periodLocation = myString.IndexOf(".");

        if (periodLocation != -1)
        {
            string string1 = myString.Remove(periodLocation);
            Console.WriteLine(string1);

            string string2 = myString.Substring(periodLocation + 2);
            periodLocation = string2.IndexOf(".");
            Console.WriteLine(string2.Remove(periodLocation));
            
            string string3 = string2.Substring(periodLocation + 2);
            Console.WriteLine(string3);
        } else
        {
            Console.WriteLine(myString);
        }
    }
*/

/*  CORRECT SOLUTION
    string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
    int stringsCount = myStrings.Length;

    string myString = "";
    int periodLocation = 0;

    for (int i = 0; i < stringsCount; i++)
    {
        myString = myStrings[i];
        periodLocation = myString.IndexOf(".");

        string mySentence;

        // extract sentences from each string and display them one at a time
        while (periodLocation != -1)
        {
            // first sentence is the string value to the left of the period location
            mySentence = myString.Remove(periodLocation);

            // the remainder of myString is the string value to the right of the location
            myString = myString.Substring(periodLocation + 1);

            // remove any leading white-space from myString
            myString = myString.TrimStart();

            // update the comma location and increment the counter
            periodLocation = myString.IndexOf(".");

            Console.WriteLine(mySentence);
        }

        mySentence = myString.Trim();
        Console.WriteLine(mySentence);
    }
*/


/* ---- LESSON: Value vs. Reference Types -------

Variables of reference types store references to their data (objects), that is they point to data values stored somewhere else. 
In comparison, variables of value types directly contain their data..

Simple value types are a set of predefined types provided by C# as keywords. 
These keywords are aliases (a nickname) for predefined types defined in the .NET Class Library. 
For example, the C# keyword int is an alias of a value type defined in the .NET Class Library as System.Int32.

Simple value types include many of the data types that you may have used already like char and bool. 
There are also many integral and floating-point value types to represent a wide range of whole and fractional numbers.

*/

/* -------- Integral Types --------- 
An integral type is a simple value type that represents whole numbers with no fraction (such as -1, 0, 1, 2, 3). The most popular in this category is the int data type.
There are two subcategories of integral types: signed and unsigned integral types. 
*/


/* ------- Signed Integral Types ------
// A signed type uses its bytes to represent an equal number of positive and negative numbers.

Console.WriteLine("Signed integral types:");
Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");
*/

/* ------- Unsigned Integral Types ------
// An unsigned type uses its bytes to represent only positive numbers. 

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");
Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");
*/

/* ------- Floating Point Types ---------
A floating point is a simple value type that represents numbers to the right of the decimal place.
Evaluating floating-point types:
    1 - Consider the digits of precision each type allows. Precision is the number of value places stored after the decimal point
    2 - Consider the manner in which the values are stored and the impact on the accuracy of the value.
        Float and double should only be used when an approximation is useful. Use decimal when you need a more precise answer

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal : {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/


/* ------- Reference Types ----------
Reference types include arrays, classes, and strings. Reference types are treated differently from value types regarding the way values
are stored when the application is executing.

A value type variable stores its values directly in an area of storage called the stack. The stack is memory allocated to the
code that is currently running on the CPU. When the stack frame has finished executing, the values in the stack are removed.

A reference type variable stores its values in a separate memory region called the heap. 
The heap is a memory area that is shared across many applications running on the operating system at the same time.
*/


/* ------- Choosing the right data type -----
int - most whole numbers
decimal -  numbers representing money
bool - true or false values
string -  alphanumeric value

byte - working with encoded data that comes from other computer systems or using diff character sets
double - working with geometric or scientific purposes. used frequently when building games involving motion.
System.DateTime - specific date and time value
System.TimeSpan - span of years / months / days / hours / minutes / seconds / milliseconds
*/



/* ------- LESSON: Data Type Casting and Conversion ---------

int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result);  // Error cannot convert type 'string' to 'int'

int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result); // Output - 24

To perform data conversion, you can use one of several techniques:
    - Use a helper method on the data type
    - Use a helper method on the variable
    - Use the Convert class method

int myInt = 3;
Console.WriteLine($"int: {myInt}"); // Output - int: 3
decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}"); // Output - decimal: 3;

Since any int value can easily fit inside of a decimal, the compiler performs the conversion.
The term widening conversion means that you're attempting to convert a value from a data type that 
    could hold less information to a data type that can hold more information.


----- PERFORM A CAST ------
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}"); // Output - decimal: 3.14
int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}"); // Output - int: 3

To perform a cast, use the casting operator () to surround a data type, then place it next to the variable
    you want to convert. You perform an explicit conversion to the defined cast data type.

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;
Console.WriteLine($"Decimal: {myDecimal}"); // Output - Decimal: 1.23456789
Console.WriteLine($"Float: {myFloat}"); // Output - Float:   1.234568


----- Use ToString() to convert a number to a string ---------
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message); // Output - 57


----- Convert a string to an int using the Parse() helper method ----
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum); // Output - 12


----- Convert a string to a int using the Convert class ----
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result); // Output - 35

The Convert class is best for converting fractional numbers into whole numbers (int)
    because it rounds up the way you would expect.


----- Compare casting and converting a decimal into an int ----- 
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);

When you're casting int value = (int)1.5m;, the value of the float is truncated so the result is 1, 
    meaning the value after the decimal is ignored completely. You could change the literal float to 1.999m and the result of casting would be the same.

When you're converting using Convert.ToInt32(), the literal float value is properly rounded up to 2. 
    If you changed the literal value to 1.499m, it would be rounded down to 1.


----- EXERCISE: Examine the TryParse() method -----
The TryParse() method does several things simultaneously:
    - It attempts to parse a string into the given numeric data type.
    - If successful, it stores the converted value in an out parameter.
    - It returns a bool to indicate whether the action succeeded or failed.

Out parameters
    - Methods can return a value or return "void"- meaning they return no value.
    - Methods can also return values through out parameters, which are defined just like an input parameter, but include the out keyword.

string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}"); // Output - Measurement: 102
}
else
{
    Console.WriteLine("Unable to report the measurement");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}"); // Output - Measurement (w/ offset): 152


string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement."); // Output - Unable to report the measurement.
}
if (result > 0)
    Console.WriteLine($"Measurement (w/offset): {50 + result}");

 */

/* ----- CHALLENGE #1: COMBINE STRING ARRAY VALUES AS STRINGS AND INTEGERS  -----

Create a looping structure that can be used to iterate through each string value in the array values.
Implement the following business rules in your code logic:
    (1) If the value is alphabetical, concatenate to form a message.
    (2) If the value is numeric, add it to the total.
    (3) The result should match the following output:
        Message: ABCDEF
        Total: 68.3

------ SOLUTION -------
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0m;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else
    {
        message += value;
    }
}
Console.WriteLine($"Message: {message}");
Console.WriteLine($"Total: {total}");
*/


/* ----- CHALLENGE #2: OUTPUT MATH OPERATIONS AS SPECIFIC NUMBER TYPES  -----
Solve for result1: Divide value1 by value2, display the result as an int
Solve for result2: Divide value2 by value3, display the result as a decimal
Solve for result3: Divide value3 by value1, display the result as a float
The output should resemble:
    Divide value1 by value2, display the result as an int: 2
    Divide value2 by value3, display the result as a decimal: 1.4418604651162790697674418605
    Divide value3 by value1, display the result as a float: 0.3583333

------ SOLUTION -------
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
int intValue2 = Convert.ToInt32(value2);
int result1 = value1 / intValue2;
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/


/* ----- LESSON: OPERATIONS ON ARRAYS USING HELPER METHODS -----

Sort() and Reverse() Methods
    string[] pallets = { "B14", "A11", "B12", "A13" };

    Console.WriteLine("Sorted...");
    Array.Sort(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Console.WriteLine("Reversed...");
    Array.Reverse(pallets);
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }


Clear() and Resize() Methods
    string[] pallets = { "B14", "A11", "B12", "A13" };
    Console.WriteLine("");

    Array.Clear(pallets, 0, 2);
    Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 6);
    Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

    pallets[4] = "C01";
    pallets[5] = "C02";

    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }

    Console.WriteLine("");
    Array.Resize(ref pallets, 3);
    Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
    foreach (var pallet in pallets)
    {
        Console.WriteLine($"-- {pallet}");
    }


Split() and Join() Methods
    string value = "abc123";
    char[] valueArray = value.ToCharArray();
    Array.Reverse(valueArray);
    string result = String.Join(",", valueArray);
    Console.WriteLine(result);

    string[] items = result.Split(',');
    foreach (string item in items)
    {
        Console.WriteLine(item);
    }

---------- CHALLENGE #1: REVERSE WORDS IN A SENTENCE -----------
Reverse the letters of each word in place and display the result. You'll need to reverse just the letters in each word, 
    but print the reversed word in its original position in the message.

Your code must produce the following output:
    "ehT kciuq nworb xof spmuj revo eht yzal god"

--------- SOLUTION ---------
    string pangram = "The quick brown fox jumps over the lazy dog";

    char[] valueArray = pangram.ToCharArray();
    Array.Reverse(valueArray);

    string result = String.Join("", valueArray);

    string[] words = result.Split(" ");
    Array.Reverse(words);

    string solution = String.Join(" ", words);
    Console.WriteLine(solution);


---------- CHALLENGE #2: PARSE A STRING OF ORDERS, SORT, AND TAG ERRORS -----------
Parse the individual "Order IDs", and output the "OrderIDs" sorted and tagged as "Error" 
    if they aren't exactly four characters in length.

Your code must produce the following output:
    A345
    B123
    B177
    B179
    C15     - Error
    C234
    C235
    G3003   - Error

--------- SOLUTION ----------
    string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
    string[] orders = orderStream.Split(",");
    Array.Sort(orders);

    foreach (string orderID in orders)
    {
        if (orderID.Length != 4)
        {
            Console.WriteLine($"{orderID}  - Error");
        }
        else
        {
            Console.WriteLine(orderID);
        }
    }
*/


/* ------ LESSON: FORMAT ALPHANUMERIC DATA FOR PRESENTATION ----------

Composite formatting
    - Uses numbers placeholders within a string. At run time, everything inside the braces is resolved
    to a value that is also passed in based on their position.

    string first = "Hello";
    string second = "World";
    string result = string.Format("{0} {1}!", first, second);  // Hello World!
    Console.WriteLine(result);
        // Uses built-in method Format() on the string data type keyword.
        // The literal string "{0} {1}!" forms a template, parts of which are replaced at run time.
        // The token {0} is replaced by the first argument after the string template (the value of the variable first).
        // The token {1} is replaced by the second argument after the string template (the value of the variable second).

    string first = "Hello";
    string second = "World";
    Console.WriteLine("{1} {0}!", first, second);  // World Hello!
    Console.WriteLine("{0} {0} {0}!", first, second);  // Hello Hello Hello!


String Interpolation
    - A technique that simplifies composite formatting.
    - Instead of using a numbered token and including the literal value or variable name in a list of arguments, you can just use
    the variable name inside of the curly braces.
    - Must be prefixed with "$".

    string first = "Hello";
    string second = "World";
    Console.WriteLine($"{first} {second}!"); // Hello World!
    Console.WriteLine($"{second} {first}!"); // World Hello!
    Console.WriteLine($"{first} {first} {first}!"); // Hello Hello Hello!


Formatting Currency
    - Use " :C " currency format specifier to present variables as currency.

    decimal price = 123.45m;
    int discount = 50;
    Console.WriteLine($"Price: {price:C} (Save {discount:C})"); // Price: $123.45 (Save $50.00)
        // Adding " :C " formats the number as currency regardless of whether you use int or decimal.


Formatting Numbers
    - You may want to format numbers for readability by including commas to delineate thousands, millions, billions, and so on.
    - The " N " numeric format specifier makes numbers more readable.

    decimal measurement = 123456.78912m;
    Console.WriteLine($"Measurement: {measurement:N} units"); // Measurement: 123,456.789 units
        // Be default, it displays three digits after the decimal point
        // You can display more/less precision, by adding a number after the specifier (N2 / N4)


Formatting Percentages
    - Use the " P " format specifier to format percentages. Add a number afterwards to control the number of values displayed after the decimal point.

    decimal tax = .36785m;
    Console.WriteLine($"Tax rate: {tax:P2}"); // Tax rate: 36.79%


Combining Formatting Approaches
    - String variables can store strings created using formatting techniques.

    decimal price = 67.55m;
    decimal salePrice = 59.99m;
    string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
    yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; // You can combine multiple formatted strings
    Console.WriteLine(yourDiscount); // You saved $7.56 off the regular $67.55 price. A discount of 11.19%!


EXERCISE - String Interpolation
    - You need to create the code to print a receipt for the customer purchasing shares of an investment product. 
    - The shares are purchased automatically at the end of the year based on a series of payroll deductions, so the number of shares purchased usually contains a decimal amount. 
    - To print the receipt, you would likely need to combine data of different types, including fractional values, currency, and percentages in precise ways.

    int invoiceNumber = 1201;
    decimal productShares = 25.4568m;
    decimal subtotal = 2750.00m;
    decimal taxPercentage = .15825m;
    decimal total = 3185.19m;

    Console.WriteLine($"Invoice Number: {invoiceNumber}");
    Console.WriteLine($"    Shares: {productShares:N3} Product");
    Console.WriteLine($"      Sub Total: {subtotal:C}");
    Console.WriteLine($"            Tax: {taxPercentage:P2}");
    Console.WriteLine($"      Total Billed: {total:C}");


EXERCISE - Padding and Alignment

    string input = "Pad this";
    Console.WriteLine(input.PadLeft(12));
    Console.WriteLine(input.PadRight(12));
    // Overloaded method
    Console.WriteLine(input.PadLeft(12, '-'));
    Console.WriteLine(input.PadRight(12, '-'));

    string paymentId = "769C";
    string payeeName = "Mr. Stephen Ortega";
    string paymentAmount = "$5,000.00";

    var formattedLine = paymentId.PadRight(6);
    formattedLine += payeeName.PadRight(24);
    formattedLine += paymentAmount.PadLeft(10);

    Console.WriteLine("1234567890123456789012345678901234567890");
    Console.WriteLine(formattedLine);


---------- CHALLENGE: APPLY STRING INTERPOLATION TO FORM A LETTER -----------
    - Build an application that can merge and format the appropriate content given the previous example output.
    - Pay particular attention to the white space and make sure you accurately represent this exact format using C#.
    - Expected Output:

        Dear Ms. Barros,
        As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

        Currently, you own 2,975,000.00 shares at a return of 12.75 %.

        Our new product, Glorious Future offers a return of 13.13 %.  Given your current volume, your potential profit would be ¤63,000,000.00.

        Here's a quick comparison:

        Magic Yield         12.75 %   $55,000,000.00      
        Glorious Future     13.13 %   $63,000,000.00  


--------- SOLUTION ----------
    string customerName = "Ms. Barros";

    string currentProduct = "Magic Yield";
    int currentShares = 2975000;
    decimal currentReturn = 0.1275m;
    decimal currentProfit = 55000000.0m;

    string newProduct = "Glorious Future";
    decimal newReturn = 0.13125m;
    decimal newProfit = 63000000.0m;

    // Your logic here
    Console.WriteLine($"Dear {customerName},");
    Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return,\n");
    Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P2}.\n");
    Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

    Console.WriteLine("Here's a quick comparison:\n");
    string comparisonMessage = "";

    // Your logic here
    comparisonMessage += currentProduct;
    comparisonMessage += currentReturn.ToString("P2").PadLeft(15);
    comparisonMessage += currentProfit.ToString("C").PadLeft(18);
    comparisonMessage += "\n";
    comparisonMessage += newProduct;
    comparisonMessage += newReturn.ToString("P2").PadLeft(11);
    comparisonMessage += newProfit.ToString("C").PadLeft(18);

    Console.WriteLine(comparisonMessage);

    // Alternate Solution
    comparisonMessage = currentProduct.PadRight(20);
    comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
    comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

    comparisonMessage += "\n";
    comparisonMessage += newProduct.PadRight(20);
    comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
    comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);
*/



/* ------ LESSON: MODIFY CONTENT OF STRINGS ----------

EXERCISE - Use the string's IndexOf() and Substring() helper methods
    - Use the IndexOf() method to locate the position of one or more characters string inside a larger string.
    - Use the Substring() method to return the part of the larger string that follows the character positions you specify.
    - Also use an overloaded version of the Substring() method to set the length of characters to return after a specified position in a string.


    string message = "Find what is (inside the parentheses)";
    int openingPosition = message.IndexOf("(");
    int closingPosition = message.IndexOf(")");
    openingPosition += 1;
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length)); // inside the parentheses


    string message2 = "What is the value <span>between the tags</span>?";
    const string openSpan = "<span>";
    const string closeSpan = "</span>";
    int openingPosition2 = message2.IndexOf(openSpan);
    int closingPosition2 = message2.IndexOf(closeSpan);
    openingPosition2 +=  openSpan.Length;
    int length2 = closingPosition2 - openingPosition2;
    Console.WriteLine(message2.Substring(openingPosition2, length2)); //  between the tags


EXERCISE - Use the string's IndexOfAny() and LastIndexOf() helper methods
    - Use the IndexOfAny() method to find the first location of any of the string from selected array.
    - Use LastIndexOf() to find the final location of a string within another string


    string message = "(what if) I am (only interested) in the last (set of parentheses)?";
    int openingPosition = message.LastIndexOf('(');
    openingPosition += 1;
    int closingPosition =  message.LastIndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length)); // set of parentheses


    // Retrieve all instances of substrings inside parentheses
    string message = "(What if) there are (more than) one (set of parentheses)?";
    while (true)
    {
        int openingPosition = message.IndexOf('(');
        if (openingPosition == -1) break;

        openingPosition += 1;
        int closingPosition = message.IndexOf(')');
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length)); // What if - more than - set of parentheses

        // Note the overload of the Substring to return only the remaining
        // unprocessed message:
        message = message.Substring(closingPosition + 1);
    }

    // Work with different types of symbol sets
    string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

    // The IndexOfAny() helper method requires a char array of characters. 
    // You want to look for:

    char[] openSymbols = { '[', '{', '(' };

    // You'll use a slightly different technique for iterating through 
    // the characters in the string. This time, use the closing 
    // position of the previous iteration as the starting index for the 
    //next open symbol. So, you need to initialize the closingPosition 
    // variable to zero:

    int closingPosition = 0;
    while (true)
    {
        int openingPosition = message.IndexOfAny(openSymbols, closingPosition);
        if (openingPosition == -1) break;
        string currentSymbol = message.Substring(openingPosition, 1);
        // Now find the matching closing symbol
        char matchingSymbol = ' ';
        switch (currentSymbol)
        {
            case "[":
                matchingSymbol = ']';
                break;
            case "{":
                matchingSymbol = '}';
                break;
            case "(":
                matchingSymbol = ')';
                break;
        }

        // To find the closingPosition, use an overload of the IndexOf method to specify 
        // that the search for the matchingSymbol should start at the openingPosition in the string. 
        openingPosition += 1;
        closingPosition = message.IndexOf(matchingSymbol, openingPosition);

        // Finally, use the techniques you've already learned to display the sub-string:
        int length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));
    }

    // LastIndexOf() returns the last position of a character or string inside of another string.
    // IndexOfAny() returns the first position of an array of char that occurs inside of another string.


EXERCISE - Use the Remove() and Replace() methods
    - Remove characters from a string using the Remove() method and replace characters using the Replace() method.

    // Remove() Method
    string data = "12345John Smith          5000  3  ";
    string updatedData = data.Remove(5, 20);
    Console.WriteLine(updatedData);

    // Replace() Method
    string message = "This--is--ex-amp-le--da-ta";
    message = message.Replace("--", " ");
    message = message.Replace("-", "");
    Console.WriteLine(message);

    // The Remove() method works like the Substring() method, except that it deletes the specified characters in the string.
    // The Replace() method swaps all instances of a string with a new string.


---------- CHALLENGE: EXTRACT, REPLACE, AND REMOVE DATA FROM INPUT STRING -----------
    - Set the quantity variable to the value by extracting the text from between the <span> and </span> tags.
    - Set the output variable to the value of input, then remove the <div> and </div> tags.
    - Replace the HTML character ™ (&trade;) with ® (&reg) in the output variable.
    - Expected Output:
        Quantity: 5000
        Output: <h2>Widgets &reg;</h2><span>5000</span>


--------- SOLUTION ----------
    const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

    string quantity = "";
    string output = "";

    // Your work here
    const string openSpanTag = "<span>";
    const string closeSpanTag = "</span>";
    int openSpan = input.IndexOf(openSpanTag);
    int closeSpan = input.IndexOf(closeSpanTag);
    openSpan += openSpanTag.Length;
    int spanLength = closeSpan - openSpan;
    quantity = "Quantity: ";
    quantity += input.Substring(openSpan, spanLength);
    Console.WriteLine(quantity);

    const string openDivTag = "<div>";
    const string closeDivTag = "</div>";
    int closeDiv = closeDivTag.Length;
    output = "Output: ";
    output += input.Replace(openDivTag, "").Replace("&trade", "&reg").Replace(closeDivTag, "");
    Console.WriteLine(output);

    ----- ALTERNATE SOLUTION -------
    // Extract the quantity
    int quantityStart = input.IndexOf("<span>");
    int quantityEnd = input.IndexOf("</span>");
    quantityStart += "<span>".Length; // Added length of the tag so index moves to end of the tag
    int quantityLength = quantityEnd - quantityStart;
    quantity = input.Substring(quantityStart, quantityLength); //Extracts from end of open tag to beginning of close tag
    quantity = $"Quantity: {quantity}";

    // Set output to input, replacing the trademark symbol with the registered trademark symbol
    output = input.Replace("&trade;", "&reg;");

    // Remove the opening <div> tag
    int divStart = input.IndexOf("<div>");
    int divLength = "<div>".Length;
    output = output.Remove(divStart, divLength);

    // Remove the closing <div> tag
    int divCloseStart = output.IndexOf("</div>");
    int divCloseLength = "</div>".Length;
    output = output.Remove(divCloseStart, divCloseLength);
    output = $"Output: {output}";

*/


