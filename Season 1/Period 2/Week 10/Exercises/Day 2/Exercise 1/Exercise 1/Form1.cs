namespace Exercise_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            this.progressBar1.Value = this.trackBar1.Value;
            this.label1.Text = this.trackBar1.Value.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void redmaker_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void pinkMaker_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void greenMaker_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
