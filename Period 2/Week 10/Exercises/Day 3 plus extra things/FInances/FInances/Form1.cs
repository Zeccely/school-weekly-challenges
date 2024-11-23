using System.Drawing.Text;

namespace FInances
{
    public partial class Form1 : Form
    {
    
        private ExpenseManager manager = new ExpenseManager();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void expenseAdder_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense(expenseName.Text , Convert.ToDouble(expenseCost.Value)); //WHATS WRONG WITH PARSEEE??????
            manager.AddExpense(expense);
            MessageBox.Show(" Yay ");
        }

        private void allExpenses_Click(object sender, EventArgs e)
        {
            overviewer.Items.Clear();
            foreach (Expense expense in manager.GetExpenseList()) 
            {
                overviewer.Items.Add(expense.ExpenseString());
            }
            //string adder = $"{this._name} - {this._amount}";
        }

        private void sameTypeExpense_Click(object sender, EventArgs e)
        {
            overviewer.Items.Clear();
            foreach (Expense expense in manager.GetSameAmount(Convert.ToDouble(sameAmountNM.Value)))
            {
                overviewer.Items.Add(expense.ExpenseString());
            }
        }

        private void expenseName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void expenseCost_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void overviewer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
