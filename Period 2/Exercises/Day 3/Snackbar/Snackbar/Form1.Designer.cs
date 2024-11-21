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
            orderButton = new Button();
            shnackViewer = new ListView();
            label2 = new Label();
            adminView = new Button();
            groupBox2 = new GroupBox();
            orderedItems = new ListBox();
            totalDue = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            loempiaNR = new NumericUpDown();
            KaasNR = new NumericUpDown();
            MexiNR = new NumericUpDown();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)loempiaNR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KaasNR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MexiNR).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 9);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 0;
            label1.Text = "ShnackyWhacky";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(MexiNR);
            groupBox1.Controls.Add(KaasNR);
            groupBox1.Controls.Add(loempiaNR);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(orderButton);
            groupBox1.Controls.Add(shnackViewer);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(323, 375);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menu";
            // 
            // orderButton
            // 
            orderButton.Location = new Point(108, 311);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(112, 34);
            orderButton.TabIndex = 3;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // shnackViewer
            // 
            shnackViewer.Location = new Point(16, 135);
            shnackViewer.Name = "shnackViewer";
            shnackViewer.Size = new Size(286, 152);
            shnackViewer.TabIndex = 2;
            shnackViewer.UseCompatibleStateImageBehavior = false;
            shnackViewer.SelectedIndexChanged += shnackViewer_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 12);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Shnacky";
            // 
            // adminView
            // 
            adminView.Location = new Point(518, 392);
            adminView.Name = "adminView";
            adminView.Size = new Size(112, 34);
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
            groupBox2.Location = new Point(373, 56);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 330);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Overview";
            // 
            // orderedItems
            // 
            orderedItems.FormattingEnabled = true;
            orderedItems.ItemHeight = 25;
            orderedItems.Location = new Point(16, 46);
            orderedItems.Name = "orderedItems";
            orderedItems.Size = new Size(163, 229);
            orderedItems.TabIndex = 3;
            orderedItems.SelectedIndexChanged += orderedItems_SelectedIndexChanged;
            // 
            // totalDue
            // 
            totalDue.AutoSize = true;
            totalDue.Location = new Point(102, 278);
            totalDue.Name = "totalDue";
            totalDue.Size = new Size(77, 25);
            totalDue.TabIndex = 2;
            totalDue.Text = "Amount";
            totalDue.Click += totalDue_Click;
            // 
            // button1
            // 
            button1.Location = new Point(240, 266);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 278);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 0;
            label3.Text = "Total Due:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 58);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 4;
            label4.Text = "Loempia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(108, 58);
            label5.Name = "label5";
            label5.Size = new Size(97, 25);
            label5.TabIndex = 5;
            label5.Text = "Kaastengel";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(215, 58);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 6;
            label6.Text = "Mexicano";
            // 
            // loempiaNR
            // 
            loempiaNR.Location = new Point(17, 91);
            loempiaNR.Name = "loempiaNR";
            loempiaNR.Size = new Size(79, 31);
            loempiaNR.TabIndex = 7;
            // 
            // KaasNR
            // 
            KaasNR.Location = new Point(108, 91);
            KaasNR.Name = "KaasNR";
            KaasNR.Size = new Size(97, 31);
            KaasNR.TabIndex = 8;
            // 
            // MexiNR
            // 
            MexiNR.Location = new Point(215, 91);
            MexiNR.Name = "MexiNR";
            MexiNR.Size = new Size(87, 31);
            MexiNR.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(adminView);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)loempiaNR).EndInit();
            ((System.ComponentModel.ISupportInitialize)KaasNR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MexiNR).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListView shnackViewer;
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
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
