namespace ExerciseDiceRolling
{
    partial class DiceResult
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
            rollResult = new PictureBox();
            rollresultlabel = new Label();
            ((System.ComponentModel.ISupportInitialize)rollResult).BeginInit();
            SuspendLayout();
            // 
            // rollResult
            // 
            rollResult.BackgroundImage = Properties.Resources.DiceFace1;
            rollResult.BackgroundImageLayout = ImageLayout.Stretch;
            rollResult.Location = new Point(73, 40);
            rollResult.Name = "rollResult";
            rollResult.Size = new Size(201, 201);
            rollResult.TabIndex = 1;
            rollResult.TabStop = false;
            // 
            // rollresultlabel
            // 
            rollresultlabel.AutoSize = true;
            rollresultlabel.Font = new Font("Segoe UI", 15F);
            rollresultlabel.Location = new Point(95, 9);
            rollresultlabel.Name = "rollresultlabel";
            rollresultlabel.Size = new Size(151, 28);
            rollresultlabel.TabIndex = 2;
            rollresultlabel.Text = "Dice Roll Result!";
            // 
            // DiceResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 253);
            Controls.Add(rollresultlabel);
            Controls.Add(rollResult);
            Name = "DiceResult";
            Text = "DiceResult";
            ((System.ComponentModel.ISupportInitialize)rollResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox rollResult;
        private Label rollresultlabel;
    }
}