Console.WriteLine("chose,buddy");
int stage = int.Parse(Console.ReadLine());
if (stage == 1)
{

    Console.WriteLine("Calculation time!");


    Console.WriteLine("Select the first number");
    decimal number1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Select: +, -, *, /, % ?");
    string? sucetselection = Console.ReadLine();

    Console.WriteLine("Now, select the second number");
    decimal number2 = decimal.Parse(Console.ReadLine());

    decimal vysledok = 0;

    switch (sucetselection)
    {
        case "+":
            vysledok = number1 + number2;
            break;

        case "-":
            vysledok = number1 - number2;
            break;

        case "*":
            vysledok = number1 * number2;
            break;

        case "/":
            if (number2 == 0)
            {
                Console.WriteLine("error");
                break;
            }
            vysledok = number1 / number2;
            break;

        case "%":
            vysledok = number1 % number2;
            break;

        default:
            Console.WriteLine("Operacion is unknowed");
            break;
    }
    Console.WriteLine($"It's " + vysledok);

}
else if (stage == 2)
{
    Console.WriteLine("Number to text time!");

    decimal number = int.Parse(Console.ReadLine());

    string numberDescription = number switch
    {
        1 => "one",
        2 => "two",
        3 => "three",
        4 => "four",
        _ => "NEIN!!!"

    };
    Console.WriteLine(numberDescription);
}







