namespace trucks
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            maxBoxA = new TextBox();
            maxPalletA = new TextBox();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            maxBoxB = new TextBox();
            maxPalletB = new TextBox();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            maxBoxC = new TextBox();
            maxPalletC = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            userBoxes = new TextBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            label9 = new Label();
            label8 = new Label();
            groupBox5 = new GroupBox();
            fullTruckNr = new TextBox();
            fullPalletNr = new TextBox();
            palletRemain = new TextBox();
            boxRemain = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(367, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 0;
            label1.Text = "Trucks";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maxBoxA);
            groupBox1.Controls.Add(maxPalletA);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(62, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(205, 186);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Truck Type A";
            // 
            // maxBoxA
            // 
            maxBoxA.Location = new Point(6, 141);
            maxBoxA.Name = "maxBoxA";
            maxBoxA.Size = new Size(150, 31);
            maxBoxA.TabIndex = 3;
            maxBoxA.TextChanged += maxBoxA_TextChanged;
            // 
            // maxPalletA
            // 
            maxPalletA.Location = new Point(6, 67);
            maxPalletA.Name = "maxPalletA";
            maxPalletA.Size = new Size(150, 31);
            maxPalletA.TabIndex = 2;
            maxPalletA.TextChanged += maxPalletA_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 113);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 1;
            label3.Text = "Max Boxes per pallet";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 39);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 0;
            label2.Text = "Max Pallets";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(maxBoxB);
            groupBox2.Controls.Add(maxPalletB);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(323, 41);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(210, 186);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Truck Type B";
            // 
            // maxBoxB
            // 
            maxBoxB.Location = new Point(6, 141);
            maxBoxB.Name = "maxBoxB";
            maxBoxB.Size = new Size(150, 31);
            maxBoxB.TabIndex = 3;
            maxBoxB.TextChanged += maxBoxB_TextChanged;
            // 
            // maxPalletB
            // 
            maxPalletB.Location = new Point(6, 67);
            maxPalletB.Name = "maxPalletB";
            maxPalletB.Size = new Size(150, 31);
            maxPalletB.TabIndex = 2;
            maxPalletB.TextChanged += maxPalletB_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 113);
            label5.Name = "label5";
            label5.Size = new Size(175, 25);
            label5.TabIndex = 1;
            label5.Text = "Max Boxes per pallet";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 39);
            label4.Name = "label4";
            label4.Size = new Size(99, 25);
            label4.TabIndex = 0;
            label4.Text = "Max Pallets";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(maxBoxC);
            groupBox3.Controls.Add(maxPalletC);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(578, 41);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(212, 186);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Truck Type C";
            // 
            // maxBoxC
            // 
            maxBoxC.Location = new Point(6, 141);
            maxBoxC.Name = "maxBoxC";
            maxBoxC.Size = new Size(150, 31);
            maxBoxC.TabIndex = 3;
            maxBoxC.TextChanged += maxBoxC_TextChanged;
            // 
            // maxPalletC
            // 
            maxPalletC.Location = new Point(6, 67);
            maxPalletC.Name = "maxPalletC";
            maxPalletC.Size = new Size(150, 31);
            maxPalletC.TabIndex = 2;
            maxPalletC.TextChanged += maxPalletC_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 113);
            label7.Name = "label7";
            label7.Size = new Size(175, 25);
            label7.TabIndex = 1;
            label7.Text = "Max Boxes per pallet";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 39);
            label6.Name = "label6";
            label6.Size = new Size(99, 25);
            label6.TabIndex = 0;
            label6.Text = "Max Pallets";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(userBoxes);
            groupBox4.Controls.Add(checkBox3);
            groupBox4.Controls.Add(checkBox2);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label8);
            groupBox4.Location = new Point(62, 265);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(453, 201);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Task";
            // 
            // userBoxes
            // 
            userBoxes.Location = new Point(162, 40);
            userBoxes.Name = "userBoxes";
            userBoxes.Size = new Size(150, 31);
            userBoxes.TabIndex = 5;
            userBoxes.TextChanged += userBoxes_TextChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(261, 103);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(94, 29);
            checkBox3.TabIndex = 4;
            checkBox3.Text = "Truck C";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(162, 137);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(93, 29);
            checkBox2.TabIndex = 3;
            checkBox2.Text = "Truck B";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(162, 102);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(95, 29);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Truck A";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 103);
            label9.Name = "label9";
            label9.Size = new Size(150, 25);
            label9.TabIndex = 1;
            label9.Text = "Trucks to be used";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 43);
            label8.Name = "label8";
            label8.Size = new Size(158, 25);
            label8.TabIndex = 0;
            label8.Text = "Number of Boxes?";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(fullTruckNr);
            groupBox5.Controls.Add(fullPalletNr);
            groupBox5.Controls.Add(palletRemain);
            groupBox5.Controls.Add(boxRemain);
            groupBox5.Controls.Add(label14);
            groupBox5.Controls.Add(label13);
            groupBox5.Controls.Add(label12);
            groupBox5.Controls.Add(label11);
            groupBox5.Controls.Add(label10);
            groupBox5.Location = new Point(530, 265);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(290, 201);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "Result";
            // 
            // fullTruckNr
            // 
            fullTruckNr.Location = new Point(15, 61);
            fullTruckNr.Name = "fullTruckNr";
            fullTruckNr.Size = new Size(83, 31);
            fullTruckNr.TabIndex = 8;
            fullTruckNr.TextChanged += fullTruckNr_TextChanged;
            // 
            // fullPalletNr
            // 
            fullPalletNr.Location = new Point(11, 137);
            fullPalletNr.Name = "fullPalletNr";
            fullPalletNr.Size = new Size(87, 31);
            fullPalletNr.TabIndex = 7;
            fullPalletNr.TextChanged += fullPalletNr_TextChanged;
            // 
            // palletRemain
            // 
            palletRemain.Location = new Point(199, 126);
            palletRemain.Name = "palletRemain";
            palletRemain.Size = new Size(61, 31);
            palletRemain.TabIndex = 6;
            palletRemain.TextChanged += palletRemain_TextChanged;
            // 
            // boxRemain
            // 
            boxRemain.Location = new Point(199, 68);
            boxRemain.Name = "boxRemain";
            boxRemain.Size = new Size(63, 31);
            boxRemain.TabIndex = 5;
            boxRemain.TextChanged += boxRemain_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(135, 125);
            label14.Name = "label14";
            label14.Size = new Size(61, 25);
            label14.TabIndex = 4;
            label14.Text = "Pallets";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(135, 68);
            label13.Name = "label13";
            label13.Size = new Size(58, 25);
            label13.TabIndex = 3;
            label13.Text = "Boxes";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(135, 27);
            label12.Name = "label12";
            label12.Size = new Size(136, 25);
            label12.TabIndex = 2;
            label12.Text = "How many left?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(6, 102);
            label11.Name = "label11";
            label11.Size = new Size(85, 25);
            label11.TabIndex = 1;
            label11.Text = "Full Pallet";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(6, 27);
            label10.Name = "label10";
            label10.Size = new Size(92, 25);
            label10.TabIndex = 0;
            label10.Text = "Full Trucks";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 478);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private Label label8;
        private TextBox maxBoxA;
        private TextBox maxPalletA;
        private TextBox maxBoxB;
        private TextBox maxPalletB;
        private TextBox maxBoxC;
        private TextBox maxPalletC;
        private TextBox userBoxes;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Label label9;
        private GroupBox groupBox5;
        private Label label11;
        private Label label10;
        private TextBox fullTruckNr;
        private TextBox fullPalletNr;
        private TextBox palletRemain;
        private TextBox boxRemain;
        private Label label14;
        private Label label13;
        private Label label12;
    }
}
