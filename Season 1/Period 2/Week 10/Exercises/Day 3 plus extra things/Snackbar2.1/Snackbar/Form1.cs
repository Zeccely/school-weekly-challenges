using System.Diagnostics;

namespace Snackbar
{
    public partial class Form1 : Form
    {
        SnackBar ShnackyWhacky = new SnackBar();
        public Dictionary<string, Snack> SnackDict = new Dictionary<string, Snack>();
        public static Dictionary<string,decimal> orderlist = new Dictionary<string,decimal>();
        

        public Form1()
        {
            InitializeComponent();
            orderlist.Add("Total Loempia", 0);
            orderlist.Add("Total Kaastengels", 0);
            orderlist.Add("Total Mexicano", 0);
        }

        private void orderedItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void totalDue_Click(object sender, EventArgs e)
        {
            
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            double gottapaystill =  ShnackyWhacky.ProcessOrder(Convert.ToDouble(loempiaNR.Value), Convert.ToDouble(KaasNR.Value), Convert.ToDouble(MexiNR.Value)); //its a decimal so no parse
            
            totalDue.Text = gottapaystill.ToString();


            orderedItems.Items.Clear();
            orderedItems.Items.Add($" Loempia {loempiaNR.Value}");
            orderedItems.Items.Add($" Kaastengel  {KaasNR.Value}");
            orderedItems.Items.Add($" Mexicano  {MexiNR.Value}");

            if (loempiaNR.Value == 0 && KaasNR.Value == 0 && MexiNR.Value == 0)
            {
                MessageBox.Show("Buy something will you?");
            }
            else
            {
                ShnackyWhacky.snackDict["Snack1"].DecreaseStock(Convert.ToDouble(loempiaNR.Value));
                ShnackyWhacky.snackDict["Snack2"].DecreaseStock(Convert.ToDouble(KaasNR.Value));
                ShnackyWhacky.snackDict["Snack3"].DecreaseStock(Convert.ToDouble(MexiNR.Value));

                orderlist["Total Loempia"] = orderlist["Total Loempia"] + loempiaNR.Value;    //i=i+1. we increment
                orderlist["Total Kaastengels"] = orderlist["Total Kaastengels"] + KaasNR.Value;
                orderlist["Total Mexicano"] = orderlist["Total Mexicano"] + MexiNR.Value;

            } //this is super annoying. I have no idea how to relate the snackdict to the form itself or how to use it for the admin view
            //THIS TASK BROKE ME PLEASE DON'T DO THAT AGAIN

            Debug.WriteLine(string.Join(" ", orderlist));
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orderedItems.Items.Clear();
            totalDue.Text = string.Empty;
            
        }

        private void adminView_Click(object sender, EventArgs e)
        {
            Dictionary<string,Snack> salt2 = ShnackyWhacky.snackDict;
            Dictionary<string,decimal> salt = orderlist;
            AdminView adminViewer = new AdminView(salt);
            adminViewer.Show();

            Debug.WriteLine(string.Join(" ",salt));
            
        }
    }
}
