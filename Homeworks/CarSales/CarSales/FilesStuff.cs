using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Text.Json;


namespace CarSales
{
    internal class FilesStuff
    {
        Dealership dealershipinfo;
        public FilesStuff(Dealership dealership) 
        {
            dealershipinfo = dealership;
        }

        public Dealership Dealership
        {
            get => default;
            set
            {
            }
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
        public void SaveAllDataJson() // this needs to closed and be debugged, it doesnt work. maybe a fs was necessary
        {
            string filepath;
            string jsonstring = JsonSerializer.Serialize(dealershipinfo);
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;

            SaveFileDialog saver = new SaveFileDialog();
            if (saver.ShowDialog() == DialogResult.OK)
            {
                filepath = saver.FileName;
                File.WriteAllText(filepath, jsonstring);
                
            }
            

        }

        public void LoadAllDataJson()
        {
            string filepath;
            
            OpenFileDialog opener = new OpenFileDialog();
            if(opener.ShowDialog() == DialogResult.OK)
            {
                filepath = opener.FileName;
                var info = File.ReadAllText(filepath);
                Dealership dealership = JsonSerializer.Deserialize<Dealership>(info);
            }
            //needs to close
        }

        public Dealership GetDealershipinfo() 
        { 
            return dealershipinfo; 
        }


    }
}
