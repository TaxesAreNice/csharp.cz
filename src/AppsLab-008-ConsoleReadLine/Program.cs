

















Console.WriteLine("Calculation time!");


Console.WriteLine("Select the first number");
string? number1 = Console.ReadLine();

Console.WriteLine("Now, select the second number");
string? number2 = Console.ReadLine();

Console.WriteLine("+, -, *, / ?");
string? sucetselection = Console.ReadLine();



//skus swich

if (sucetselection == "+")

{
    int sucet = int.Parse(number1) + int.Parse(number2);

    Console.WriteLine($"It's " + sucet);
}
else if (sucetselection == "-")

{
    int sucet = int.Parse(number1) - int.Parse(number2);

    Console.WriteLine($"It's " + sucet);
}
else if (sucetselection == "*")

{
    int sucet = int.Parse(number1) * int.Parse(number2);

    Console.WriteLine($"It's " + sucet);
}
else if (sucetselection == "/")

{
    int sucet = int.Parse(number1) / int.Parse(number2);

    Console.WriteLine($"It's " + sucet);
}

