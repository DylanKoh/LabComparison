using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabComparison
{
    /// <summary>
    /// JT> This form in unneccessary as the URL to pull the json from is already specified in the question paper
    /// - Openfiledialog tool should be setup in the GUI rather than in code
    /// - What happens if a non json file is selected
    /// - Unneccessary use of console
    /// - Form Name has no relevance to the task
    /// - Hardcoded initial path is not ideal, what if the machine has no d drive 
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse JSON Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "json",
                Filter = "json files (*.json)|*.json",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog1.FileName;
                Console.WriteLine(filePath);
                this.Hide();
                (new importResults(filePath)).ShowDialog();
                this.Close();
            }

        }
    }
}
