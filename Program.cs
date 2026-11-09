
int big = int.MaxValue;
Console.WriteLine(big);
big++;
Console.WriteLine(big);
Console.Write("What is the bill total? ");
if (!decimal.TryParse(Console.ReadLine(), out decimal billSubTotal) || billSubTotal <= 0)
{
    Console.WriteLine("Bill total must be a positive number, like 67.67.");
    return;
}



Console.Write("What percentage is the tip? ");
if (!decimal.TryParse(Console.ReadLine(), out decimal tipPercent) || tipPercent < 0)
{
    Console.WriteLine("Percentage must be a positive number, like 5.3.");
    return;
}



Console.Write("How many people are splitting the bill? ");
if (!int.TryParse(Console.ReadLine(), out int numPeople) || numPeople <= 0)
{
    Console.WriteLine("Number of guests must be zero or more.");
    return;
}


decimal tipAmount = billSubTotal * tipPercent / 100;
decimal billTotal = billSubTotal + tipAmount;
decimal splitTotal = billTotal / numPeople;
Console.WriteLine($"Tip amount: {tipAmount:C}");
Console.WriteLine($"Total bill: {billTotal:C}");
Console.WriteLine($"Each person pays: {splitTotal:C}");



