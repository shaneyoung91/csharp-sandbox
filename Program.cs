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