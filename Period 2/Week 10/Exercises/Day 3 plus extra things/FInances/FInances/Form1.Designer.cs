namespace FInances
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
            labelAmount = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            expenseAdder = new Button();
            expenseCost = new NumericUpDown();
            expenseName = new TextBox();
            allExpenses = new Button();
            label3 = new Label();
            sameAmountNM = new NumericUpDown();
            sameTypeExpense = new Button();
            overviewer = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expenseCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sameAmountNM).BeginInit();
            SuspendLayout();
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(9, 72);
            labelAmount.Margin = new Padding(4, 0, 4, 0);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(63, 25);
            labelAmount.TabIndex = 0;
            labelAmount.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 158);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(expenseAdder);
            groupBox1.Controls.Add(expenseCost);
            groupBox1.Controls.Add(expenseName);
            groupBox1.Controls.Add(labelAmount);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(39, 57);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(447, 352);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expense Form";
            // 
            // expenseAdder
            // 
            expenseAdder.Location = new Point(51, 235);
            expenseAdder.Margin = new Padding(4, 5, 4, 5);
            expenseAdder.Name = "expenseAdder";
            expenseAdder.Size = new Size(320, 67);
            expenseAdder.TabIndex = 4;
            expenseAdder.Text = "Add expense to log";
            expenseAdder.UseVisualStyleBackColor = true;
            expenseAdder.Click += expenseAdder_Click;
            // 
            // expenseCost
            // 
            expenseCost.Location = new Point(90, 155);
            expenseCost.Margin = new Padding(4, 5, 4, 5);
            expenseCost.Name = "expenseCost";
            expenseCost.Size = new Size(143, 31);
            expenseCost.TabIndex = 3;
            expenseCost.ValueChanged += expenseCost_ValueChanged;
            // 
            // expenseName
            // 
            expenseName.Location = new Point(90, 67);
            expenseName.Margin = new Padding(4, 5, 4, 5);
            expenseName.Name = "expenseName";
            expenseName.Size = new Size(141, 31);
            expenseName.TabIndex = 2;
            expenseName.TextChanged += expenseName_TextChanged;
            // 
            // allExpenses
            // 
            allExpenses.Location = new Point(39, 437);
            allExpenses.Margin = new Padding(4, 5, 4, 5);
            allExpenses.Name = "allExpenses";
            allExpenses.Size = new Size(447, 78);
            allExpenses.TabIndex = 3;
            allExpenses.Text = "Show all expenses";
            allExpenses.UseVisualStyleBackColor = true;
            allExpenses.Click += allExpenses_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 588);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 4;
            label3.Text = "Amount";
            // 
            // sameAmountNM
            // 
            sameAmountNM.Location = new Point(119, 585);
            sameAmountNM.Margin = new Padding(4, 5, 4, 5);
            sameAmountNM.Name = "sameAmountNM";
            sameAmountNM.Size = new Size(171, 31);
            sameAmountNM.TabIndex = 5;
            sameAmountNM.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // sameTypeExpense
            // 
            sameTypeExpense.Location = new Point(34, 643);
            sameTypeExpense.Margin = new Padding(4, 5, 4, 5);
            sameTypeExpense.Name = "sameTypeExpense";
            sameTypeExpense.Size = new Size(451, 45);
            sameTypeExpense.TabIndex = 6;
            sameTypeExpense.Text = "Show all expenses of this type";
            sameTypeExpense.UseVisualStyleBackColor = true;
            sameTypeExpense.Click += sameTypeExpense_Click;
            // 
            // overviewer
            // 
            overviewer.FormattingEnabled = true;
            overviewer.ItemHeight = 25;
            overviewer.Location = new Point(516, 72);
            overviewer.Margin = new Padding(4, 5, 4, 5);
            overviewer.Name = "overviewer";
            overviewer.Size = new Size(430, 604);
            overviewer.TabIndex = 7;
            overviewer.SelectedIndexChanged += overviewer_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 718);
            Controls.Add(overviewer);
            Controls.Add(sameTypeExpense);
            Controls.Add(sameAmountNM);
            Controls.Add(label3);
            Controls.Add(allExpenses);
            Controls.Add(groupBox1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expenseCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)sameAmountNM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAmount;
        private Label label2;
        private GroupBox groupBox1;
        private Button expenseAdder;
        private NumericUpDown expenseCost;
        private TextBox expenseName;
        private Button allExpenses;
        private Label label3;
        private NumericUpDown sameAmountNM;
        private Button sameTypeExpense;
        private ListBox overviewer;
    }
}
