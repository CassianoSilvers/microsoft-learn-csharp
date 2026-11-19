using System.Globalization;

// Collect the bill amount and tip percentage
Console.WriteLine("Enter your bill details:\n");
Console.Write("Bill amount: ");
decimal billAmount = decimal.Parse(Console.ReadLine()!);
Console.Write("Tip percentage: ");
decimal tipPercentage = decimal.Parse(Console.ReadLine()!);

// Round the tip to cents and calculate the total
decimal tipAmount = Math.Round(billAmount * (tipPercentage / 100), 2);
decimal totalAmount = billAmount + tipAmount;

// Compare the current total with an example previous total
decimal previousTotal = 40.00m;
decimal higherTotal = Math.Max(totalAmount, previousTotal);

// Display amounts in US dollars
CultureInfo dollarCulture = CultureInfo.GetCultureInfo("en-US");
Console.WriteLine("\nBill details:");
Console.WriteLine($"Bill amount: {billAmount.ToString("C", dollarCulture)}");
Console.WriteLine($"Tip percentage: {tipPercentage}%");
Console.WriteLine($"\nTip amount: {tipAmount.ToString("C", dollarCulture)}");
Console.WriteLine($"Total amount: {totalAmount.ToString("C", dollarCulture)}");
Console.WriteLine($"Previous total: {previousTotal.ToString("C", dollarCulture)}");
Console.WriteLine($"Higher total: {higherTotal.ToString("C", dollarCulture)}");
