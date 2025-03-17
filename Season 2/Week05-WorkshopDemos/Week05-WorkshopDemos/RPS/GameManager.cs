namespace RPS;

public class GameManager
{
    private Random rnd = new Random();

    public RoundResult PlayRound()
    {
        // Player 1 (Human)
        char input;
        do
        {
            Console.WriteLine("Enter choice: Rock (1), Paper (2), Scissors (3)");
            input = Console.ReadKey(true).KeyChar;
        } while ( input < '1' || input > '3');
        Choice choiceP1 = (Choice)char.GetNumericValue(input);
        Console.WriteLine($"P1 chose {choiceP1}"); // DEBUG

        // Player 2 (Computer)
        Choice choiceP2 = (Choice)rnd.Next(1, 4);
        Console.WriteLine($"P2 chose {choiceP2}"); // DEBUG

        // Game logic
        if(choiceP1 == choiceP2)
        {
            return RoundResult.Draw;
        } else if(
                    choiceP1 == Choice.Rock && choiceP2 == Choice.Scissors ||
                    choiceP1 == Choice.Paper && choiceP2 == Choice.Rock ||
                    choiceP1 == Choice.Scissors && choiceP2 == Choice.Paper
                 )
        {
            return RoundResult.Player1Wins;
        } else
        {
            return RoundResult.Player2Wins;
        }
    }
}

public enum Choice
{
    Rock = 1,
    Paper,
    Scissors
}

public enum RoundResult
{
    Player1Wins,
    Player2Wins,
    Draw
}
