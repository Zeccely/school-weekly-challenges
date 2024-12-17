namespace CarSales
{
    partial class CarDealership
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
            SaveData = new Button();
            LoadData = new Button();
            SuspendLayout();
            // 
            // SaveData
            // 
            SaveData.Location = new Point(381, 280);
            SaveData.Name = "SaveData";
            SaveData.Size = new Size(127, 38);
            SaveData.TabIndex = 0;
            SaveData.Text = "Save Data";
            SaveData.UseVisualStyleBackColor = true;
            // 
            // LoadData
            // 
            LoadData.Location = new Point(12, 283);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(127, 38);
            LoadData.TabIndex = 1;
            LoadData.Text = "Load Data";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // CarDealership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 333);
            Controls.Add(LoadData);
            Controls.Add(SaveData);
            Name = "CarDealership";
            Text = "Find your dream car!";
            ResumeLayout(false);
        }

        #endregion

        private Button SaveData;
        private Button LoadData;
    }
}
