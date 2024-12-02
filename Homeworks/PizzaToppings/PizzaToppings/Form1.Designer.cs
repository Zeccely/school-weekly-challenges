namespace PizzaToppings
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
            toppingsAdder = new Label();
            toppingsList = new ComboBox();
            addToPizza = new Button();
            removeFromPizza = new Button();
            label2 = new Label();
            pizzaPrice = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 94);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 0;
            label1.Text = "Pizza:";
            // 
            // toppingsAdder
            // 
            toppingsAdder.AutoSize = true;
            toppingsAdder.Location = new Point(57, 128);
            toppingsAdder.Name = "toppingsAdder";
            toppingsAdder.Size = new Size(138, 25);
            toppingsAdder.TabIndex = 1;
            toppingsAdder.Text = "no topping atm";
            // 
            // toppingsList
            // 
            toppingsList.FormattingEnabled = true;
            toppingsList.Location = new Point(25, 31);
            toppingsList.Name = "toppingsList";
            toppingsList.Size = new Size(182, 33);
            toppingsList.TabIndex = 2;
            // 
            // addToPizza
            // 
            addToPizza.Location = new Point(278, 30);
            addToPizza.Name = "addToPizza";
            addToPizza.Size = new Size(176, 34);
            addToPizza.TabIndex = 3;
            addToPizza.Text = "Add";
            addToPizza.UseVisualStyleBackColor = true;
            addToPizza.Click += addToPizza_Click;
            // 
            // removeFromPizza
            // 
            removeFromPizza.Location = new Point(278, 90);
            removeFromPizza.Name = "removeFromPizza";
            removeFromPizza.Size = new Size(176, 33);
            removeFromPizza.TabIndex = 4;
            removeFromPizza.Text = "Remove";
            removeFromPizza.UseVisualStyleBackColor = true;
            removeFromPizza.Click += RemoveFromPizza_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 240);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 5;
            label2.Text = "Price:";
            // 
            // pizzaPrice
            // 
            pizzaPrice.AutoSize = true;
            pizzaPrice.Location = new Point(115, 240);
            pizzaPrice.Name = "pizzaPrice";
            pizzaPrice.Size = new Size(80, 25);
            pizzaPrice.TabIndex = 6;
            pizzaPrice.Text = "No Pizza";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 302);
            Controls.Add(pizzaPrice);
            Controls.Add(label2);
            Controls.Add(removeFromPizza);
            Controls.Add(addToPizza);
            Controls.Add(toppingsList);
            Controls.Add(toppingsAdder);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label toppingsAdder;
        private ComboBox toppingsList;
        private Button addToPizza;
        private Button removeFromPizza;
        private Label label2;
        private Label pizzaPrice;
    }
}
