
namespace Bakery
{
    partial class AddForm
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
            label1 = new System.Windows.Forms.Label();
            BreadFilter = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            BreadAdder = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            sandwichName = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(16, 52);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 25);
            label1.TabIndex = 7;
            label1.Text = "Bread:";
            // 
            // BreadFilter
            // 
            BreadFilter.AllowDrop = true;
            BreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BreadFilter.FormattingEnabled = true;
            BreadFilter.Items.AddRange(new object[] { "Ciabatta", "Focaccia", "Sour Dough", "Rye", "Whole Wheat" });
            BreadFilter.Location = new System.Drawing.Point(125, 50);
            BreadFilter.Margin = new System.Windows.Forms.Padding(2);
            BreadFilter.Name = "BreadFilter";
            BreadFilter.Size = new System.Drawing.Size(473, 33);
            BreadFilter.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(16, 97);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(103, 25);
            label2.TabIndex = 9;
            label2.Text = "Ingredients:";
            // 
            // BreadAdder
            // 
            BreadAdder.Location = new System.Drawing.Point(16, 306);
            BreadAdder.Margin = new System.Windows.Forms.Padding(2);
            BreadAdder.Name = "BreadAdder";
            BreadAdder.Size = new System.Drawing.Size(574, 36);
            BreadAdder.TabIndex = 10;
            BreadAdder.Text = "Add Sandwich";
            BreadAdder.UseVisualStyleBackColor = true;
            BreadAdder.Click += BreadAdder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(16, 17);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 25);
            label3.TabIndex = 11;
            label3.Text = "Name:";
            // 
            // sandwichName
            // 
            sandwichName.Location = new System.Drawing.Point(125, 15);
            sandwichName.Margin = new System.Windows.Forms.Padding(2);
            sandwichName.Name = "sandwichName";
            sandwichName.Size = new System.Drawing.Size(473, 31);
            sandwichName.TabIndex = 12;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(615, 352);
            Controls.Add(sandwichName);
            Controls.Add(label3);
            Controls.Add(BreadAdder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BreadFilter);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "AddForm";
            Text = "Add New Sandwich";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BreadFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BreadAdder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sandwichName;
    }
}

