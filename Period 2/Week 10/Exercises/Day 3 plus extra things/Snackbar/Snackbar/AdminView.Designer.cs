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
            revenuer = new Label();
            textBox1 = new TextBox();
            totalItems = new ListBox();
            SuspendLayout();
            // 
            // revenuer
            // 
            revenuer.AutoSize = true;
            revenuer.Location = new Point(12, 9);
            revenuer.Name = "revenuer";
            revenuer.Size = new Size(52, 15);
            revenuer.TabIndex = 0;
            revenuer.Text = "Revenue";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // totalItems
            // 
            totalItems.FormattingEnabled = true;
            totalItems.ItemHeight = 15;
            totalItems.Location = new Point(12, 47);
            totalItems.Name = "totalItems";
            totalItems.Size = new Size(284, 139);
            totalItems.TabIndex = 2;
            totalItems.SelectedIndexChanged += totalItems_SelectedIndexChanged;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(308, 200);
            Controls.Add(totalItems);
            Controls.Add(textBox1);
            Controls.Add(revenuer);
            Name = "AdminView";
            Text = "AdminView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label revenuer;
        private TextBox textBox1;
        private ListBox totalItems;
    }
}