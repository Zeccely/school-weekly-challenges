using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CarSales
{
    internal class FilesStuff
    {
        Dealership dealershipinfo;
        public FilesStuff(Dealership dealership) 
        {
            dealershipinfo = dealership;
        }
        public void SaveAllDataXML()
        {
            string filename;
            FileStream fs = null;
            SaveFileDialog saverAll = new SaveFileDialog();

            if (saverAll.ShowDialog() == DialogResult.OK)
            {
                filename = saverAll.FileName;
                try
                {
                    fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    Type Cardealership = typeof(Dealership);
                    DataContractSerializer dcs = new DataContractSerializer(typeof(Dealership));
                    dcs.WriteObject(fs, dealershipinfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
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
        public void LoadAllDataXML()
        {
            string filename;
            FileStream fs = null;
            OpenFileDialog saverAll = new OpenFileDialog();

            if (saverAll.ShowDialog() == DialogResult.OK)
            {
                filename = saverAll.FileName;
                try
                {
                    fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
                    XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());
                    Type Cardealership = typeof(Dealership);
                    List<Type> auxtype = new List<Type> { typeof(Car), typeof(CarSale), typeof(Customer) };
                    DataContractSerializer dcs = new DataContractSerializer(Cardealership, auxtype);
                    dealershipinfo = (Dealership)dcs.ReadObject(reader);

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
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
                MessageBox.Show("You canceled it");
            }



        }
        public void SaveAllDataJson()
        {
            string filepath;
            SaveFileDialog saver = new SaveFileDialog();
            if (saver.ShowDialog() == DialogResult.OK)
            {
                filepath = JsonConvert.SerializeObject(dealershipinfo.GetSoldCars());

            }


        }

        public void LoadAllDataJson()
        {
           




        }
    }
}
