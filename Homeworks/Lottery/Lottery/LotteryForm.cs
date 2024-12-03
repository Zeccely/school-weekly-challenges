using System.Diagnostics;

namespace Lottery
{
    public partial class LotteryForm : Form
    {
        Lottery Lotto;
        List<int> chosennumber = new List<int>();
        int nrlengthint;
        List<int> Drawnnumbers;

        public LotteryForm()
        {
            InitializeComponent();
            //putting things in here is kind of a trap and honestly do not do it. also think about initialization of parts of code and what you want to set after or before it starts
         
            Debug.WriteLine("Anything");

        }
        private void numberadd_Click(object sender, EventArgs e)
        {
            
           
            if (chosennumber.Count < nrlengthint && choosenumbers.Value < 45)
            {

                chosennumber.Add(Convert.ToInt32(choosenumbers.Value));
                
            }
            else if (choosenumbers.Value > 45)
            {
                MessageBox.Show($"Number must be below {maxVal}. It is default 45");
            }
            else
            {
                MessageBox.Show("Thats enough slices!");
            }
            chosenview.Items.Clear();

            chosenview.Items.Add(string.Join(" ", chosennumber));
            Debug.WriteLine(string.Join(" ", chosennumber));
        }

        private void Lotto_Click(object sender, EventArgs e)
        {
            
            int[] chosenarray = chosennumber.ToArray(); //thanks intellisense
            Debug.WriteLine(string.Join($"The Numbers are: {Drawnnumbers}"));
            foreach (int numba in Drawnnumbers) //LotteryNumber.Text doesnt work for listboxes. IDK why I had that idea that it would be so easy but it is not
            {
                
                LotteryNumbers.Items.Add(numba.ToString());
                Debug.WriteLine($"{numba}");

            }

            if (chosenarray.Length != nrlengthint)
            {
                MessageBox.Show("Choose the required amount of numbers");
                return;
            }
            
           

            if (Drawnnumbers.SequenceEqual(chosenarray))
            {
                MessageBox.Show("You won");
            }
            else
            {
                MessageBox.Show("You lose, duh");
            }

            
        }

        private void settingsSave_Click(object sender, EventArgs e)
        {
            nrlengthint = Convert.ToInt32(nrlength.Value);
            Lotto = new Lottery(45, nrlengthint);
            Drawnnumbers = Lotto.DrawAllNumbers(nrlengthint);

        }
    }
}
