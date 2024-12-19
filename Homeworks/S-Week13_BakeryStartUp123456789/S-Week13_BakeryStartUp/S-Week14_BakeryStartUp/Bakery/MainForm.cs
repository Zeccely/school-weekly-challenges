using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Xml;

namespace Bakery
{
    public partial class MainForm : Form
    {
        BreadShop bakery = new BreadShop("Bakary");
        double total;
        
        public MainForm()
        {
            InitializeComponent();

            // Init GUI
            lblSandwichInfo.Text = String.Empty;
            BreadFilterdrp.DataSource = Enum.GetValues(typeof(BreadType));
        }

        private void btnShowOfferedSandwiches_Click(object sender, EventArgs e) //use the overloaded methods to take the sandwich list and display it
        {


            SMenu.Items.Clear();

            Debug.WriteLine(bakery.GetAvailableSandwiches());

            foreach (Sandwich s in this.bakery.GetAvailableSandwiches())
            {
                SMenu.Items.Add(s);
            }



        }

        private void AddSandwich_Click(object sender, EventArgs e)
        {
            AddForm BreadAddForm = new AddForm(this.bakery);
            BreadAddForm.Show();
        }


        private void Load_Click(object sender, EventArgs e)
        {
            string filename;

            FileStream fs = null;
            OpenFileDialog opener = new OpenFileDialog();

            if (opener.ShowDialog() == DialogResult.OK)
            {
                filename = opener.FileName;

                try
                {
                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    Type BreadShop = typeof(BreadShop);
                    List<Type> auxiliaryType = new List<Type>() { typeof(Sandwich), typeof(Ingredient) };
                    DataContractSerializer dcs = new DataContractSerializer(BreadShop, auxiliaryType);
                    bakery = (BreadShop)dcs.ReadObject(reader);
                }
                catch (IOException)
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("You closed it");
            }

        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            string filename;
            FileStream? fs = null;
            SaveFileDialog saver = new SaveFileDialog();

            if (saver.ShowDialog() == DialogResult.OK)
            {
                filename = saver.FileName;
                try
                {
                    fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    Type BreadShop = typeof(BreadShop);
                    DataContractSerializer dcs = new DataContractSerializer(typeof(BreadShop));
                    dcs.WriteObject(fs, bakery);



                }
                catch (IOException)
                {
                    MessageBox.Show("Error");
                }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Canceled");
            }
        }

        private void BreadFilterdrp_SelectedIndexChanged(object sender, EventArgs e)
        {
            BreadType typeFilter = (BreadType)BreadFilterdrp.SelectedItem;
            SMenu.Items.Clear();
            List<Sandwich> sandwichdisplay = new List<Sandwich>();
            sandwichdisplay = this.bakery.GetAvailableSandwiches(typeFilter);
            foreach (Sandwich s in sandwichdisplay)
            {
                SMenu.Items.Add(s);
            }

        }

        private void SMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

            Sandwich chosen = (Sandwich)SMenu.SelectedItem; 
            lblSandwichInfo.Text = chosen.ToString();
        }

        private void SellSandwhich_Click(object sender, EventArgs e) //PAY ATTENTION HERE
        {
            
            if (bakery.GetAvailableSandwiches().Contains(SMenu.SelectedItem))
            {
                Sandwich sandwich = (Sandwich)SMenu.SelectedItem;
                bakery.SellSandwich(sandwich);
                total += sandwich.GetRevenue();
            }
            else
            {
                MessageBox.Show("Where Sammich?");
            }

            SMenu.Items.Clear();
            var soldcounterie = bakery.GetSoldSandwich().Count;
            soldcounter.Text = soldcounterie.ToString();
            Debug.WriteLine($"Sold stuff {soldcounterie}");
        }

        private void TotalRevenue_Click(object sender, EventArgs e)
        {

            revenuelbl.Text = total.ToString();

        }
    }
}
