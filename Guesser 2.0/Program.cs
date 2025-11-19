

using Guesser_2._0;
Engine engine = new Engine();

while (Console.ReadKey(true).Key == ConsoleKey.Escape)
{
    
    FileProvider fileProvider = new FileProvider();
    int maxNumber = fileProvider.LoadNumber("Z:\\Mause\\txt");
    Randomizer randomizer = new Randomizer(maxNumber);
    int randomNumber = randomizer.Random();


    

    engine.Do( randomNumber);

   


}
