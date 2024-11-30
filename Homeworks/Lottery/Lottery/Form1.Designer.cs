namespace Lottery
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
            Addnumber = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            groupBox1 = new GroupBox();
            listView1 = new ListView();
            groupBox2 = new GroupBox();
            button1 = new Button();
            nrlength = new NumericUpDown();
            maxVal = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            LotteryNumbers = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nrlength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxVal).BeginInit();
            SuspendLayout();
            // 
            // Addnumber
            // 
            Addnumber.Location = new Point(21, 86);
            Addnumber.Name = "Addnumber";
            Addnumber.Size = new Size(105, 27);
            Addnumber.TabIndex = 0;
            Addnumber.Text = "Add Number";
            Addnumber.UseVisualStyleBackColor = true;
            Addnumber.Click += numberadd_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(89, 57);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(70, 23);
            numericUpDown1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 29);
            label1.Name = "label1";
            label1.Size = new Size(163, 15);
            label1.TabIndex = 2;
            label1.Text = "Please Choose your numbers!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Addnumber);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Location = new Point(12, 167);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 200);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottery Play!";
            // 
            // listView1
            // 
            listView1.Location = new Point(37, 119);
            listView1.Name = "listView1";
            listView1.Size = new Size(186, 64);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(nrlength);
            groupBox2.Controls.Add(maxVal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 11);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 150);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lottery Settings";
            // 
            // button1
            // 
            button1.Location = new Point(152, 88);
            button1.Name = "button1";
            button1.Size = new Size(97, 25);
            button1.TabIndex = 9;
            button1.Text = "Lotto!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Lotto_Click;
            // 
            // nrlength
            // 
            nrlength.Location = new Point(6, 104);
            nrlength.Name = "nrlength";
            nrlength.Size = new Size(120, 23);
            nrlength.TabIndex = 8;
            // 
            // maxVal
            // 
            maxVal.Location = new Point(6, 51);
            maxVal.Name = "maxVal";
            maxVal.Size = new Size(120, 23);
            maxVal.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 86);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 6;
            label3.Text = "How many numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 33);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Max Value";
            // 
            // LotteryNumbers
            // 
            LotteryNumbers.FormattingEnabled = true;
            LotteryNumbers.ItemHeight = 15;
            LotteryNumbers.Location = new Point(284, 177);
            LotteryNumbers.Name = "LotteryNumbers";
            LotteryNumbers.Size = new Size(272, 184);
            LotteryNumbers.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 379);
            Controls.Add(LotteryNumbers);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nrlength).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxVal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Addnumber;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView listView1;
        private ListBox LotteryNumbers;
        private Label label2;
        private NumericUpDown nrlength;
        private NumericUpDown maxVal;
        private Label label3;
        private Button button1;
    }
}
