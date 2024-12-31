namespace CarSales
{
    partial class AdminForm
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
            soldcarslbl = new Label();
            availableCarslbx = new ListBox();
            soldCarslbx = new ListBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // soldcarslbl
            // 
            soldcarslbl.AutoSize = true;
            soldcarslbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            soldcarslbl.Location = new Point(240, 9);
            soldcarslbl.Name = "soldcarslbl";
            soldcarslbl.Size = new Size(76, 21);
            soldcarslbl.TabIndex = 0;
            soldcarslbl.Text = "Sold Cars";
            // 
            // availableCarslbx
            // 
            availableCarslbx.FormattingEnabled = true;
            availableCarslbx.ItemHeight = 15;
            availableCarslbx.Location = new Point(12, 33);
            availableCarslbx.Name = "availableCarslbx";
            availableCarslbx.Size = new Size(170, 184);
            availableCarslbx.TabIndex = 1;
            // 
            // soldCarslbx
            // 
            soldCarslbx.FormattingEnabled = true;
            soldCarslbx.ItemHeight = 15;
            soldCarslbx.Location = new Point(188, 33);
            soldCarslbx.Name = "soldCarslbx";
            soldCarslbx.Size = new Size(179, 184);
            soldCarslbx.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 21);
            label1.TabIndex = 3;
            label1.Text = "Available Cars";
            // 
            // button1
            // 
            button1.Location = new Point(41, 231);
            button1.Name = "button1";
            button1.Size = new Size(108, 23);
            button1.TabIndex = 4;
            button1.Text = "Show Available";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(225, 231);
            button2.Name = "button2";
            button2.Size = new Size(108, 23);
            button2.TabIndex = 5;
            button2.Text = "Show Sold";
            button2.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 266);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(soldCarslbx);
            Controls.Add(availableCarslbx);
            Controls.Add(soldcarslbl);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label soldcarslbl;
        private ListBox availableCarslbx;
        private ListBox soldCarslbx;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}