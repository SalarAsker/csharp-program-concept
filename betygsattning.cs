
/// I tried to write the program with minimum instructions as well as 
/// to maintain good readability.

/// Suggestion:
Console.Write($"A-poäng: ");
int a = int.Parse(Console.ReadLine());
Console.Write($"C-poäng: ");
int c = int.Parse(Console.ReadLine());
Console.Write($"E-poäng: ");
int e = int.Parse(Console.ReadLine());

string betyg = ""; // a single result-variable gonna change its value based on diffrent scenarios.

if (e == 10)
{
    betyg = "E";

    if (c >= 5)
    {
        betyg = "D";
    }

    if (c == 10)
    {
        betyg = "C";

        if (a >= 5)
        {
            betyg = "B";
        }
        if (a == 10) { betyg = "A"; }
    }

}

Console.WriteLine(betyg);
/// this program can be solved in several different ways. 