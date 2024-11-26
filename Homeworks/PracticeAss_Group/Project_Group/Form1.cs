using System.Drawing.Drawing2D;
using System.Drawing.Text;

namespace Project_Group
{
    public partial class Form1 : Form
    {
       
        
        int inputNum = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
            
        private void groupShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        public void adder_Click(object sender, EventArgs e)
        {
            Member membernonr;
            Member memberwithnr;
            string inputName = nameInput.Text;
            Project_Group Project = new Project_Group(inputName);
            membernonr = new Member(inputName);
            memberwithnr = new Member(inputName, inputNum);

            if (int.TryParse(studentNUM.Text, out inputNum)) //int inputNum = int.TryParse(studentNUM out inputnum);
            {
                System.Diagnostics.Debug.WriteLine(inputNum);
            }
            else
            {
                MessageBox.Show("Numbers are not letters or whatever craziness you wrote");
            }



            string thing = memberwithnr.GetInfo();
            string thing2 = membernonr.GetInfo();


            if (string.IsNullOrEmpty(nameInput.Text) && string.IsNullOrEmpty(studentNUM.Text) ) //took advantage of intellisense
            {
                MessageBox.Show("Please atleast add something");
            }
            else if (!string.IsNullOrEmpty(studentNUM.Text) && string.IsNullOrEmpty(nameInput.Text))
            {
                MessageBox.Show("Doesn't this person have a name?");
            }
            else if (!string.IsNullOrEmpty(studentNUM.Text) && !string.IsNullOrEmpty(nameInput.Text))
            {
                groupShow.Items.Add(thing);
            }
            else
            {
                groupShow.Items.Add(thing2);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
