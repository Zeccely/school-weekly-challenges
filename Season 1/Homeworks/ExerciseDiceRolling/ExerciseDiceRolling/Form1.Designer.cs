namespace ExerciseDiceRolling
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
            pressLabel = new Label();
            diceRoller = new Button();
            SuspendLayout();
            // 
            // pressLabel
            // 
            pressLabel.AutoSize = true;
            pressLabel.Location = new Point(66, 38);
            pressLabel.Name = "pressLabel";
            pressLabel.Size = new Size(93, 15);
            pressLabel.TabIndex = 2;
            pressLabel.Text = "Press to roll dice";
            // 
            // diceRoller
            // 
            diceRoller.Location = new Point(57, 71);
            diceRoller.Name = "diceRoller";
            diceRoller.Size = new Size(114, 40);
            diceRoller.TabIndex = 3;
            diceRoller.Text = "Good Luck";
            diceRoller.UseVisualStyleBackColor = true;
            diceRoller.Click += diceRoller_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 167);
            Controls.Add(diceRoller);
            Controls.Add(pressLabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label pressLabel;
        private Button diceRoller;
    }
}
