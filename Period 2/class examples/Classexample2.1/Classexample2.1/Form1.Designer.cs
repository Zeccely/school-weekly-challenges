namespace Classexample2._1
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
            orderDrink = new Button();
            adultOrNot = new CheckBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            drinkSelector = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(42, 49);
            label1.Name = "label1";
            label1.Size = new Size(381, 54);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the Bar!";
            // 
            // orderDrink
            // 
            orderDrink.Location = new Point(42, 331);
            orderDrink.Name = "orderDrink";
            orderDrink.Size = new Size(171, 38);
            orderDrink.TabIndex = 1;
            orderDrink.Text = "Order a drink";
            orderDrink.UseVisualStyleBackColor = true;
            orderDrink.Click += orderDrink_Click;
            // 
            // adultOrNot
            // 
            adultOrNot.AutoSize = true;
            adultOrNot.Location = new Point(42, 265);
            adultOrNot.Name = "adultOrNot";
            adultOrNot.Size = new Size(138, 29);
            adultOrNot.TabIndex = 4;
            adultOrNot.Text = "I am over 18";
            adultOrNot.UseVisualStyleBackColor = true;
            adultOrNot.CheckedChanged += adultOrNot_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 149);
            label2.Name = "label2";
            label2.Size = new Size(249, 25);
            label2.TabIndex = 5;
            label2.Text = "What would you like to drink?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = MyResource2_1.drinks;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(420, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(347, 305);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // drinkSelector
            // 
            drinkSelector.FormattingEnabled = true;
            drinkSelector.Items.AddRange(new object[] { "Coca Cola", "Sprite", "Fanta", "Monster", "Tequila Sunrise" });
            drinkSelector.Location = new Point(42, 200);
            drinkSelector.Name = "drinkSelector";
            drinkSelector.Size = new Size(182, 33);
            drinkSelector.TabIndex = 7;
            drinkSelector.SelectedIndexChanged += drinkSelector_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(drinkSelector);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(adultOrNot);
            Controls.Add(orderDrink);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button orderDrink;
        private CheckBox adultOrNot;
        private Label label2;
        private PictureBox pictureBox1;
        private ComboBox drinkSelector;
    }
}
