namespace RPS;

public class GameManager: IPlayer
{
    private Random rnd = new Random();

    public Choice MakeChoice()
    {
        choiceP1 = 
    }

    public RoundResult PlayRound() //get choices from IPlayer
    {
        if (choiceP1 == choiceP2)
        {
            return RoundResult.Draw;
        }
        else if (
                    choiceP1 == Choice.Rock && choiceP2 == Choice.Scissors ||
                    choiceP1 == Choice.Paper && choiceP2 == Choice.Rock ||
                    choiceP1 == Choice.Scissors && choiceP2 == Choice.Paper
                 )
        {
            return RoundResult.Player1Wins;
        }
        else
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
