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
            showAvCarsbtn = new Button();
            showSoldCarsbtn = new Button();
            customerslbx = new ListBox();
            Customerlbl = new Label();
            customerswitchbtn = new Button();
            customershowbtn = new Button();
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
            // showAvCarsbtn
            // 
            showAvCarsbtn.Location = new Point(41, 231);
            showAvCarsbtn.Name = "showAvCarsbtn";
            showAvCarsbtn.Size = new Size(108, 23);
            showAvCarsbtn.TabIndex = 4;
            showAvCarsbtn.Text = "Show Available";
            showAvCarsbtn.UseVisualStyleBackColor = true;
            showAvCarsbtn.Click += showAvCarsbtn_Click;
            // 
            // showSoldCarsbtn
            // 
            showSoldCarsbtn.Location = new Point(225, 233);
            showSoldCarsbtn.Name = "showSoldCarsbtn";
            showSoldCarsbtn.Size = new Size(108, 23);
            showSoldCarsbtn.TabIndex = 5;
            showSoldCarsbtn.Text = "Show Sold";
            showSoldCarsbtn.UseVisualStyleBackColor = true;
            showSoldCarsbtn.Click += showSoldCarsbtn_Click;
            // 
            // customerslbx
            // 
            customerslbx.FormattingEnabled = true;
            customerslbx.ItemHeight = 15;
            customerslbx.Location = new Point(373, 33);
            customerslbx.Name = "customerslbx";
            customerslbx.Size = new Size(179, 184);
            customerslbx.TabIndex = 6;
            // 
            // Customerlbl
            // 
            Customerlbl.AutoSize = true;
            Customerlbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customerlbl.Location = new Point(410, 9);
            Customerlbl.Name = "Customerlbl";
            Customerlbl.Size = new Size(106, 21);
            Customerlbl.TabIndex = 7;
            Customerlbl.Text = "Customer List";
            // 
            // customerswitchbtn
            // 
            customerswitchbtn.Location = new Point(410, 252);
            customerswitchbtn.Name = "customerswitchbtn";
            customerswitchbtn.Size = new Size(105, 23);
            customerswitchbtn.TabIndex = 8;
            customerswitchbtn.Text = "Switch Customer";
            customerswitchbtn.UseVisualStyleBackColor = true;
            customerswitchbtn.Click += customerswitchbtn_Click;
            // 
            // customershowbtn
            // 
            customershowbtn.Location = new Point(410, 223);
            customershowbtn.Name = "customershowbtn";
            customershowbtn.Size = new Size(105, 23);
            customershowbtn.TabIndex = 9;
            customershowbtn.Text = "Show Customers";
            customershowbtn.UseVisualStyleBackColor = true;
            customershowbtn.Click += customershowbtn_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 286);
            Controls.Add(customershowbtn);
            Controls.Add(customerswitchbtn);
            Controls.Add(Customerlbl);
            Controls.Add(customerslbx);
            Controls.Add(showSoldCarsbtn);
            Controls.Add(showAvCarsbtn);
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
        private Button showAvCarsbtn;
        private Button showSoldCarsbtn;
        private ListBox customerslbx;
        private Label Customerlbl;
        private Button customerswitchbtn;
        private Button customershowbtn;
    }
}