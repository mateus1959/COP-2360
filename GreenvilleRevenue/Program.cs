int lastYearContestants, thisYearContestants;
int choice;
const int TICKET_PRICE = 25;

do
{
    Console.WriteLine("Please Enter the following number below from the following menu:");
    Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
    Console.WriteLine("2. Exit");

    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            // Input last year's and this year's number of contestants
            Console.Write("Enter the number of contestants last year: ");
            lastYearContestants = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of contestants this year: ");
            thisYearContestants = int.Parse(Console.ReadLine());

            // Calculate the revenue expected this year
            int revenue = thisYearContestants * TICKET_PRICE;

            // Output the comparison and revenue
            Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
            Console.WriteLine($"Revenue expected this year is ${revenue}.");
            Console.WriteLine($"It is {(thisYearContestants > lastYearContestants ? "true" : "false")} that this year's competition is bigger than last year's.\n");

            // Display the stars
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************\n");
            break;

        case 2:
            Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
            break;

        default:
            Console.WriteLine("Invalid choice. Please select 1 or 2.");
            break;
    }

} while (choice != 2);

