namespace Snackbar
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
            groupBox1 = new GroupBox();
            MexiNR = new NumericUpDown();
            KaasNR = new NumericUpDown();
            loempiaNR = new NumericUpDown();
            mexiName = new Label();
            kaasName = new Label();
            loempiaName = new Label();
            orderButton = new Button();
            label2 = new Label();
            adminView = new Button();
            groupBox2 = new GroupBox();
            orderedItems = new ListBox();
            totalDue = new Label();
            button1 = new Button();
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MexiNR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KaasNR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loempiaNR).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "ShnackyWhacky";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MexiNR);
            groupBox1.Controls.Add(KaasNR);
            groupBox1.Controls.Add(loempiaNR);
            groupBox1.Controls.Add(mexiName);
            groupBox1.Controls.Add(kaasName);
            groupBox1.Controls.Add(loempiaName);
            groupBox1.Controls.Add(orderButton);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(8, 26);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(226, 225);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // MexiNR
            // 
            MexiNR.Location = new Point(150, 55);
            MexiNR.Margin = new Padding(2);
            MexiNR.Name = "MexiNR";
            MexiNR.Size = new Size(61, 23);
            MexiNR.TabIndex = 9;
            MexiNR.ValueChanged += MexiNR_ValueChanged;
            // 
            // KaasNR
            // 
            KaasNR.Location = new Point(76, 55);
            KaasNR.Margin = new Padding(2);
            KaasNR.Name = "KaasNR";
            KaasNR.Size = new Size(68, 23);
            KaasNR.TabIndex = 8;
            KaasNR.ValueChanged += KaasNR_ValueChanged;
            // 
            // loempiaNR
            // 
            loempiaNR.Location = new Point(12, 55);
            loempiaNR.Margin = new Padding(2);
            loempiaNR.Name = "loempiaNR";
            loempiaNR.Size = new Size(55, 23);
            loempiaNR.TabIndex = 7;
            loempiaNR.ValueChanged += loempiaNR_ValueChanged;
            // 
            // mexiName
            // 
            mexiName.AutoSize = true;
            mexiName.Location = new Point(150, 35);
            mexiName.Margin = new Padding(2, 0, 2, 0);
            mexiName.Name = "mexiName";
            mexiName.Size = new Size(59, 15);
            mexiName.TabIndex = 6;
            mexiName.Text = "Mexicano";
            // 
            // kaasName
            // 
            kaasName.AutoSize = true;
            kaasName.Location = new Point(76, 35);
            kaasName.Margin = new Padding(2, 0, 2, 0);
            kaasName.Name = "kaasName";
            kaasName.Size = new Size(69, 15);
            kaasName.TabIndex = 5;
            kaasName.Text = "Kaastengels";
            // 
            // loempiaName
            // 
            loempiaName.AutoSize = true;
            loempiaName.Location = new Point(11, 35);
            loempiaName.Margin = new Padding(2, 0, 2, 0);
            loempiaName.Name = "loempiaName";
            loempiaName.Size = new Size(53, 15);
            loempiaName.TabIndex = 4;
            loempiaName.Text = "Loempia";
            // 
            // orderButton
            // 
            orderButton.Location = new Point(66, 93);
            orderButton.Margin = new Padding(2);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(78, 20);
            orderButton.TabIndex = 3;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 7);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Shnacky";
            // 
            // adminView
            // 
            adminView.Location = new Point(363, 235);
            adminView.Margin = new Padding(2);
            adminView.Name = "adminView";
            adminView.Size = new Size(81, 24);
            adminView.TabIndex = 2;
            adminView.Text = "Admin";
            adminView.UseVisualStyleBackColor = true;
            adminView.Click += adminView_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(orderedItems);
            groupBox2.Controls.Add(totalDue);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(261, 34);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(276, 198);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Overview";
            // 
            // orderedItems
            // 
            orderedItems.FormattingEnabled = true;
            orderedItems.ItemHeight = 15;
            orderedItems.Location = new Point(11, 28);
            orderedItems.Margin = new Padding(2);
            orderedItems.Name = "orderedItems";
            orderedItems.Size = new Size(115, 139);
            orderedItems.TabIndex = 3;
            orderedItems.SelectedIndexChanged += orderedItems_SelectedIndexChanged;
            // 
            // totalDue
            // 
            totalDue.AutoSize = true;
            totalDue.Location = new Point(71, 167);
            totalDue.Margin = new Padding(2, 0, 2, 0);
            totalDue.Name = "totalDue";
            totalDue.Size = new Size(51, 15);
            totalDue.TabIndex = 2;
            totalDue.Text = "Amount";
            totalDue.Click += totalDue_Click;
            // 
            // button1
            // 
            button1.Location = new Point(168, 160);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(79, 22);
            button1.TabIndex = 1;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 167);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 0;
            label3.Text = "Total Due:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(groupBox2);
            Controls.Add(adminView);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MexiNR).EndInit();
            ((System.ComponentModel.ISupportInitialize)KaasNR).EndInit();
            ((System.ComponentModel.ISupportInitialize)loempiaNR).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button orderButton;
        private Button adminView;
        private GroupBox groupBox2;
        private Button button1;
        private Label label3;
        private ListBox orderedItems;
        private Label totalDue;
        private NumericUpDown MexiNR;
        private NumericUpDown KaasNR;
        private NumericUpDown loempiaNR;
        private Label mexiName;
        private Label kaasName;
        private Label loempiaName;
    }
}
