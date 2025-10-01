


Console.WriteLine("Calculation time!");


Console.WriteLine("Select the first number");
string? number1Text = Console.ReadLine();
decimal number1 = decimal.Parse(number1Text);

Console.WriteLine("Select: +, -, *, / ?");
string? sucetselection = Console.ReadLine();

Console.WriteLine("Now, select the second number");
string? number2Text = Console.ReadLine();
decimal number2 = decimal.Parse(number2Text);





//skus swich

if (sucetselection == "+")

{
    decimal sucet = number1 + number2;

    Console.WriteLine($"It's " + sucet);
}
else if (sucetselection == "-")

{
    decimal sucet = number1 - number2;

    Console.WriteLine($"It's " + sucet);
}
else if (sucetselection == "*")

{
    decimal sucet = number1 * number2;

    Console.WriteLine($"It's " + sucet);
}
else if (sucetselection == "/")

{
    decimal sucet = number1 / (decimal)number2;

    Console.WriteLine($"It's " + sucet);
}

