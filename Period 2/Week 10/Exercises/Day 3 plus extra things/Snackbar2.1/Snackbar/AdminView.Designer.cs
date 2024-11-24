namespace Snackbar
{
    partial class AdminView
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
            totalItems = new ListBox();
            calculate = new Button();
            grandtotaly = new Label();
            SuspendLayout();
            // 
            // totalItems
            // 
            totalItems.FormattingEnabled = true;
            totalItems.ItemHeight = 15;
            totalItems.Location = new Point(12, 47);
            totalItems.Name = "totalItems";
            totalItems.Size = new Size(284, 124);
            totalItems.TabIndex = 2;
            // 
            // calculate
            // 
            calculate.Location = new Point(12, 12);
            calculate.Name = "calculate";
            calculate.Size = new Size(112, 29);
            calculate.TabIndex = 3;
            calculate.Text = "Calculate Total";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // grandtotaly
            // 
            grandtotaly.AutoSize = true;
            grandtotaly.Location = new Point(198, 19);
            grandtotaly.Name = "grandtotaly";
            grandtotaly.Size = new Size(32, 15);
            grandtotaly.TabIndex = 4;
            grandtotaly.Text = "Total";
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 200);
            Controls.Add(grandtotaly);
            Controls.Add(calculate);
            Controls.Add(totalItems);
            Name = "AdminView";
            Text = "AdminView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox totalItems;
        private Button calculate;
        private Label grandtotaly;
    }
}