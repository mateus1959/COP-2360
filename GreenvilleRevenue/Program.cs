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
            // Input last year's number of contestants with validation
            do
            {
                Console.Write("Enter the number of contestants last year (0-30): ");
                lastYearContestants = int.Parse(Console.ReadLine());

                if (lastYearContestants < 0 || lastYearContestants > 30)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
                }
            } while (lastYearContestants < 0 || lastYearContestants > 30);

            // Input this year's number of contestants with validation
            do
            {
                Console.Write("Enter the number of contestants this year (0-30): ");
                thisYearContestants = int.Parse(Console.ReadLine());

                if (thisYearContestants < 0 || thisYearContestants > 30)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 30.");
                }
            } while (thisYearContestants < 0 || thisYearContestants > 30);

            // Calculate the revenue expected this year
            int revenue = thisYearContestants * TICKET_PRICE;

            // // Output the comparison and revenue
            // Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
            // Console.WriteLine($"Revenue expected this year is ${revenue}.");

            // Comparison messages
            if (thisYearContestants > 2 * lastYearContestants)
            {
                Console.WriteLine("The competition is more than twice as big this year!");
            }
            else if (thisYearContestants > lastYearContestants)
            {
                Console.WriteLine("The competition is bigger than ever!");
            }
            else
            {
                Console.WriteLine("A tighter race this year! Come out and cast your vote!");
            }

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
