namespace generateLogFile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDataInput=new TextBox();
            btnAddData=new Button();
            btnSaveToCSV=new Button();
            saveFileDialog=new SaveFileDialog();
            dataEntriesCount=new TextBox();
            SuspendLayout();
            // 
            // txtDataInput
            // 
            txtDataInput.Location=new Point(71, 66);
            txtDataInput.Name="txtDataInput";
            txtDataInput.Size=new Size(181, 23);
            txtDataInput.TabIndex=0;
            txtDataInput.Text="input data here...";
            // 
            // btnAddData
            // 
            btnAddData.Location=new Point(71, 104);
            btnAddData.Name="btnAddData";
            btnAddData.Size=new Size(75, 23);
            btnAddData.TabIndex=1;
            btnAddData.Text="Add";
            btnAddData.UseVisualStyleBackColor=true;
            btnAddData.Click+=btnAddData_Click_1;
            // 
            // btnSaveToCSV
            // 
            btnSaveToCSV.Location=new Point(177, 104);
            btnSaveToCSV.Name="btnSaveToCSV";
            btnSaveToCSV.Size=new Size(75, 23);
            btnSaveToCSV.TabIndex=2;
            btnSaveToCSV.Text="Save";
            btnSaveToCSV.UseVisualStyleBackColor=true;
            btnSaveToCSV.Click+=btnSaveToCSV_Click_1;
            // 
            // dataEntriesCount
            // 
            dataEntriesCount.Location=new Point(74, 146);
            dataEntriesCount.Name="dataEntriesCount";
            dataEntriesCount.Size=new Size(178, 23);
            dataEntriesCount.TabIndex=3;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(dataEntriesCount);
            Controls.Add(btnSaveToCSV);
            Controls.Add(btnAddData);
            Controls.Add(txtDataInput);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDataInput;
        private Button btnAddData;
        private Button btnSaveToCSV;
        private SaveFileDialog saveFileDialog;
        private TextBox dataEntriesCount;
        //private List<string> datatEntries;

    }
}