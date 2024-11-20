namespace Exercise_3
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
            speedUP = new Button();
            slowDOWN = new Button();
            displayer = new Label();
            SuspendLayout();
            // 
            // speedUP
            // 
            speedUP.BackColor = Color.LightGreen;
            speedUP.Font = new Font("Magneto", 20F, FontStyle.Bold);
            speedUP.ForeColor = Color.LimeGreen;
            speedUP.Location = new Point(12, 137);
            speedUP.Name = "speedUP";
            speedUP.Size = new Size(290, 97);
            speedUP.TabIndex = 0;
            speedUP.Text = "Vroom Vroom";
            speedUP.UseVisualStyleBackColor = false;
            speedUP.Click += speedUP_Click;
            // 
            // slowDOWN
            // 
            slowDOWN.BackColor = Color.Salmon;
            slowDOWN.Font = new Font("Magneto", 20F, FontStyle.Bold);
            slowDOWN.ForeColor = Color.IndianRed;
            slowDOWN.Location = new Point(324, 137);
            slowDOWN.Name = "slowDOWN";
            slowDOWN.Size = new Size(289, 97);
            slowDOWN.TabIndex = 1;
            slowDOWN.Text = "Vreeeeeee";
            slowDOWN.UseVisualStyleBackColor = false;
            slowDOWN.Click += slowDOWN_Click;
            // 
            // displayer
            // 
            displayer.AutoSize = true;
            displayer.Font = new Font("Segoe UI", 19F);
            displayer.Location = new Point(87, 54);
            displayer.Name = "displayer";
            displayer.Size = new Size(441, 36);
            displayer.TabIndex = 2;
            displayer.Text = "Nothing is happening at the moment";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 275);
            Controls.Add(displayer);
            Controls.Add(slowDOWN);
            Controls.Add(speedUP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button speedUP;
        private Button slowDOWN;
        private Label displayer;
    }
}
