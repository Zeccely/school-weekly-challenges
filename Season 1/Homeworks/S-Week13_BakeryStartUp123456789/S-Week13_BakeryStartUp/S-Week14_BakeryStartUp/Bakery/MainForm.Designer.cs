
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
            SellSandwhich = new System.Windows.Forms.Button();
            lblSandwichInfo = new System.Windows.Forms.Label();
            TotalRevenue = new System.Windows.Forms.Button();
            saver = new System.Windows.Forms.OpenFileDialog();
            revenuelbl = new System.Windows.Forms.Label();
            soldcounter = new System.Windows.Forms.Label();
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
            groupBox1.Location = new System.Drawing.Point(6, 1);
            groupBox1.Margin = new System.Windows.Forms.Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(1);
            groupBox1.Size = new System.Drawing.Size(302, 213);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // btnShowOfferedSandwiches
            // 
            btnShowOfferedSandwiches.Location = new System.Drawing.Point(4, 40);
            btnShowOfferedSandwiches.Margin = new System.Windows.Forms.Padding(1);
            btnShowOfferedSandwiches.Name = "btnShowOfferedSandwiches";
            btnShowOfferedSandwiches.Size = new System.Drawing.Size(295, 22);
            btnShowOfferedSandwiches.TabIndex = 6;
            btnShowOfferedSandwiches.Text = "Show offered sandwiches";
            btnShowOfferedSandwiches.UseVisualStyleBackColor = true;
            btnShowOfferedSandwiches.Click += btnShowOfferedSandwiches_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(4, 19);
            label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 15);
            label1.TabIndex = 5;
            label1.Text = "Bread filter:";
            // 
            // BreadFilterdrp
            // 
            BreadFilterdrp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BreadFilterdrp.FormattingEnabled = true;
            BreadFilterdrp.Items.AddRange(new object[] { "" });
            BreadFilterdrp.Location = new System.Drawing.Point(74, 16);
            BreadFilterdrp.Margin = new System.Windows.Forms.Padding(1);
            BreadFilterdrp.Name = "BreadFilterdrp";
            BreadFilterdrp.Size = new System.Drawing.Size(224, 23);
            BreadFilterdrp.TabIndex = 4;
            BreadFilterdrp.SelectedIndexChanged += BreadFilterdrp_SelectedIndexChanged;
            // 
            // AddSandwich
            // 
            AddSandwich.Location = new System.Drawing.Point(4, 164);
            AddSandwich.Margin = new System.Windows.Forms.Padding(1);
            AddSandwich.Name = "AddSandwich";
            AddSandwich.Size = new System.Drawing.Size(295, 22);
            AddSandwich.TabIndex = 3;
            AddSandwich.Text = "Add new Sandwich";
            AddSandwich.UseVisualStyleBackColor = true;
            AddSandwich.Click += AddSandwich_Click;
            // 
            // LoadData
            // 
            LoadData.Location = new System.Drawing.Point(152, 187);
            LoadData.Margin = new System.Windows.Forms.Padding(1);
            LoadData.Name = "LoadData";
            LoadData.Size = new System.Drawing.Size(146, 22);
            LoadData.TabIndex = 2;
            LoadData.Text = "Load data";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += Load_Click;
            // 
            // SaveData
            // 
            SaveData.Location = new System.Drawing.Point(4, 187);
            SaveData.Margin = new System.Windows.Forms.Padding(1);
            SaveData.Name = "SaveData";
            SaveData.Size = new System.Drawing.Size(146, 22);
            SaveData.TabIndex = 1;
            SaveData.Text = "Save data";
            SaveData.UseVisualStyleBackColor = true;
            SaveData.Click += SaveData_Click;
            // 
            // SMenu
            // 
            SMenu.FormattingEnabled = true;
            SMenu.ItemHeight = 15;
            SMenu.Location = new System.Drawing.Point(4, 64);
            SMenu.Margin = new System.Windows.Forms.Padding(1);
            SMenu.Name = "SMenu";
            SMenu.Size = new System.Drawing.Size(297, 94);
            SMenu.TabIndex = 0;
            SMenu.SelectedIndexChanged += SMenu_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(SellSandwhich);
            groupBox2.Controls.Add(lblSandwichInfo);
            groupBox2.Location = new System.Drawing.Point(317, 1);
            groupBox2.Margin = new System.Windows.Forms.Padding(1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(1);
            groupBox2.Size = new System.Drawing.Size(262, 213);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cart";
            // 
            // SellSandwhich
            // 
            SellSandwhich.Location = new System.Drawing.Point(6, 187);
            SellSandwhich.Margin = new System.Windows.Forms.Padding(1);
            SellSandwhich.Name = "SellSandwhich";
            SellSandwhich.Size = new System.Drawing.Size(256, 22);
            SellSandwhich.TabIndex = 1;
            SellSandwhich.Text = "Sell selected sandwhich";
            SellSandwhich.UseVisualStyleBackColor = true;
            SellSandwhich.Click += SellSandwhich_Click;
            // 
            // lblSandwichInfo
            // 
            lblSandwichInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            lblSandwichInfo.Location = new System.Drawing.Point(4, 18);
            lblSandwichInfo.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            lblSandwichInfo.Name = "lblSandwichInfo";
            lblSandwichInfo.Size = new System.Drawing.Size(256, 144);
            lblSandwichInfo.TabIndex = 0;
            lblSandwichInfo.Text = "[Sandwich Data]";
            lblSandwichInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalRevenue
            // 
            TotalRevenue.Location = new System.Drawing.Point(26, 229);
            TotalRevenue.Margin = new System.Windows.Forms.Padding(1);
            TotalRevenue.Name = "TotalRevenue";
            TotalRevenue.Size = new System.Drawing.Size(256, 22);
            TotalRevenue.TabIndex = 2;
            TotalRevenue.Text = "Show total revenue";
            TotalRevenue.UseVisualStyleBackColor = true;
            TotalRevenue.Click += TotalRevenue_Click;
            // 
            // saver
            // 
            saver.DefaultExt = "xml";
            saver.FileName = "saver";
            saver.Title = "Bakery";
            // 
            // revenuelbl
            // 
            revenuelbl.AutoSize = true;
            revenuelbl.Location = new System.Drawing.Point(323, 236);
            revenuelbl.Name = "revenuelbl";
            revenuelbl.Size = new System.Drawing.Size(52, 15);
            revenuelbl.TabIndex = 3;
            revenuelbl.Text = "Revenue";
            // 
            // soldcounter
            // 
            soldcounter.AutoSize = true;
            soldcounter.Location = new System.Drawing.Point(498, 236);
            soldcounter.Name = "soldcounter";
            soldcounter.Size = new System.Drawing.Size(73, 15);
            soldcounter.TabIndex = 4;
            soldcounter.Text = "SoldCounter";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(588, 270);
            Controls.Add(soldcounter);
            Controls.Add(revenuelbl);
            Controls.Add(TotalRevenue);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(1);
            Name = "MainForm";
            Text = "Main";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button LoadData;
        private System.Windows.Forms.Button SaveData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button TotalRevenue;
        private System.Windows.Forms.Button SellSandwhich;
        private System.Windows.Forms.Label lblSandwichInfo;
        private System.Windows.Forms.Button AddSandwich;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BreadFilterdrp;
        private System.Windows.Forms.Button btnShowOfferedSandwiches;
        private System.Windows.Forms.ListBox SMenu;
        private System.Windows.Forms.OpenFileDialog saver;
        private System.Windows.Forms.Label revenuelbl;
        private System.Windows.Forms.Label soldcounter;
    }
}