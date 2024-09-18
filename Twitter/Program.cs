// Accept a user’s message
Console.Write("Enter your message: ");
string msg = Console.ReadLine();
const int maxLength = 140;

// Check if the message length exceeds the maximum allowed length
if (msg.Length > maxLength)
{
    Console.WriteLine("Rejected");
}
else
{
    Console.WriteLine("Posted");
}
