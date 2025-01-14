namespace CarSales
{
    partial class DealershipForm
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
            addcustbtn = new Button();
            custNumtbx = new TextBox();
            custzipcitytbx = new TextBox();
            custAddresstbx = new TextBox();
            custNametbx = new TextBox();
            custzipcitylbl = new Label();
            custaddresslbl = new Label();
            custphonelbl = new Label();
            custnamelbl = new Label();
            sellCarbtn = new Button();
            Foundcargbx = new GroupBox();
            buyernamlbl = new Label();
            cardetailstbx = new RichTextBox();
            foundcarlbl = new Label();
            foundCarscmbx = new ComboBox();
            adminbtn = new Button();
            loadxmlbtn = new Button();
            savexmlbtn = new Button();
            LoadJSONbtn = new Button();
            SaveJSONbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            CarUser.SuspendLayout();
            searchcar.SuspendLayout();
            custdata.SuspendLayout();
            Foundcargbx.SuspendLayout();
            SuspendLayout();
            // 
            // SaveData
            // 
            SaveData.Location = new Point(443, 415);
            SaveData.Margin = new Padding(4, 5, 4, 5);
            SaveData.Name = "SaveData";
            SaveData.Size = new Size(181, 63);
            SaveData.TabIndex = 0;
            SaveData.Text = "Save Data";
            SaveData.UseVisualStyleBackColor = true;
            SaveData.Click += SaveData_Click;
            // 
            // LoadData
            // 
            LoadData.Location = new Point(257, 415);
            LoadData.Margin = new Padding(4, 5, 4, 5);
            LoadData.Name = "LoadData";
            LoadData.Size = new Size(173, 62);
            LoadData.TabIndex = 1;
            LoadData.Text = "Load Data";
            LoadData.UseVisualStyleBackColor = true;
            LoadData.Click += LoadData_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(640, 415);
            clearButton.Margin = new Padding(4, 5, 4, 5);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(173, 63);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear Data";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(17, 20);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 230);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // CarUser
            // 
            CarUser.Controls.Add(searchcar);
            CarUser.Controls.Add(custdata);
            CarUser.Location = new Point(260, 20);
            CarUser.Margin = new Padding(4, 5, 4, 5);
            CarUser.Name = "CarUser";
            CarUser.SelectedIndex = 0;
            CarUser.Size = new Size(559, 385);
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
            searchcar.Location = new Point(4, 34);
            searchcar.Margin = new Padding(4, 5, 4, 5);
            searchcar.Name = "searchcar";
            searchcar.Padding = new Padding(4, 5, 4, 5);
            searchcar.Size = new Size(551, 347);
            searchcar.TabIndex = 0;
            searchcar.Text = "Search";
            searchcar.UseVisualStyleBackColor = true;
            // 
            // carPricetbx
            // 
            carPricetbx.Location = new Point(124, 152);
            carPricetbx.Margin = new Padding(4, 5, 4, 5);
            carPricetbx.Name = "carPricetbx";
            carPricetbx.Size = new Size(411, 31);
            carPricetbx.TabIndex = 13;
            // 
            // carSearchbtn
            // 
            carSearchbtn.Location = new Point(184, 257);
            carSearchbtn.Margin = new Padding(4, 5, 4, 5);
            carSearchbtn.Name = "carSearchbtn";
            carSearchbtn.Size = new Size(169, 62);
            carSearchbtn.TabIndex = 12;
            carSearchbtn.Text = "Search Car";
            carSearchbtn.UseVisualStyleBackColor = true;
            carSearchbtn.Click += carSearchbtn_Click;
            // 
            // carPricelbl
            // 
            carPricelbl.AutoSize = true;
            carPricelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carPricelbl.Location = new Point(3, 158);
            carPricelbl.Margin = new Padding(4, 0, 4, 0);
            carPricelbl.Name = "carPricelbl";
            carPricelbl.Size = new Size(115, 31);
            carPricelbl.TabIndex = 4;
            carPricelbl.Text = "Car Price: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(4, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(125, 31);
            label1.TabIndex = 3;
            label1.Text = "Car Model:";
            // 
            // carModeltbx
            // 
            carModeltbx.Location = new Point(124, 92);
            carModeltbx.Margin = new Padding(4, 5, 4, 5);
            carModeltbx.Name = "carModeltbx";
            carModeltbx.Size = new Size(413, 31);
            carModeltbx.TabIndex = 2;
            // 
            // carBrandtbx
            // 
            carBrandtbx.Location = new Point(124, 28);
            carBrandtbx.Margin = new Padding(4, 5, 4, 5);
            carBrandtbx.Name = "carBrandtbx";
            carBrandtbx.Size = new Size(411, 31);
            carBrandtbx.TabIndex = 1;
            // 
            // carbrandlbl
            // 
            carbrandlbl.AutoSize = true;
            carbrandlbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            carbrandlbl.Location = new Point(4, 30);
            carbrandlbl.Margin = new Padding(4, 0, 4, 0);
            carbrandlbl.Name = "carbrandlbl";
            carbrandlbl.Size = new Size(119, 31);
            carbrandlbl.TabIndex = 0;
            carbrandlbl.Text = "Car Brand:";
            // 
            // custdata
            // 
            custdata.Controls.Add(addcustbtn);
            custdata.Controls.Add(custNumtbx);
            custdata.Controls.Add(custzipcitytbx);
            custdata.Controls.Add(custAddresstbx);
            custdata.Controls.Add(custNametbx);
            custdata.Controls.Add(custzipcitylbl);
            custdata.Controls.Add(custaddresslbl);
            custdata.Controls.Add(custphonelbl);
            custdata.Controls.Add(custnamelbl);
            custdata.Location = new Point(4, 34);
            custdata.Margin = new Padding(4, 5, 4, 5);
            custdata.Name = "custdata";
            custdata.Padding = new Padding(4, 5, 4, 5);
            custdata.Size = new Size(551, 347);
            custdata.TabIndex = 1;
            custdata.Text = "Customer Details";
            custdata.UseVisualStyleBackColor = true;
            // 
            // addcustbtn
            // 
            addcustbtn.Location = new Point(177, 255);
            addcustbtn.Margin = new Padding(4, 5, 4, 5);
            addcustbtn.Name = "addcustbtn";
            addcustbtn.Size = new Size(181, 63);
            addcustbtn.TabIndex = 16;
            addcustbtn.Text = "Add Customer";
            addcustbtn.UseVisualStyleBackColor = true;
            addcustbtn.Click += addcustbtn_Click;
            // 
            // custNumtbx
            // 
            custNumtbx.Location = new Point(171, 72);
            custNumtbx.Margin = new Padding(4, 5, 4, 5);
            custNumtbx.Name = "custNumtbx";
            custNumtbx.Size = new Size(364, 31);
            custNumtbx.TabIndex = 15;
            // 
            // custzipcitytbx
            // 
            custzipcitytbx.Location = new Point(190, 173);
            custzipcitytbx.Margin = new Padding(4, 5, 4, 5);
            custzipcitytbx.Name = "custzipcitytbx";
            custzipcitytbx.Size = new Size(345, 31);
            custzipcitytbx.TabIndex = 11;
            // 
            // custAddresstbx
            // 
            custAddresstbx.Location = new Point(110, 122);
            custAddresstbx.Margin = new Padding(4, 5, 4, 5);
            custAddresstbx.Name = "custAddresstbx";
            custAddresstbx.Size = new Size(425, 31);
            custAddresstbx.TabIndex = 10;
            // 
            // custNametbx
            // 
            custNametbx.Location = new Point(87, 25);
            custNametbx.Margin = new Padding(4, 5, 4, 5);
            custNametbx.Name = "custNametbx";
            custNametbx.Size = new Size(448, 31);
            custNametbx.TabIndex = 9;
            // 
            // custzipcitylbl
            // 
            custzipcitylbl.AutoSize = true;
            custzipcitylbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custzipcitylbl.Location = new Point(9, 175);
            custzipcitylbl.Margin = new Padding(4, 0, 4, 0);
            custzipcitylbl.Name = "custzipcitylbl";
            custzipcitylbl.Size = new Size(195, 31);
            custzipcitylbl.TabIndex = 8;
            custzipcitylbl.Text = "ZipCode and City:";
            // 
            // custaddresslbl
            // 
            custaddresslbl.AutoSize = true;
            custaddresslbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custaddresslbl.Location = new Point(9, 123);
            custaddresslbl.Margin = new Padding(4, 0, 4, 0);
            custaddresslbl.Name = "custaddresslbl";
            custaddresslbl.Size = new Size(102, 31);
            custaddresslbl.TabIndex = 7;
            custaddresslbl.Text = "Address:";
            // 
            // custphonelbl
            // 
            custphonelbl.AutoSize = true;
            custphonelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custphonelbl.Location = new Point(9, 73);
            custphonelbl.Margin = new Padding(4, 0, 4, 0);
            custphonelbl.Name = "custphonelbl";
            custphonelbl.Size = new Size(173, 31);
            custphonelbl.TabIndex = 6;
            custphonelbl.Text = "Phone Number:";
            // 
            // custnamelbl
            // 
            custnamelbl.AutoSize = true;
            custnamelbl.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            custnamelbl.Location = new Point(9, 23);
            custnamelbl.Margin = new Padding(4, 0, 4, 0);
            custnamelbl.Name = "custnamelbl";
            custnamelbl.Size = new Size(80, 31);
            custnamelbl.TabIndex = 5;
            custnamelbl.Text = "Name:";
            // 
            // sellCarbtn
            // 
            sellCarbtn.Location = new Point(23, 262);
            sellCarbtn.Margin = new Padding(4, 5, 4, 5);
            sellCarbtn.Name = "sellCarbtn";
            sellCarbtn.Size = new Size(181, 58);
            sellCarbtn.TabIndex = 6;
            sellCarbtn.Text = "Sell Car";
            sellCarbtn.UseVisualStyleBackColor = true;
            sellCarbtn.Click += sellCarbtn_Click;
            // 
            // Foundcargbx
            // 
            Foundcargbx.Controls.Add(buyernamlbl);
            Foundcargbx.Controls.Add(cardetailstbx);
            Foundcargbx.Controls.Add(foundcarlbl);
            Foundcargbx.Controls.Add(foundCarscmbx);
            Foundcargbx.Controls.Add(sellCarbtn);
            Foundcargbx.Location = new Point(17, 260);
            Foundcargbx.Margin = new Padding(4, 5, 4, 5);
            Foundcargbx.Name = "Foundcargbx";
            Foundcargbx.Padding = new Padding(4, 5, 4, 5);
            Foundcargbx.Size = new Size(234, 355);
            Foundcargbx.TabIndex = 7;
            Foundcargbx.TabStop = false;
            Foundcargbx.Text = "Found Car";
            // 
            // buyernamlbl
            // 
            buyernamlbl.AutoSize = true;
            buyernamlbl.Location = new Point(86, 325);
            buyernamlbl.Margin = new Padding(4, 0, 4, 0);
            buyernamlbl.Name = "buyernamlbl";
            buyernamlbl.Size = new Size(59, 25);
            buyernamlbl.TabIndex = 12;
            buyernamlbl.Text = "label2";
            // 
            // cardetailstbx
            // 
            cardetailstbx.Location = new Point(10, 118);
            cardetailstbx.Margin = new Padding(4, 5, 4, 5);
            cardetailstbx.Name = "cardetailstbx";
            cardetailstbx.Size = new Size(214, 131);
            cardetailstbx.TabIndex = 12;
            cardetailstbx.Text = "";
            // 
            // foundcarlbl
            // 
            foundcarlbl.AutoSize = true;
            foundcarlbl.Location = new Point(10, 40);
            foundcarlbl.Margin = new Padding(4, 0, 4, 0);
            foundcarlbl.Name = "foundcarlbl";
            foundcarlbl.Size = new Size(59, 25);
            foundcarlbl.TabIndex = 11;
            foundcarlbl.Text = "Name";
            // 
            // foundCarscmbx
            // 
            foundCarscmbx.FormattingEnabled = true;
            foundCarscmbx.Location = new Point(9, 70);
            foundCarscmbx.Margin = new Padding(4, 5, 4, 5);
            foundCarscmbx.Name = "foundCarscmbx";
            foundCarscmbx.Size = new Size(215, 33);
            foundCarscmbx.TabIndex = 9;
            foundCarscmbx.SelectedIndexChanged += foundCarscmbx_SelectedIndexChanged;
            // 
            // adminbtn
            // 
            adminbtn.Location = new Point(443, 520);
            adminbtn.Margin = new Padding(4, 5, 4, 5);
            adminbtn.Name = "adminbtn";
            adminbtn.Size = new Size(181, 62);
            adminbtn.TabIndex = 11;
            adminbtn.Text = "Admin";
            adminbtn.UseVisualStyleBackColor = true;
            adminbtn.Click += adminbtn_Click;
            // 
            // loadxmlbtn
            // 
            loadxmlbtn.Location = new Point(711, 520);
            loadxmlbtn.Margin = new Padding(4, 5, 4, 5);
            loadxmlbtn.Name = "loadxmlbtn";
            loadxmlbtn.Size = new Size(107, 38);
            loadxmlbtn.TabIndex = 12;
            loadxmlbtn.Text = "LoadXML";
            loadxmlbtn.UseVisualStyleBackColor = true;
            loadxmlbtn.Click += loadxmlbtn_Click;
            // 
            // savexmlbtn
            // 
            savexmlbtn.Location = new Point(711, 572);
            savexmlbtn.Margin = new Padding(4, 5, 4, 5);
            savexmlbtn.Name = "savexmlbtn";
            savexmlbtn.Size = new Size(107, 38);
            savexmlbtn.TabIndex = 13;
            savexmlbtn.Text = "SaveXML";
            savexmlbtn.UseVisualStyleBackColor = true;
            savexmlbtn.Click += savexmlbtn_Click;
            // 
            // LoadJSONbtn
            // 
            LoadJSONbtn.Location = new Point(260, 524);
            LoadJSONbtn.Name = "LoadJSONbtn";
            LoadJSONbtn.Size = new Size(112, 34);
            LoadJSONbtn.TabIndex = 14;
            LoadJSONbtn.Text = "LoadJSON";
            LoadJSONbtn.UseVisualStyleBackColor = true;
            LoadJSONbtn.Click += LoadJSONbtn_Click;
            // 
            // SaveJSONbtn
            // 
            SaveJSONbtn.Location = new Point(260, 572);
            SaveJSONbtn.Name = "SaveJSONbtn";
            SaveJSONbtn.Size = new Size(112, 34);
            SaveJSONbtn.TabIndex = 15;
            SaveJSONbtn.Text = "SaveJSON";
            SaveJSONbtn.UseVisualStyleBackColor = true;
            SaveJSONbtn.Click += SaveJSONbtn_Click;
            // 
            // DealershipForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 623);
            Controls.Add(SaveJSONbtn);
            Controls.Add(LoadJSONbtn);
            Controls.Add(savexmlbtn);
            Controls.Add(loadxmlbtn);
            Controls.Add(adminbtn);
            Controls.Add(Foundcargbx);
            Controls.Add(CarUser);
            Controls.Add(pictureBox1);
            Controls.Add(clearButton);
            Controls.Add(LoadData);
            Controls.Add(SaveData);
            Margin = new Padding(4, 5, 4, 5);
            Name = "DealershipForm";
            Text = "Find your dream car!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            CarUser.ResumeLayout(false);
            searchcar.ResumeLayout(false);
            searchcar.PerformLayout();
            custdata.ResumeLayout(false);
            custdata.PerformLayout();
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
        private TextBox custzipcitytbx;
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
        private Button sellCarbtn;
        private GroupBox Foundcargbx;
        private Label foundcarlbl;
        private ComboBox foundCarscmbx;
        private Button adminbtn;
        private Button carSearchbtn;
        private RichTextBox cardetailstbx;
        private TextBox carPricetbx;
        private TextBox custNumtbx;
        private Label buyernamlbl;
        private Button addcustbtn;
        private Button loadxmlbtn;
        private Button savexmlbtn;
        private Button LoadJSONbtn;
        private Button SaveJSONbtn;
    }
}
