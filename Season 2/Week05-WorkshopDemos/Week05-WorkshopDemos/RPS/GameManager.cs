namespace RPS;

public class GameManager
{
    List<IPlayer> _players = [new PlayerHuman(), new PlayerComputer()];

    public RoundResult PlayRound() //get choices from IPlayer
    {
        Choice choiceP1 = _players[0].MakeChoice();
        Choice choiceP2 = _players[1].MakeChoice();
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
