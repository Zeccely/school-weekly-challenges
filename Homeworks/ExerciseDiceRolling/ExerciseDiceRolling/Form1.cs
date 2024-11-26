namespace ExerciseDiceRolling
{
    public partial class Form1 : Form
    {
        
        Random randomness = new Random();
        List<int> dicelist = new List<int> {1, 2 , 3 , 4 , 5 , 6 };
        
        
        public Form1()
        {
            InitializeComponent();
        }

        
        private void diceRoller_Click(object sender, EventArgs e)
        {
            int randomthing = randomness.Next(0, dicelist.Count);  //so this is actually not the number guys! its the index of the number!
            int randomNum = dicelist[randomthing];   //I gotta pass the salt!
            DiceResult diceResultpopup = new DiceResult(randomNum);
            diceResultpopup.Show();
        }
    }
}
