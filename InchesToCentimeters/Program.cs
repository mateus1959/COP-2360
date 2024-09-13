// See https://aka.ms/new-console-template for more information

const double CentimetersPerInch = 2.54;
Console.Write("Enter the number of inches: ");
double inches = Convert.ToDouble(Console.ReadLine());
double centimeters = inches * CentimetersPerInch;
Console.WriteLine($"{inches} inches is {centimeters} centimeters.");





