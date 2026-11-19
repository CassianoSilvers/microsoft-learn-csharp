// Collect the bill amount and tip percentage

//decimal billAmount = 45.50m;
//decimal tipPercentenge = 18.0m;

Console.WriteLine("Enter your bill details:\n");
Console.Write("Bill amount:  ");
decimal billAmount = decimal.Parse(Console.ReadLine());
Console.Write("Tip percentage:  ");
decimal tipPercentage = decimal.Parse(Console.ReadLine());

 // Display the entered values

Console.WriteLine("Bill details: ");
Console.WriteLine($"Bill amount: ${billAmount}");
Console.WriteLine($"Tip percentage: {tipPercentage}%");

 // Calculate the tip and total

decimal tipAmount = billAmount * (tipPercentage / 100);
decimal totalAmount = billAmount + tipAmount;

 // Display the results
 Console.WriteLine($"\nTip amount: ${tipAmount}");
 Console.WriteLine($"\nTotal amount: ${totalAmount}");
