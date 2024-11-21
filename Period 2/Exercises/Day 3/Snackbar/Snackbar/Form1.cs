namespace Snackbar
{
    public partial class Form1 : Form
    {
        SnackBar ShnackyWhacky = new SnackBar();

        public Form1()
        {
            InitializeComponent();
        }

        private void shancks_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Snack> snacks = new List<Snack>();
            Snack loempia = new Snack()
        }

        private void shnackViewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void orderedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalDue_Click(object sender, EventArgs e)
        {

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            ShnackyWhacky.ProcessOrder();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void adminView_Click(object sender, EventArgs e)
        {

        }
    }
}
