// Initialize variables to hold the sales totals for each salesperson
double danielleSales = 0, edwardSales = 0, francisSales = 0, grandTotal = 0;
char initial;

do
{
    // Prompt the user for the salesperson's initial
    Console.WriteLine("Enter the salesperson's initial (D, E, or F) or Z to quit:");
    initial = Char.ToUpper(Console.ReadKey().KeyChar);  // Read and convert to uppercase
    Console.WriteLine();  // Move to the next line after key press
    
    // Check if the user entered Z to quit
    if (initial == 'Z')
    {
        break;
    }

    // Validate the initial and prompt for sale amount if valid
    if (initial == 'D' || initial == 'E' || initial == 'F')
    {
        Console.WriteLine("Enter the amount of the sale:");
        double saleAmount;
        
        // Validate if the input is a valid number
        if (double.TryParse(Console.ReadLine(), out saleAmount) && saleAmount > 0)
        {
            // Add the sale to the respective salesperson's total
            switch (initial)
            {
                case 'D':
                    danielleSales += saleAmount;
                    break;
                case 'E':
                    edwardSales += saleAmount;
                    break;
                case 'F':
                    francisSales += saleAmount;
                    break;
            }

            // Add to grand total
            grandTotal += saleAmount;
        }
        else
        {
            Console.WriteLine("Invalid sale amount. Please enter a positive number.");
        }
    }
    else
    {
        Console.WriteLine("Invalid initial. Please enter D, E, F, or Z to quit.");
    }

} while (initial != 'Z');

// Display the totals for each salesperson
Console.WriteLine($"\nSales Totals:");
Console.WriteLine($"Salesperson D: {danielleSales:C}");
Console.WriteLine($"Salesperson E: {edwardSales:C}");
Console.WriteLine($"Salesperson f: {francisSales:C}");
Console.WriteLine($"Grand Total Sales: {grandTotal:C}");

// Determine and display the salesperson with the highest sales
if (danielleSales > edwardSales && danielleSales > francisSales)
{
    Console.WriteLine("Highest Sale: D");
}
else if (edwardSales > danielleSales && edwardSales > francisSales)
{
    Console.WriteLine("Highest Sale: E");
}
else if (francisSales > danielleSales && francisSales > edwardSales)
{
    Console.WriteLine("Highest Sale: F");
}
else
{
    Console.WriteLine("There was a tie for the highest sales.");
}

