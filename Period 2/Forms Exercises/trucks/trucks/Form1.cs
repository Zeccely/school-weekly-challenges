namespace trucks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maxPalletA_TextChanged(object sender, EventArgs e)
        {
            maxPalletA.Text = "20";
        }

        private void maxBoxA_TextChanged(object sender, EventArgs e)
        {
            maxBoxA.Text = "50";
        }

        private void maxPalletB_TextChanged(object sender, EventArgs e)
        {
            maxPalletB.Text = "30";
        }

        private void maxBoxB_TextChanged(object sender, EventArgs e)
        {
            maxBoxB.Text = "50";
        }

        private void maxPalletC_TextChanged(object sender, EventArgs e)
        {
            maxPalletC.Text = "40";
        }

        private void maxBoxC_TextChanged(object sender, EventArgs e)
        {
            maxBoxC.Text = "50";
        }

        private void fullTruckNr_TextChanged(object sender, EventArgs e)
        {
            double result;
            if userBoxInput
        }

        private void fullPalletNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxRemain_TextChanged(object sender, EventArgs e)
        {

        }

        private void palletRemain_TextChanged(object sender, EventArgs e)
        {

        }

        private void userBoxes_TextChanged(object sender, EventArgs e)
        {
            double userBoxInput = double.Parse(Console.ReadLine());
        }
    }
}
