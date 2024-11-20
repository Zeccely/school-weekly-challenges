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
            expenseName = new TextBox();
            expenseCost = new NumericUpDown();
            expenseAdder = new Button();
            allExpenses = new Button();
            label3 = new Label();
            numericUpDown2 = new NumericUpDown();
            sameTypeExpense = new Button();
            overviewer = new ListBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)expenseCost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.Location = new Point(6, 43);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(42, 15);
            labelAmount.TabIndex = 0;
            labelAmount.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
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
            groupBox1.Location = new Point(27, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(313, 211);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Expense Form";
            // 
            // expenseName
            // 
            expenseName.Location = new Point(63, 40);
            expenseName.Name = "expenseName";
            expenseName.Size = new Size(100, 23);
            expenseName.TabIndex = 2;
            expenseName.TextChanged += expenseName_TextChanged;
            // 
            // expenseCost
            // 
            expenseCost.Location = new Point(63, 93);
            expenseCost.Name = "expenseCost";
            expenseCost.Size = new Size(100, 23);
            expenseCost.TabIndex = 3;
            expenseCost.ValueChanged += expenseCost_ValueChanged;
            // 
            // expenseAdder
            // 
            expenseAdder.Location = new Point(36, 141);
            expenseAdder.Name = "expenseAdder";
            expenseAdder.Size = new Size(224, 40);
            expenseAdder.TabIndex = 4;
            expenseAdder.Text = "Add expense to log";
            expenseAdder.UseVisualStyleBackColor = true;
            expenseAdder.Click += expenseAdder_Click;
            // 
            // allExpenses
            // 
            allExpenses.Location = new Point(27, 262);
            allExpenses.Name = "allExpenses";
            allExpenses.Size = new Size(313, 47);
            allExpenses.TabIndex = 3;
            allExpenses.Text = "Show all expenses";
            allExpenses.UseVisualStyleBackColor = true;
            allExpenses.Click += allExpenses_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 353);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Amount";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(83, 351);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // sameTypeExpense
            // 
            sameTypeExpense.Location = new Point(24, 386);
            sameTypeExpense.Name = "sameTypeExpense";
            sameTypeExpense.Size = new Size(316, 27);
            sameTypeExpense.TabIndex = 6;
            sameTypeExpense.Text = "Show all expenses of this type";
            sameTypeExpense.UseVisualStyleBackColor = true;
            sameTypeExpense.Click += sameTypeExpense_Click;
            // 
            // overviewer
            // 
            overviewer.FormattingEnabled = true;
            overviewer.ItemHeight = 15;
            overviewer.Location = new Point(361, 43);
            overviewer.Name = "overviewer";
            overviewer.Size = new Size(302, 364);
            overviewer.TabIndex = 7;
            overviewer.SelectedIndexChanged += overviewer_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(677, 431);
            Controls.Add(overviewer);
            Controls.Add(sameTypeExpense);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(allExpenses);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)expenseCost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
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
        private NumericUpDown numericUpDown2;
        private Button sameTypeExpense;
        private ListBox overviewer;
    }
}
