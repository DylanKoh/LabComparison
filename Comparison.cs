using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;

namespace LabComparison
{
    //Initial Commit
    /// <summary>
    /// JT>
    /// - button1_Click not used, remove
    /// - item.date_of_birth.ToShortDateString is culture specific, use tostring("dd/MM/yyyy") instead
    /// </summary>
    public partial class Comparison : Form
    {
        string _jsonData, _results;
        public Comparison(string results, string jsonData)
        {
            InitializeComponent();
            _results = results;
            _jsonData = jsonData;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Comparison_Load(object sender, EventArgs e)
        {
            ValidateResults();
        }

        private void ValidateResults()
        {
            string[] ResultsLine = File.ReadAllLines(_results);

            var dataFile = File.ReadAllText(_jsonData);
            var un = JsonConvert.DeserializeObject<Json.Rootobject>(dataFile);
            string firstLine = ResultsLine[0];
            string[] header = firstLine.Split(',');
            for (int i = 1; i < 4; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                else
                {
                    dataGridView1.Columns.Add(header[i], header[i]);
                }
                
            }
            dataGridView1.Columns.Add("DOB (Database)", "DOB (Database)");

            foreach (var headerLbl in header)
            {
                dataGridView2.Columns.Add(headerLbl, headerLbl);
            }

            for (int i = 1; i < ResultsLine.Count(); i++)
            {
                string[] data = ResultsLine[i].Split(',');
                List<string> toAdd = new List<string>()
                {
                    data[1], data[3]
                };

                List<string> Database = new List<string>();
                foreach (var item in un.items)
                {
                    if (item.barcode == toAdd[0])
                    {
                        if (item.date_of_birth.ToShortDateString() != toAdd[1])
                        {
                            toAdd.Add(item.date_of_birth.ToShortDateString());
                            dataGridView1.Rows.Add(toAdd.ToArray());
                        }
                        else
                        {
                            dataGridView2.Rows.Add(data); 
                        }

                        
                    }

                }
               

                



                
            }
            foreach (var item in un.items)
            {
                
            }
            



        }

        



    }
}
