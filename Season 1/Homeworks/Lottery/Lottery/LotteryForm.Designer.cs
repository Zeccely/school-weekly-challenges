namespace Lottery
{
    partial class LotteryForm
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
            choosenumbers = new NumericUpDown();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            chosenview = new ListView();
            groupBox2 = new GroupBox();
            settingsSave = new Button();
            nrlength = new NumericUpDown();
            maxVal = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            LotteryNumbers = new ListBox();
            ((System.ComponentModel.ISupportInitialize)choosenumbers).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nrlength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxVal).BeginInit();
            SuspendLayout();
            // 
            // Addnumber
            // 
            Addnumber.Location = new Point(30, 143);
            Addnumber.Margin = new Padding(4, 5, 4, 5);
            Addnumber.Name = "Addnumber";
            Addnumber.Size = new Size(150, 45);
            Addnumber.TabIndex = 0;
            Addnumber.Text = "Add Number";
            Addnumber.UseVisualStyleBackColor = true;
            Addnumber.Click += numberadd_Click;
            // 
            // choosenumbers
            // 
            choosenumbers.Location = new Point(127, 95);
            choosenumbers.Margin = new Padding(4, 5, 4, 5);
            choosenumbers.Name = "choosenumbers";
            choosenumbers.Size = new Size(100, 31);
            choosenumbers.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 25);
            label1.TabIndex = 2;
            label1.Text = "Please Choose your numbers!";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(chosenview);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(Addnumber);
            groupBox1.Controls.Add(choosenumbers);
            groupBox1.Location = new Point(17, 278);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(380, 333);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lottery Play!";
            // 
            // button1
            // 
            button1.Location = new Point(217, 147);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(139, 42);
            button1.TabIndex = 9;
            button1.Text = "Lotto!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Lotto_Click;
            // 
            // chosenview
            // 
            chosenview.Location = new Point(53, 198);
            chosenview.Margin = new Padding(4, 5, 4, 5);
            chosenview.Name = "chosenview";
            chosenview.Size = new Size(270, 107);
            chosenview.TabIndex = 6;
            chosenview.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(settingsSave);
            groupBox2.Controls.Add(nrlength);
            groupBox2.Controls.Add(maxVal);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(17, 18);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(380, 250);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lottery Settings";
            // 
            // settingsSave
            // 
            settingsSave.Location = new Point(217, 173);
            settingsSave.Margin = new Padding(4, 5, 4, 5);
            settingsSave.Name = "settingsSave";
            settingsSave.Size = new Size(107, 38);
            settingsSave.TabIndex = 9;
            settingsSave.Text = "Save";
            settingsSave.UseVisualStyleBackColor = true;
            settingsSave.Click += settingsSave_Click;
            // 
            // nrlength
            // 
            nrlength.Location = new Point(9, 173);
            nrlength.Margin = new Padding(4, 5, 4, 5);
            nrlength.Name = "nrlength";
            nrlength.Size = new Size(171, 31);
            nrlength.TabIndex = 8;
            // 
            // maxVal
            // 
            maxVal.Location = new Point(9, 85);
            maxVal.Margin = new Padding(4, 5, 4, 5);
            maxVal.Name = "maxVal";
            maxVal.Size = new Size(171, 31);
            maxVal.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 143);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(173, 25);
            label3.TabIndex = 6;
            label3.Text = "How many numbers";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 0;
            label2.Text = "Max Value";
            // 
            // LotteryNumbers
            // 
            LotteryNumbers.FormattingEnabled = true;
            LotteryNumbers.ItemHeight = 25;
            LotteryNumbers.Location = new Point(406, 295);
            LotteryNumbers.Margin = new Padding(4, 5, 4, 5);
            LotteryNumbers.Name = "LotteryNumbers";
            LotteryNumbers.Size = new Size(387, 304);
            LotteryNumbers.TabIndex = 5;
            // 
            // LotteryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 632);
            Controls.Add(LotteryNumbers);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "LotteryForm";
            Text = "Lottery";
            ((System.ComponentModel.ISupportInitialize)choosenumbers).EndInit();
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
        private NumericUpDown choosenumbers;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListView chosenview;
        private ListBox LotteryNumbers;
        private Label label2;
        private NumericUpDown nrlength;
        private NumericUpDown maxVal;
        private Label label3;
        private Button button1;
        private Button settingsSave;
    }
}
