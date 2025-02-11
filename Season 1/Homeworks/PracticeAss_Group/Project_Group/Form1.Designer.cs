namespace Project_Group
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
            groupLabel = new Label();
            groupShow = new ListBox();
            adder = new Button();
            nameInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            studentNUM = new TextBox();
            SuspendLayout();
            // 
            // groupLabel
            // 
            groupLabel.AutoSize = true;
            groupLabel.Location = new Point(21, 9);
            groupLabel.Name = "groupLabel";
            groupLabel.Size = new Size(116, 25);
            groupLabel.TabIndex = 0;
            groupLabel.Text = "Group Maker";
            // 
            // groupShow
            // 
            groupShow.FormattingEnabled = true;
            groupShow.ItemHeight = 25;
            groupShow.Location = new Point(178, 12);
            groupShow.Name = "groupShow";
            groupShow.Size = new Size(244, 279);
            groupShow.TabIndex = 1;
            groupShow.SelectedIndexChanged += groupShow_SelectedIndexChanged;
            // 
            // adder
            // 
            adder.Location = new Point(9, 258);
            adder.Name = "adder";
            adder.Size = new Size(150, 33);
            adder.TabIndex = 2;
            adder.Text = "Add to Group";
            adder.UseVisualStyleBackColor = true;
            adder.Click += adder_Click;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(9, 88);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(150, 31);
            nameInput.TabIndex = 3;
            nameInput.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 60);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 134);
            label2.Name = "label2";
            label2.Size = new Size(102, 25);
            label2.TabIndex = 5;
            label2.Text = "Student NR";
            // 
            // studentNUM
            // 
            studentNUM.Location = new Point(9, 162);
            studentNUM.Name = "studentNUM";
            studentNUM.Size = new Size(150, 31);
            studentNUM.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 324);
            Controls.Add(studentNUM);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nameInput);
            Controls.Add(adder);
            Controls.Add(groupShow);
            Controls.Add(groupLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label groupLabel;
        private ListBox groupShow;
        private Button adder;
        private TextBox nameInput;
        private Label label1;
        private Label label2;
        private TextBox studentNUM;
    }
}
