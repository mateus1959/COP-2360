const int numberOfTemperatures = 5;
double[] temperatures = new double[numberOfTemperatures];
double sum = 0;
bool gettingWarmer = true;
bool gettingCooler = true;

// Input temperatures with validation
for (int i = 0; i < numberOfTemperatures; i++)
{
    double temp;
    bool isValid;
    do
    {
        Console.Write($"Enter temperature {i + 1} (must be between -30 and 130): ");
        isValid = double.TryParse(Console.ReadLine(), out temp) && temp >= -30 && temp <= 130;

        if (!isValid)
        {
            Console.WriteLine("Invalid temperature. Please reenter a value between -30 and 130.");
        }
    } while (!isValid);

    temperatures[i] = temp;
    sum += temp;

    // Compare current temperature with the previous one
    if (i > 0)
    {
        // If current one is less than previous one
        if (temperatures[i] <= temperatures[i - 1])
        {
            gettingWarmer = false;
        }
        if (temperatures[i] >= temperatures[i - 1])
        {
            gettingCooler = false;
        }
    }
}

Console.WriteLine();
// Check the order of temperatures and display the appropriate message
if (gettingWarmer)
{
    Console.WriteLine("Getting warmer");
}
else if (gettingCooler)
{
    Console.WriteLine("Getting cooler");
}
else
{
    Console.WriteLine("It's a mixed bag");
}

// Display the temperatures entered
    Console.WriteLine($"5-day Temperature [{string.Join(", ", temperatures)}]");


// Calculate and display the average temperature
double average = sum / numberOfTemperatures;
Console.WriteLine($"Average temperature: {average:F2} degrees");

