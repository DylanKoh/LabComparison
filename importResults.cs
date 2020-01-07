using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace LabComparison
{
    public partial class importResults : Form
    {
        string _jsonData;
        string _filePath;
        public importResults(string database)
        {
            InitializeComponent();
            _jsonData = database;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse CSV Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFileDialog1.FileName;
                Console.WriteLine(_filePath);


                string[] lines = File.ReadAllLines(_filePath);
                string firstLine = lines[0];
                string[] header = firstLine.Split(',');
                foreach (var headerlabel in header)
                {
                    dataGridView1.Columns.Add(headerlabel, headerlabel);
                }

                for (int i = 1; i < lines.Count(); i++)
                {
                    string[] data = lines[i].Split(',');
                    dataGridView1.Rows.Add(data);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new Comparison(_jsonData, _filePath)).ShowDialog();
            this.Close();
        }
    }
}
