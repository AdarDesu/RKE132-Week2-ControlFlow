// Application asks user to choose their gender. (Male or Female)

// Application asks user to enter their surname.

// Depending on the user's choice application greets them as follows: 

// "Welcome Mr. [User's surname] / Ms. [User's surname]"


//Name stuff...

Console.WriteLine("Please enter your surname:");

String UserSurname;

UserSurname = Console.ReadLine();

// Gender Stuff...

Console.WriteLine("Please select your gender (M/F):");

Char UserGender = Char.Parse(Console.ReadLine()); // Reads string data from the console.

if (UserGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {UserSurname}! (^-^)/");
}
else if (UserGender == 'M')
{
    Console.WriteLine($"Welcome, Mr. {UserSurname}! (^-^)/");
}
else if (UserGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {UserSurname}! (^-^)/");
}
else if (UserGender == 'F')
{
    Console.WriteLine($"Welcome, Ms. {UserSurname}! (^-^)/");
}
else
{
    Console.WriteLine("Error, please try again or give up! (T_T)");
}