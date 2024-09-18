// Prompt the user for input
Console.WriteLine("Enter the wind speed (in miles per hour):");

// Read input until a space character
string input = Console.ReadLine();
double windSpeed;

// Check if the input is a valid integer
if (double.TryParse(input.Split(' ')[0], out windSpeed))
{
    // Determine the category of the hurricane based on the wind speed
    string category;
    if (windSpeed >= 157)
    {
        category = "Category Five Hurricane";
    }
    else if (windSpeed >= 130)
    {
        category = "Category Four Hurricane";
    }
    else if (windSpeed >= 111)
    {
        category = "Category Three Hurricane";
    }
    else if (windSpeed >= 96)
    {
        category = "Category Two Hurricane";
    }
    else if (windSpeed >= 74)
    {
        category = "Category One Hurricane";
    }
    else
    {
        category = "Not a hurricane";
    }

    // Output the hurricane category
    Console.WriteLine($"{category}");
}
else
{
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}

