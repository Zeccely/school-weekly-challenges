using RPS;






GameManager gameManager = new GameManager();

do
{
    Console.WriteLine();

    RoundResult roundResult = gameManager.PlayRound();
    Console.WriteLine($"{roundResult}!!!"); // DEBUG

    Console.WriteLine("Enter 'q' to quit. Press any other key to play again ...");
} while (Console.ReadKey(true).KeyChar != 'q');
