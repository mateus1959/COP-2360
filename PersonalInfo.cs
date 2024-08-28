using System;

class PersonalInfo
{
    public static void Main(string[] args)
    {
        string name = "Lucinda Potter";  
        string birthDate = "6/24/1992";
        string workPhone = "work 000-000-0101";
        string cellPhone = "cell 000-000-0189";
        Display(name, birthDate, workPhone, cellPhone);

        name = "John Smith";
        birthDate = "8/15/1978";
        workPhone = "work 000-111-0101";
        cellPhone = "cell 000-111-0189";
        Display(name, birthDate, workPhone, cellPhone);

        name = "Chris Johnson";
        birthDate = "12/01/1987";
        workPhone = "work 000-222-0101";
        cellPhone = "cell 000-222-0189";
        Display(name, birthDate, workPhone, cellPhone);

        name = "Robert Hall";
        birthDate = "2/27/1949";
        workPhone = "work 000-444-0101";
        cellPhone = "cell 000-444-0189";
        Display(name, birthDate, workPhone, cellPhone);
    }

    public static void Display(string name, string birthDate, string workPhone, string cellPhone) {
        Console.WriteLine(name);
        Console.WriteLine(birthDate);
        Console.WriteLine(workPhone);
        Console.WriteLine(cellPhone);
    }

    
}