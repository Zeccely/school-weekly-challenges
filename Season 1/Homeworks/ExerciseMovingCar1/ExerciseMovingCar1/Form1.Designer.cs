namespace ExerciseMovingCar1
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
            components = new System.ComponentModel.Container();
            startButton = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            pinkCar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pinkCar).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(627, 394);
            startButton.Name = "startButton";
            startButton.Size = new Size(112, 34);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            startButton.Click += startButton_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pinkCar
            // 
            pinkCar.BackgroundImage = Properties.Resources.car;
            pinkCar.BackgroundImageLayout = ImageLayout.Zoom;
            pinkCar.Location = new Point(35, 78);
            pinkCar.Name = "pinkCar";
            pinkCar.Size = new Size(257, 105);
            pinkCar.TabIndex = 1;
            pinkCar.TabStop = false;
            pinkCar.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 441);
            Controls.Add(pinkCar);
            Controls.Add(startButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pinkCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button startButton;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pinkCar;
    }
}
