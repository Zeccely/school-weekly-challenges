namespace Classexample2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void orderDrink_Click(object sender, EventArgs e)
        {
            if (adultOrNot.Checked == false && drinkSelector.SelectedIndex == 4)
            {
                MessageBox.Show("You must be 18 years or older to order this");
            }
            else
            {
                MessageBox.Show("Enjoy your drink!");
            }

        }

        private void adultOrNot_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void drinkSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (drinkSelector.SelectedIndex == 0 || drinkSelector.SelectedIndex == 1 || drinkSelector.SelectedIndex == 2)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\jepis\Desktop\School stuff\school-weekly-challenges\Period 2\Classexample2.1\Classexample2.1\Resources\cola_fanta_sprite1.jpg");
            }
            else if (drinkSelector.SelectedIndex == 3)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\jepis\Desktop\School stuff\school-weekly-challenges\Period 2\Classexample2.1\Classexample2.1\Resources\images1.jpg");
            }
            else if (drinkSelector.SelectedIndex == 4)
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\jepis\Desktop\School stuff\school-weekly-challenges\Period 2\Classexample2.1\Classexample2.1\Resources\tequila1.jpg");
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile(@"C:\Users\jepis\Desktop\School stuff\school-weekly-challenges\Period 2\Classexample2.1\Classexample2.1\Resources\drinks1.jpg");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
