namespace Exercise_2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            weightIN = new TextBox();
            label13 = new Label();
            heightIN = new TextBox();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 22);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "BMI Calculations";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 2);
            tableLayoutPanel1.Controls.Add(label7, 1, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 3);
            tableLayoutPanel1.Controls.Add(label9, 1, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(label11, 1, 4);
            tableLayoutPanel1.Location = new Point(249, 52);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(233, 106);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 15);
            label2.TabIndex = 0;
            label2.Text = "Body Mass Index";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 1;
            label3.Text = "Explanation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 23);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 2;
            label4.Text = "BMI < 18.5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(119, 23);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 3;
            label5.Text = "Underweight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 46);
            label6.Name = "label6";
            label6.Size = new Size(94, 15);
            label6.TabIndex = 4;
            label6.Text = "18.5<=BMI<25,0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(119, 46);
            label7.Name = "label7";
            label7.Size = new Size(87, 15);
            label7.TabIndex = 5;
            label7.Text = "average weight";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 66);
            label8.Name = "label8";
            label8.Size = new Size(85, 15);
            label8.TabIndex = 6;
            label8.Text = "25,0<=BMI<30";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(119, 66);
            label9.Name = "label9";
            label9.Size = new Size(68, 15);
            label9.TabIndex = 7;
            label9.Text = "Overweight";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 86);
            label10.Name = "label10";
            label10.Size = new Size(68, 15);
            label10.TabIndex = 8;
            label10.Text = "BMI >=30,0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(119, 86);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 9;
            label11.Text = "Obese";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 55);
            label12.Name = "label12";
            label12.Size = new Size(75, 15);
            label12.TabIndex = 2;
            label12.Text = "Weight in KG";
            // 
            // weightIN
            // 
            weightIN.Location = new Point(114, 52);
            weightIN.Name = "weightIN";
            weightIN.Size = new Size(100, 23);
            weightIN.TabIndex = 3;
            weightIN.TextChanged += weight_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 90);
            label13.Name = "label13";
            label13.Size = new Size(95, 15);
            label13.TabIndex = 4;
            label13.Text = "Height in Meters";
            // 
            // heightIN
            // 
            heightIN.Location = new Point(114, 87);
            heightIN.Name = "heightIN";
            heightIN.Size = new Size(100, 23);
            heightIN.TabIndex = 5;
            heightIN.TextChanged += height_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(50, 131);
            button1.Name = "button1";
            button1.Size = new Size(139, 27);
            button1.TabIndex = 6;
            button1.Text = "Calculate BMI";
            button1.UseVisualStyleBackColor = true;
            button1.Click += calculatebmi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 199);
            Controls.Add(button1);
            Controls.Add(heightIN);
            Controls.Add(label13);
            Controls.Add(weightIN);
            Controls.Add(label12);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox weightIN;
        private Label label13;
        private TextBox heightIN;
        private Button button1;
    }
}
