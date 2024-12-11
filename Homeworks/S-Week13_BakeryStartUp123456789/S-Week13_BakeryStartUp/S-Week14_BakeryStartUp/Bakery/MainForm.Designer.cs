
namespace Bakery
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            btnShowOfferedSandwiches = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            BreadFilterdrp = new System.Windows.Forms.ComboBox();
            AddSandwich = new System.Windows.Forms.Button();
            LoadData = new System.Windows.Forms.Button();
            SaveData = new System.Windows.Forms.Button();
            SMenu = new System.Windows.Forms.ListBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            TotalRevenue = new System.Windows.Forms.Button();
            SellSandwhich = new System.Windows.Forms.Button();
            lblSandwichInfo = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnShowOfferedSandwiches);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BreadFilterdrp);
            groupBox1.Controls.Add(AddSandwich);
            groupBox1.Controls.Add(LoadData);
            groupBox1.Controls.Add(SaveData);
            groupBox1.Controls.Add(SMenu);
            groupBox1.Location = new System.Drawing.Point(9, 2);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(431, 355);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnShowOfferedSandwiches
            // 
            btnShowOfferedSandwiches.Location = new System.Drawing.Point(5, 66);
            btnShowOfferedSandwiches.Margin = new System.Windows.Forms.Padding(2);
            btnShowOfferedSandwiches.Name = "btnShowOfferedSandwiches";
            btnShowOfferedSandwiches.Size = new System.Drawing.Size(422, 36);
            btnShowOfferedSandwiches.TabIndex = 6;
            btnShowOfferedSandwiches.Text = "Show offered sandwiches";
            btnShowOfferedSandwiches.UseVisualStyleBackColor = true;
            btnShowOfferedSandwiches.Click += btnShowOfferedSandwiches_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(5, 32);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 25);
            label1.TabIndex = 5;
            label1.Text = "Bread filter:";
            // 
            // BreadFilterdrp
            // 
            BreadFilterdrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BreadFilterdrp.FormattingEnabled = true;
            BreadFilterdrp.Items.AddRange(new object[] { "", "Ciabatta", "Focaccia", "Sour Dough", "Rye", "Whole Wheat" });
            BreadFilterdrp.Location = new System.Drawing.Point(108, 30);
            BreadFilterdrp.Margin = new System.Windows.Forms.Padding(2);
            BreadFilterdrp.Name = "BreadFilterdrp";
            BreadFilterdrp.Size = new System.Drawing.Size(319, 33);
            BreadFilterdrp.TabIndex = 4;
            // 
            // AddSandwich
            // 
            AddSandwich.Location = new System.Drawing.Point(5, 273);
            AddSandwich.Margin = new System.Windows.Forms.Padding(2);
            AddSandwich.Name = "AddSandwich";
            AddSandwich.Size = new System.Drawing.Size(422, 36);
            AddSandwich.TabIndex = 3;
            AddSandwich.Text = "Add new Sandwich";
            AddSandwich.UseVisualStyleBackColor = true;
            AddSandwich.Click += AddSandwich_Click;
            // 
            // LoadData
            // 
            LoadData.Location = new System.Drawing.Point(217, 312);
            LoadData.Margin = new System.Windows.Forms.Padding(2);
            LoadData.Name = "LoadData";
            LoadData.Size = new System.Drawing.Size(209, 36);
            LoadData.TabIndex = 2;
            LoadData.Text = "Load data";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += Load_Click;
            // 
            // SaveData
            // 
            SaveData.Location = new System.Drawing.Point(5, 312);
            SaveData.Margin = new System.Windows.Forms.Padding(2);
            SaveData.Name = "SaveData";
            SaveData.Size = new System.Drawing.Size(208, 36);
            SaveData.TabIndex = 1;
            SaveData.Text = "Save data";
            SaveData.UseVisualStyleBackColor = true;
            // 
            // SMenu
            // 
            SMenu.FormattingEnabled = true;
            SMenu.ItemHeight = 25;
            SMenu.Location = new System.Drawing.Point(5, 106);
            SMenu.Margin = new System.Windows.Forms.Padding(2);
            SMenu.Name = "SMenu";
            SMenu.Size = new System.Drawing.Size(422, 154);
            SMenu.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TotalRevenue);
            groupBox2.Controls.Add(SellSandwhich);
            groupBox2.Controls.Add(lblSandwichInfo);
            groupBox2.Location = new System.Drawing.Point(453, 2);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(375, 355);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cart";
            // 
            // TotalRevenue
            // 
            TotalRevenue.Location = new System.Drawing.Point(5, 312);
            TotalRevenue.Margin = new System.Windows.Forms.Padding(2);
            TotalRevenue.Name = "TotalRevenue";
            TotalRevenue.Size = new System.Drawing.Size(365, 36);
            TotalRevenue.TabIndex = 2;
            TotalRevenue.Text = "Show total revenue";
            TotalRevenue.UseVisualStyleBackColor = true;
            // 
            // SellSandwhich
            // 
            SellSandwhich.Location = new System.Drawing.Point(5, 272);
            SellSandwhich.Margin = new System.Windows.Forms.Padding(2);
            SellSandwhich.Name = "SellSandwhich";
            SellSandwhich.Size = new System.Drawing.Size(365, 36);
            SellSandwhich.TabIndex = 1;
            SellSandwhich.Text = "Sell selected sandwhich";
            SellSandwhich.UseVisualStyleBackColor = true;
            // 
            // lblSandwichInfo
            // 
            lblSandwichInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblSandwichInfo.Location = new System.Drawing.Point(5, 30);
            lblSandwichInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblSandwichInfo.Name = "lblSandwichInfo";
            lblSandwichInfo.Size = new System.Drawing.Size(365, 240);
            lblSandwichInfo.TabIndex = 0;
            lblSandwichInfo.Text = "[Sandwich Data]";
            lblSandwichInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(841, 367);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "MainForm";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.ListBox SMenu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TotalRevenue;
        private System.Windows.Forms.Button SellSandwhich;
        private System.Windows.Forms.Label lblSandwichInfo;
        private System.Windows.Forms.Button AddSandwich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BreadFilterdrp;
        private System.Windows.Forms.Button btnShowOfferedSandwiches;
    }
}