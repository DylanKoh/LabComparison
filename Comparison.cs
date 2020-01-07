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

namespace LabComparison
{
    //Initial Commit
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

        }

        private void ValidateResults()
        {
            string[] ResultsLine = File.ReadAllLines(_results);
        }
    }
}
