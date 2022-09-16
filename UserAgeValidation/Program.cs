// Application asks user to enter their age.
// If user is younger than 18 then: "You are too young to buy alcohol online"
// Else, consloe displays: "Welcome to the store!"

Console.WriteLine("Enter your age:");

////////////////////////////////////////////// Method 1 //////////////////////////////////////////////

//int UserAge = Int32.Parse(Console.ReadLine()); // '18' - Heap, 13 - Stack ... int for numbers

//if (UserAge > 122)
//{
//    Console.WriteLine("Your age is too old for normal human beings.");
//}
//else if (UserAge >= 18)
//{
//    Console.WriteLine("Welcome to the store!");
//}
//else if (UserAge < 3)
//{
//    Console.WriteLine("This store is not for babies!");
//}
//else
//{
//    Console.WriteLine("You are too young to visit the store.");
//}

////////////////////////////////////////////// Method 2 //////////////////////////////////////////////

string userAge = Console.ReadLine();

int userAgeNum  = 0;

bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum); // Boolean - true/false

Console.WriteLine($"Parse result {isAgeNumber}. User is {userAgeNum} years old.");

if(isAgeNumber)
{
    if (userAgeNum > 122)
    {
        Console.WriteLine("Your age is too old for normal human beings.");
    }
    else if (userAgeNum >= 18)
    {
        Console.WriteLine("Welcome to the store!");
    }
    else if (userAgeNum < 3)
    {
        Console.WriteLine("This store is not for babies!");
    }
    else
    {
        Console.WriteLine("You are too young to visit the store.");
    }
}
else
{
    Console.WriteLine("Could not detect your age.");
}