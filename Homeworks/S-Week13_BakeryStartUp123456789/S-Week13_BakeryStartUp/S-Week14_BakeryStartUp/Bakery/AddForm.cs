using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class AddForm : Form
    {
        BreadShop bakery;
        List<Ingredient> ingredientsList;
        Sandwich sandwichy;
        public AddForm(BreadShop b)
        {

            InitializeComponent();
            BreadFilter.DataSource = Enum.GetValues(typeof(BreadType));
            this.bakery = b;
            ingredientsList = bakery.GetAvailableIngredients();
            Debug.WriteLine(ingredientsList);
            foreach (Ingredient i in ingredientsList)
            {
                ingredients.Items.Add(i); 
            }


        }

        public void BreadAdder_Click(object sender, EventArgs e)
        {
            int counterbefore = bakery.GetAvailableSandwiches().Count;
            string sandoName = (sandwichName.Text.ToString());
            double sandoPrice = 4;
            BreadType typeFilter = (BreadType)BreadFilter.SelectedItem;

            sandwichy = new Sandwich(sandoName, sandoPrice, typeFilter);
            Debug.WriteLine(sandwichy);
            this.bakery.AddSandwitch(sandwichy);
            int counterafter = bakery.GetAvailableSandwiches().Count;
            if (counterbefore < counterafter)
            {
                confirmationlbl.Text = "Sandwich Added Successfully!";
            }
            else if (counterbefore > counterafter)
            {
                confirmationlbl.Text = "Sandwich Removed Successfully?";
            }
            else
            {
                confirmationlbl.Text = "How?";
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RemoveBtn_Click(object sender, EventArgs e) //only works if you don't close this form
        {
            int counterbefore = bakery.GetAvailableSandwiches().Count;
            string sandoName = (sandwichName.Text.ToString());           
            BreadType typeFilter = (BreadType)BreadFilter.SelectedItem;          
            this.bakery.RemoveSandwich(sandwichy);
            int counterafter = bakery.GetAvailableSandwiches().Count;
            if (counterbefore > counterafter)
            {
                confirmationlbl.Text = "Sandwich Removed Successfully!";
            }
            else
            {
                confirmationlbl.Text = "Couldn't remove, make sure the name is the same. If all else fails contact Jessica";
            }
        }
    }
}
