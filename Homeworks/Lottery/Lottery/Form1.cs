using System.Diagnostics;

namespace Lottery
{
    public partial class Form1 : Form
    {
        Lottery Lotto;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void numberadd_Click(object sender, EventArgs e)
        {


        }

        private void Lotto_Click(object sender, EventArgs e)
        {
            
            int nrlengthint = Convert.ToInt32(nrlength.Value);
            Lotto = new Lottery(45, nrlengthint);
            int[] Drawnnumbers = Lotto.DrawAllNumbers(nrlengthint);

            LotteryNumbers.Items.Clear();
            foreach (int i in Drawnnumbers) //LotteryNumber.Text doesnt work for listboxes. IDK why I had that idea that it would be so easy but it is not
            {
                LotteryNumbers.Items.Add(i.ToString());
            }
            
        }
    }
}
