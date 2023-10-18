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