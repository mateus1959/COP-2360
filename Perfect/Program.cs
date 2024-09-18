// Prompt the user to enter a number
Console.WriteLine("Enter a number between 1 and 10,000:");

// Read the input from the user
int number;

// Validate the input to make sure it's a number between 1 and 10,000
if (int.TryParse(Console.ReadLine(), out number) && number >= 1 && number <= 10000)
{
    // Check if the number is perfect
    if (IsPerfect(number))
    {
        Console.WriteLine($"{number} is a perfect number.");
    }
    else
    {
        Console.WriteLine($"{number} is not a perfect number.");
    }
}
else
{
    Console.WriteLine("Please enter a valid number between 1 and 10,000.");
}

// Method to check if a number is perfect
static bool IsPerfect(int number)
{
int sum = 0;

// Iterate through all the number that possibly divide evenly into the number
for (int i = 1; i <= number / 2; i++)
{
    // Check if remainder of division is zero, meaning it divides evenly into the input number
    if (number % i == 0)
    {
        // Add divisor to the sum of divisors
        sum += i;
    }
}

// Return true if the sum of divisors equals the number
return sum == number;
}