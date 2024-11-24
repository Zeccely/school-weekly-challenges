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

namespace Snackbar
{
    public partial class AdminView : Form
    {
        Dictionary<string, decimal> pepper = new Dictionary<string, decimal>();
        Dictionary<string, Snack> pepper2 = new Dictionary<string, Snack>();

        public AdminView(Dictionary<string, decimal> listy)
        {
            InitializeComponent();
            this.pepper = listy;
        }
        public AdminView(Dictionary<string, Snack> dicty)
        {
            this.pepper2 = dicty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void totalItems_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void calculate_Click(object sender, EventArgs e) //trying to show total items bought for loempia kaastengel and mexicano
        {
            Debug.WriteLine(string.Join(", ", pepper));

            totalItems.Items.Clear();
            foreach (KeyValuePair<string, decimal> item in pepper)
            {
                totalItems.Items.Add($"{item.Key} {Convert.ToDouble(item.Value)}");



            }
            double revenueLoempia = 2 * Convert.ToDouble(pepper["Total Loempia"]);
            double revenueKaastengel = 5 * Convert.ToDouble(pepper["Total Kaastengels"]);
            double revenueMexi = 3 * Convert.ToDouble(pepper["Total Mexicano"]);

            double grandtotal = revenueLoempia + revenueKaastengel + revenueMexi;
            grandtotaly.Text = grandtotal.ToString();


        }

        private void grandtotal_Click(object sender, EventArgs e)
        {

        }
    }
}
