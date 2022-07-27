// Dice Roll Simulator
#nullable disable
Console.Clear();

//Main Loop
while(true){
    //Menu
    Console.WriteLine("\nDice Roll Simulator Menu");
    Console.WriteLine("1. Roll Dice Once");
    Console.WriteLine("2. Roll Dice 5 Times");
    Console.WriteLine("3. Roll Dice 'n' Times");
    Console.WriteLine("4. Roll Dice until Snake Eyes");
    Console.WriteLine("5. Exit");
    Console.Write("Select an option (1-5): ");
    int option = Convert.ToInt32(Console.ReadLine());
    // create new rand obj
    Random rnd = new Random();

    //Process
    if (option == 1) {
        int dice1 = rnd.Next(1,7);
        int dice2 = rnd.Next(1,7);
        Console.WriteLine($"{dice1},{dice2} (sum: {dice1+dice2})");
    } else if (option == 2) {
        for (int i=0;i<5;i++){
        int dice1 = rnd.Next(1,7);
        int dice2 = rnd.Next(1,7);
        Console.WriteLine($"{dice1},{dice2} (sum: {dice1+dice2})");
        }
    } else if (option == 3) {
        Console.Write("What Number?: ");
    int loopVar = Convert.ToInt32(Console.ReadLine());
        for (int i = 0;i<loopVar;i++){
        int dice1 = rnd.Next(1,7);
        int dice2 = rnd.Next(1,7);
        Console.WriteLine($"{dice1},{dice2} (sum: {dice1+dice2})");
        }
    } else if (option == 4) {
        int loopVal = 0; 
        while (true) {
        int dice1 = rnd.Next(1,7);
        int dice2 = rnd.Next(1,7);
        Console.WriteLine($"{dice1},{dice2} (sum: {dice1+dice2})");
        loopVal++;
        if (dice1 == 1 && dice2 == 1){
        Console.WriteLine($"\nSNAKE EYES! IT took {loopVal} rolls to get snake eyes.");
            break;
        }
        }
    } else if (option == 5){
        Console.WriteLine("\nGoodbye");
        break;
    } else {
        Console.WriteLine("\nPlease Submit a Valid Number");
    }
}
