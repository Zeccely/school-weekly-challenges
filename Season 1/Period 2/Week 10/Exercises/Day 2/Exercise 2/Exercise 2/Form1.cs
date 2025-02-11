
namespace Exercise_2


{
    public partial class Form1 : Form
    {
        double inputWeight;
        double inputHeight;

        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void height_TextChanged(object sender, EventArgs e)
        {
           inputHeight = double.Parse(heightIN.Text);
        }

        public void weight_TextChanged(object sender, EventArgs e)
        {
           inputWeight = double.Parse(weightIN.Text);
        }
        private void calculatebmi_Click(object sender, EventArgs e)
        {
            double BMI = inputHeight / (inputHeight * inputHeight);

        }
    }

}
