namespace Exercise_1
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
            button1 = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            redmaker = new RadioButton();
            pinkMaker = new RadioButton();
            greenMaker = new RadioButton();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Coral;
            button1.Location = new Point(54, 57);
            button1.Name = "button1";
            button1.Size = new Size(208, 54);
            button1.TabIndex = 0;
            button1.Text = "Jessica";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 180);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(515, 23);
            progressBar1.TabIndex = 1;
            progressBar1.Click += progressBar1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(299, 15);
            label1.TabIndex = 2;
            label1.Text = "Potatoes are the best thing in the world and I love them";
            label1.Click += label1_Click;
            // 
            // redmaker
            // 
            redmaker.AutoSize = true;
            redmaker.Location = new Point(376, 57);
            redmaker.Name = "redmaker";
            redmaker.Size = new Size(90, 19);
            redmaker.TabIndex = 3;
            redmaker.TabStop = true;
            redmaker.Text = "Make it Red!";
            redmaker.UseVisualStyleBackColor = true;
            redmaker.CheckedChanged += redmaker_CheckedChanged;
            // 
            // pinkMaker
            // 
            pinkMaker.AutoSize = true;
            pinkMaker.Location = new Point(376, 91);
            pinkMaker.Name = "pinkMaker";
            pinkMaker.Size = new Size(93, 19);
            pinkMaker.TabIndex = 4;
            pinkMaker.TabStop = true;
            pinkMaker.Text = "Make it Pink!";
            pinkMaker.UseVisualStyleBackColor = true;
            pinkMaker.CheckedChanged += pinkMaker_CheckedChanged;
            // 
            // greenMaker
            // 
            greenMaker.AutoSize = true;
            greenMaker.Location = new Point(376, 126);
            greenMaker.Name = "greenMaker";
            greenMaker.Size = new Size(101, 19);
            greenMaker.TabIndex = 5;
            greenMaker.TabStop = true;
            greenMaker.Text = "Make it Green!";
            greenMaker.UseVisualStyleBackColor = true;
            greenMaker.CheckedChanged += greenMaker_CheckedChanged;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(54, 117);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(208, 45);
            trackBar1.TabIndex = 6;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 236);
            Controls.Add(trackBar1);
            Controls.Add(greenMaker);
            Controls.Add(pinkMaker);
            Controls.Add(redmaker);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ProgressBar progressBar1;
        private Label label1;
        private RadioButton redmaker;
        private RadioButton pinkMaker;
        private RadioButton greenMaker;
        private TrackBar trackBar1;
    }
}
