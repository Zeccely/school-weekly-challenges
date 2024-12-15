
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
            ingredients = new System.Windows.Forms.ComboBox();
            confirmationlbl = new System.Windows.Forms.Label();
            RemoveBtn = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 36);
            label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 15);
            label1.TabIndex = 7;
            label1.Text = "Bread:";
            // 
            // BreadFilter
            // 
            BreadFilter.AllowDrop = true;
            BreadFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            BreadFilter.FormattingEnabled = true;
            BreadFilter.Items.AddRange(new object[] { "Ciabatta", "Focaccia", "Sour Dough", "Rye", "Whole Wheat" });
            BreadFilter.Location = new System.Drawing.Point(88, 33);
            BreadFilter.Margin = new System.Windows.Forms.Padding(1);
            BreadFilter.Name = "BreadFilter";
            BreadFilter.Size = new System.Drawing.Size(332, 23);
            BreadFilter.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(10, 60);
            label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 15);
            label2.TabIndex = 9;
            label2.Text = "Ingredients:";
            label2.Click += label2_Click;
            // 
            // BreadAdder
            // 
            BreadAdder.Location = new System.Drawing.Point(12, 148);
            BreadAdder.Margin = new System.Windows.Forms.Padding(1);
            BreadAdder.Name = "BreadAdder";
            BreadAdder.Size = new System.Drawing.Size(402, 22);
            BreadAdder.TabIndex = 10;
            BreadAdder.Text = "Add Sandwich";
            BreadAdder.UseVisualStyleBackColor = true;
            BreadAdder.Click += BreadAdder_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(12, 12);
            label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 15);
            label3.TabIndex = 11;
            label3.Text = "Name:";
            // 
            // sandwichName
            // 
            sandwichName.Location = new System.Drawing.Point(88, 9);
            sandwichName.Margin = new System.Windows.Forms.Padding(1);
            sandwichName.Name = "sandwichName";
            sandwichName.Size = new System.Drawing.Size(332, 23);
            sandwichName.TabIndex = 12;
            // 
            // ingredients
            // 
            ingredients.FormattingEnabled = true;
            ingredients.Location = new System.Drawing.Point(88, 57);
            ingredients.Name = "ingredients";
            ingredients.Size = new System.Drawing.Size(332, 23);
            ingredients.TabIndex = 13;
            // 
            // confirmationlbl
            // 
            confirmationlbl.AutoSize = true;
            confirmationlbl.Location = new System.Drawing.Point(129, 106);
            confirmationlbl.Name = "confirmationlbl";
            confirmationlbl.Size = new System.Drawing.Size(58, 15);
            confirmationlbl.TabIndex = 14;
            confirmationlbl.Text = "Hmmm...";
            // 
            // RemoveBtn
            // 
            RemoveBtn.Location = new System.Drawing.Point(10, 174);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new System.Drawing.Size(404, 23);
            RemoveBtn.TabIndex = 15;
            RemoveBtn.Text = "Remove Sandwich";
            RemoveBtn.UseVisualStyleBackColor = true;
            RemoveBtn.Click += RemoveBtn_Click;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(430, 211);
            Controls.Add(RemoveBtn);
            Controls.Add(confirmationlbl);
            Controls.Add(ingredients);
            Controls.Add(sandwichName);
            Controls.Add(label3);
            Controls.Add(BreadAdder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BreadFilter);
            Margin = new System.Windows.Forms.Padding(1);
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
        private System.Windows.Forms.ComboBox ingredients;
        private System.Windows.Forms.Label confirmationlbl;
        private System.Windows.Forms.Button RemoveBtn;
    }
}

