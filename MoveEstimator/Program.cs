// Define constants
const double BASE_RATE = 200.00;
const double HOURLY_RATE = 150.00;
const double MILE_RATE = 2.00;

// Prompt for input
Console.Write("Enter the number of hours for the job: ");
double hours = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the number of miles taken in the move: ");
double miles = Convert.ToDouble(Console.ReadLine());

// Calculate the total fee
double totalCost = BASE_RATE + (HOURLY_RATE * hours) + (MILE_RATE * miles);

// Display the result
Console.WriteLine("The total moving fee is: $" + totalCost);
