using System.Diagnostics;

namespace Snackbar
{
    public partial class Form1 : Form
    {
        SnackBar ShnackyWhacky = new SnackBar();
        public static List<string> orderlist = new List<string>();
        public Form1()
        {
            InitializeComponent();
            
        }
        public List<string> GetList()
        {
            return orderlist;
        }

        private void orderedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalDue_Click(object sender, EventArgs e)
        {
            
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            double gottapaystill =  ShnackyWhacky.ProcessOrder(Convert.ToDouble(loempiaNR.Value), Convert.ToDouble(KaasNR.Value), Convert.ToDouble(MexiNR.Value)); //WHY NO PARSE
            
            totalDue.Text = gottapaystill.ToString();


            orderedItems.Items.Clear();
            orderedItems.Items.Add($" Loempia  {loempiaNR.Value}");
            orderedItems.Items.Add($" Kaastengel  {KaasNR.Value}");
            orderedItems.Items.Add($" Mexicano  {MexiNR.Value}");

            if (loempiaNR.Value == 0 && KaasNR.Value == 0 && MexiNR.Value == 0)
            {
                MessageBox.Show("Buy something will you?");
            }
            else
            {
              
                orderlist.Add($"Total Loempia: {loempiaNR.Value}");
                orderlist.Add($"Total Kaastengels: {KaasNR.Value}");
                orderlist.Add($"Total Mexicano: {MexiNR.Value}");
            }
            Debug.WriteLine(orderlist);
            //foreach (Snack x in ShnackyWhacky.snackList)   //If snacklist belongs to an instance of SnackBar you gotta use ShnackyWhacky.SnackList instead
            //{
            //    orderedItems.Items.Add($"{x.GetName()} + {loempiaNR.Value}");
            //} 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderedItems.Items.Clear();
            totalDue.Text = string.Empty;
            
        }

        private void adminView_Click(object sender, EventArgs e)
        {
            AdminView adminViewer = new AdminView();
            adminViewer.Show();
        }

        private void loempiaNR_ValueChanged(object sender, EventArgs e)
        {

        }

        private void KaasNR_ValueChanged(object sender, EventArgs e)
        {

        }

        private void MexiNR_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
