using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace generateLogFile
{
    public partial class Form1 : Form
    {
        private List<string> dataEntries;
        private string defaultFilePath;

        public Form1()
        {
            InitializeComponent();
            dataEntries = new List<string>();
            defaultFilePath = "D:\\Harry Rosianto's Folder\\16. TRIAL\\data.csv";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddData_Click_1(object sender, EventArgs e)
        {
            // Get the data input from the textbox
            string data = txtDataInput.Text.Trim();

            // Validate that data is not empty
            if (!string.IsNullOrEmpty(data))
            {
                dataEntries.Add(data);
                txtDataInput.Clear();

                try 
                {
                    using (StreamWriter writer = new StreamWriter(defaultFilePath, true))
                    {
                        writer.WriteLine(data);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while saving the CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            int numLines = dataEntries.Count;
            dataEntriesCount.Text = numLines.ToString();
        }

        private void btnSaveToCSV_Click_1(object sender, EventArgs e)
        {
            //// Show SaveFileDialog to let the user choose the CSV file location
            ////saveFileDialog = new SaveFileDialog
            ////{
            ////    Filter = "CSV Files (*.csv)|*.csv",
            ////    Title = "Save CSV File",
            ////    FileName = "data.csv" // Default file name
            ////};

            //try
            //{
            //    // Get the chosen file path from the SaveFileDialog
            //    string filePath = defaultFilePath;

            //    try
            //    {
            //        // Append the data entries to the CSV file
            //        using (StreamWriter writer = new StreamWriter(filePath, true))
            //        {
            //            foreach (string entry in dataEntries)
            //            {
            //                writer.WriteLine(entry);
            //            }
            //        }
            //        dataEntries.Clear();

            //        MessageBox.Show("Data has been saved to the CSV file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"An error occurred while saving the CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch 
            //{
                
            //}
        }

        //private void btnAddData_Click_1(object sender, EventArgs e)
        //{
        //    // Get the data input from the textbox
        //    string data = txtDataInput.Text.Trim();

        //    // Validate that data is not empty
        //    if (!string.IsNullOrEmpty(data))
        //    {
        //        dataEntries.Add(data);
        //        txtDataInput.Clear();
        //    }
        //}

        //private void btnSaveToCSV_Click_1(object sender, EventArgs e)
        //{
        //    // Show SaveFileDialog to let the user choose the CSV file location
        //    saveFileDialog = new SaveFileDialog
        //    {
        //        Filter = "CSV Files (*.csv)|*.csv",
        //        Title = "Save CSV File",
        //        FileName = "data.csv" // Default file name
        //    };

        //    if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        // Get the chosen file path from the SaveFileDialog
        //        string filePath = saveFileDialog.FileName;

        //        try
        //        {
        //            // Append the data entries to the CSV file
        //            using (StreamWriter writer = new StreamWriter(filePath, true))
        //            {
        //                foreach (string entry in dataEntries)
        //                {
        //                    writer.WriteLine(entry);
        //                }
        //            }

        //            MessageBox.Show("Data has been saved to the CSV file successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show($"An error occurred while saving the CSV file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        // Other event handlers...
    }
}
