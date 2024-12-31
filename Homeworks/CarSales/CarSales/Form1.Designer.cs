﻿namespace CarSales
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
            clearButton = new Button();
            pictureBox1 = new PictureBox();
            CarUser = new TabControl();
            searchcar = new TabPage();
            carPricetbx = new TextBox();
            carSearchbtn = new Button();
            carPricelbl = new Label();
            label1 = new Label();
            carModeltbx = new TextBox();
            carBrandtbx = new TextBox();
            carbrandlbl = new Label();
            custdata = new TabPage();
            addCustbtn = new Button();
            custPhonenum = new NumericUpDown();
            Zipcodenum = new NumericUpDown();
            citytbx = new TextBox();
            custAddresstbx = new TextBox();
            custNametbx = new TextBox();
            custzipcitylbl = new Label();
            custaddresslbl = new Label();
            custphonelbl = new Label();
            custnamelbl = new Label();
            sellCarbtn = new Button();
            Foundcargbx = new GroupBox();
            cardetailstbx = new RichTextBox();
            foundcarlbl = new Label();
            foundCarscmbx = new ComboBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CarUser.SuspendLayout();
            searchcar.SuspendLayout();
            custdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)custPhonenum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Zipcodenum).BeginInit();
            Foundcargbx.SuspendLayout();
            SuspendLayout();
            // 
            // SaveData
            // 
            SaveData.Location = new Point(315, 249);
            SaveData.Name = "SaveData";
            SaveData.Size = new Size(118, 38);
            SaveData.TabIndex = 0;
            SaveData.Text = "Save Data";
            SaveData.UseVisualStyleBackColor = true;
            // 
            // LoadData
            // 
            LoadData.Location = new Point(188, 249);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(121, 37);
            LoadData.TabIndex = 1;
            LoadData.Text = "Load Data";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(439, 249);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(121, 38);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear Data";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 138);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // CarUser
            // 
            CarUser.Controls.Add(searchcar);
            CarUser.Controls.Add(custdata);
            CarUser.Location = new Point(182, 12);
            CarUser.Name = "CarUser";
            CarUser.SelectedIndex = 0;
            CarUser.Size = new Size(391, 231);
            CarUser.TabIndex = 4;
            // 
            // searchcar
            // 
            searchcar.Controls.Add(carPricetbx);
            searchcar.Controls.Add(carSearchbtn);
            searchcar.Controls.Add(carPricelbl);
            searchcar.Controls.Add(label1);
            searchcar.Controls.Add(carModeltbx);
            searchcar.Controls.Add(carBrandtbx);
            searchcar.Controls.Add(carbrandlbl);
            searchcar.Location = new Point(4, 24);
            searchcar.Name = "searchcar";
            searchcar.Padding = new Padding(3);
            searchcar.Size = new Size(383, 203);
            searchcar.TabIndex = 0;
            searchcar.Text = "Search";
            searchcar.UseVisualStyleBackColor = true;
            // 
            // carPricetbx
            // 
            carPricetbx.Location = new Point(87, 91);
            carPricetbx.Name = "carPricetbx";
            carPricetbx.Size = new Size(289, 23);
            carPricetbx.TabIndex = 13;
            // 
            // carSearchbtn
            // 
            carSearchbtn.Location = new Point(129, 154);
            carSearchbtn.Name = "carSearchbtn";
            carSearchbtn.Size = new Size(118, 37);
            carSearchbtn.TabIndex = 12;
            carSearchbtn.Text = "Search Car";
            carSearchbtn.UseVisualStyleBackColor = true;
            carSearchbtn.Click += carSearchbtn_Click;
            // 
            // carPricelbl
            // 
            carPricelbl.AutoSize = true;
            carPricelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carPricelbl.Location = new Point(2, 95);
            carPricelbl.Name = "carPricelbl";
            carPricelbl.Size = new Size(74, 20);
            carPricelbl.TabIndex = 4;
            carPricelbl.Text = "Car Price: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 56);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 3;
            label1.Text = "Car Model:";
            // 
            // carModeltbx
            // 
            carModeltbx.Location = new Point(87, 55);
            carModeltbx.Name = "carModeltbx";
            carModeltbx.Size = new Size(290, 23);
            carModeltbx.TabIndex = 2;
            // 
            // carBrandtbx
            // 
            carBrandtbx.Location = new Point(87, 17);
            carBrandtbx.Name = "carBrandtbx";
            carBrandtbx.Size = new Size(289, 23);
            carBrandtbx.TabIndex = 1;
            // 
            // carbrandlbl
            // 
            carbrandlbl.AutoSize = true;
            carbrandlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carbrandlbl.Location = new Point(3, 18);
            carbrandlbl.Name = "carbrandlbl";
            carbrandlbl.Size = new Size(77, 20);
            carbrandlbl.TabIndex = 0;
            carbrandlbl.Text = "Car Brand:";
            // 
            // custdata
            // 
            custdata.Controls.Add(addCustbtn);
            custdata.Controls.Add(custPhonenum);
            custdata.Controls.Add(Zipcodenum);
            custdata.Controls.Add(citytbx);
            custdata.Controls.Add(custAddresstbx);
            custdata.Controls.Add(custNametbx);
            custdata.Controls.Add(custzipcitylbl);
            custdata.Controls.Add(custaddresslbl);
            custdata.Controls.Add(custphonelbl);
            custdata.Controls.Add(custnamelbl);
            custdata.Location = new Point(4, 24);
            custdata.Name = "custdata";
            custdata.Padding = new Padding(3);
            custdata.Size = new Size(383, 203);
            custdata.TabIndex = 1;
            custdata.Text = "Customer Details";
            custdata.UseVisualStyleBackColor = true;
            // 
            // addCustbtn
            // 
            addCustbtn.Location = new Point(120, 160);
            addCustbtn.Name = "addCustbtn";
            addCustbtn.Size = new Size(127, 37);
            addCustbtn.TabIndex = 14;
            addCustbtn.Text = "Add Customer";
            addCustbtn.UseVisualStyleBackColor = true;
            // 
            // custPhonenum
            // 
            custPhonenum.Location = new Point(120, 44);
            custPhonenum.Name = "custPhonenum";
            custPhonenum.Size = new Size(252, 23);
            custPhonenum.TabIndex = 13;
            // 
            // Zipcodenum
            // 
            Zipcodenum.Location = new Point(139, 112);
            Zipcodenum.Name = "Zipcodenum";
            Zipcodenum.Size = new Size(78, 23);
            Zipcodenum.TabIndex = 12;
            // 
            // citytbx
            // 
            citytbx.Location = new Point(228, 112);
            citytbx.Name = "citytbx";
            citytbx.Size = new Size(148, 23);
            citytbx.TabIndex = 11;
            // 
            // custAddresstbx
            // 
            custAddresstbx.Location = new Point(77, 73);
            custAddresstbx.Name = "custAddresstbx";
            custAddresstbx.Size = new Size(299, 23);
            custAddresstbx.TabIndex = 10;
            // 
            // custNametbx
            // 
            custNametbx.Location = new Point(61, 15);
            custNametbx.Name = "custNametbx";
            custNametbx.Size = new Size(311, 23);
            custNametbx.TabIndex = 9;
            // 
            // custzipcitylbl
            // 
            custzipcitylbl.AutoSize = true;
            custzipcitylbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custzipcitylbl.Location = new Point(6, 110);
            custzipcitylbl.Name = "custzipcitylbl";
            custzipcitylbl.Size = new Size(127, 20);
            custzipcitylbl.TabIndex = 8;
            custzipcitylbl.Text = "ZipCode and City:";
            // 
            // custaddresslbl
            // 
            custaddresslbl.AutoSize = true;
            custaddresslbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custaddresslbl.Location = new Point(6, 74);
            custaddresslbl.Name = "custaddresslbl";
            custaddresslbl.Size = new Size(65, 20);
            custaddresslbl.TabIndex = 7;
            custaddresslbl.Text = "Address:";
            // 
            // custphonelbl
            // 
            custphonelbl.AutoSize = true;
            custphonelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custphonelbl.Location = new Point(6, 44);
            custphonelbl.Name = "custphonelbl";
            custphonelbl.Size = new Size(111, 20);
            custphonelbl.TabIndex = 6;
            custphonelbl.Text = "Phone Number:";
            // 
            // custnamelbl
            // 
            custnamelbl.AutoSize = true;
            custnamelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custnamelbl.Location = new Point(6, 14);
            custnamelbl.Name = "custnamelbl";
            custnamelbl.Size = new Size(52, 20);
            custnamelbl.TabIndex = 5;
            custnamelbl.Text = "Name:";
            // 
            // sellCarbtn
            // 
            sellCarbtn.Location = new Point(16, 157);
            sellCarbtn.Name = "sellCarbtn";
            sellCarbtn.Size = new Size(127, 35);
            sellCarbtn.TabIndex = 6;
            sellCarbtn.Text = "Sell Car";
            sellCarbtn.UseVisualStyleBackColor = true;
            // 
            // Foundcargbx
            // 
            Foundcargbx.Controls.Add(cardetailstbx);
            Foundcargbx.Controls.Add(foundcarlbl);
            Foundcargbx.Controls.Add(foundCarscmbx);
            Foundcargbx.Controls.Add(sellCarbtn);
            Foundcargbx.Location = new Point(12, 156);
            Foundcargbx.Name = "Foundcargbx";
            Foundcargbx.Size = new Size(164, 213);
            Foundcargbx.TabIndex = 7;
            Foundcargbx.TabStop = false;
            Foundcargbx.Text = "Found Car";
            // 
            // cardetailstbx
            // 
            cardetailstbx.Location = new Point(7, 71);
            cardetailstbx.Name = "cardetailstbx";
            cardetailstbx.Size = new Size(151, 80);
            cardetailstbx.TabIndex = 12;
            cardetailstbx.Text = "";
            // 
            // foundcarlbl
            // 
            foundcarlbl.AutoSize = true;
            foundcarlbl.Location = new Point(7, 24);
            foundcarlbl.Name = "foundcarlbl";
            foundcarlbl.Size = new Size(39, 15);
            foundcarlbl.TabIndex = 11;
            foundcarlbl.Text = "Name";
            // 
            // foundCarscmbx
            // 
            foundCarscmbx.FormattingEnabled = true;
            foundCarscmbx.Location = new Point(6, 42);
            foundCarscmbx.Name = "foundCarscmbx";
            foundCarscmbx.Size = new Size(152, 23);
            foundCarscmbx.TabIndex = 9;
            foundCarscmbx.SelectedIndexChanged += foundCarscmbx_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(306, 312);
            button1.Name = "button1";
            button1.Size = new Size(127, 37);
            button1.TabIndex = 11;
            button1.Text = "Admin";
            button1.UseVisualStyleBackColor = true;
            // 
            // CarDealership
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 374);
            Controls.Add(button1);
            Controls.Add(Foundcargbx);
            Controls.Add(CarUser);
            Controls.Add(pictureBox1);
            Controls.Add(clearButton);
            Controls.Add(LoadData);
            Controls.Add(SaveData);
            Name = "CarDealership";
            Text = "Find your dream car!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CarUser.ResumeLayout(false);
            searchcar.ResumeLayout(false);
            searchcar.PerformLayout();
            custdata.ResumeLayout(false);
            custdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)custPhonenum).EndInit();
            ((System.ComponentModel.ISupportInitialize)Zipcodenum).EndInit();
            Foundcargbx.ResumeLayout(false);
            Foundcargbx.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SaveData;
        private Button LoadData;
        private Button clearButton;
        private PictureBox pictureBox1;
        private TabControl CarUser;
        private TabPage searchcar;
        private TabPage custdata;
        private Label custnamelbl;
        private NumericUpDown custPhonenum;
        private NumericUpDown Zipcodenum;
        private TextBox citytbx;
        private TextBox custAddresstbx;
        private TextBox custNametbx;
        private Label custzipcitylbl;
        private Label custaddresslbl;
        private Label custphonelbl;
        private Label carbrandlbl;
        private Label carPricelbl;
        private Label label1;
        private TextBox carModeltbx;
        private TextBox carBrandtbx;
        private Button addCustbtn;
        private Button sellCarbtn;
        private GroupBox Foundcargbx;
        private Label foundcarlbl;
        private ComboBox foundCarscmbx;
        private Button button1;
        private Button carSearchbtn;
        private RichTextBox cardetailstbx;
        private TextBox carPricetbx;
    }
}
