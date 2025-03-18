namespace RPS;

public class GameManager
{
    private IPlayer _player1;
    private IPlayer _player2;
   // List<IPlayer> _players = [new PlayerHuman(), new PlayerComputer()]; //the class depends on this so this is violating the principle
   public GameManager(IPlayer player1, IPlayer player2)
    {
        _player1 = player1;
        _player2 = player2;
    }

    public RoundResult PlayRound() //get choices from IPlayer
    {
        Choice _player1.MakeChoice();
        Choice _player2.MakeChoice();

       // Choice choiceP1 = _players[0].MakeChoice(); violating
       // Choice choiceP2 = _players[1].MakeChoice(); violating
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
