
namespace StreamingMusicApp
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
            textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            removeSongs = new System.Windows.Forms.Button();
            addSongs = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            createUser = new System.Windows.Forms.Button();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            textBox3 = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            label3 = new System.Windows.Forms.Label();
            tabControl1 = new System.Windows.Forms.TabControl();
            first_tab = new System.Windows.Forms.TabPage();
            second_tab = new System.Windows.Forms.TabPage();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(48, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(223, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(339, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // removeSongs
            // 
            removeSongs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            removeSongs.Location = new System.Drawing.Point(89, 138);
            removeSongs.Name = "removeSongs";
            removeSongs.Size = new System.Drawing.Size(132, 49);
            removeSongs.TabIndex = 2;
            removeSongs.Text = "Remove Song";
            removeSongs.UseVisualStyleBackColor = true;
            // 
            // addSongs
            // 
            addSongs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addSongs.Location = new System.Drawing.Point(89, 83);
            addSongs.Name = "addSongs";
            addSongs.Size = new System.Drawing.Size(132, 49);
            addSongs.TabIndex = 3;
            addSongs.Text = "Add Song";
            addSongs.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(removeSongs);
            groupBox1.Controls.Add(addSongs);
            groupBox1.Location = new System.Drawing.Point(12, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(328, 208);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Song";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(createUser);
            groupBox2.Location = new System.Drawing.Point(12, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(328, 173);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "User";
            // 
            // createUser
            // 
            createUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            createUser.Location = new System.Drawing.Point(89, 104);
            createUser.Name = "createUser";
            createUser.Size = new System.Drawing.Size(132, 49);
            createUser.TabIndex = 6;
            createUser.Text = "Add User";
            createUser.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(144, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(127, 23);
            textBox2.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(48, 36);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 21);
            label2.TabIndex = 6;
            label2.Text = "Username:";
            // 
            // textBox3
            // 
            textBox3.Location = new System.Drawing.Point(144, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new System.Drawing.Size(127, 23);
            textBox3.TabIndex = 8;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(48, 73);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(51, 21);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(first_tab);
            tabControl1.Controls.Add(second_tab);
            tabControl1.Location = new System.Drawing.Point(368, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(420, 387);
            tabControl1.TabIndex = 9;
            // 
            // first_tab
            // 
            first_tab.Location = new System.Drawing.Point(4, 24);
            first_tab.Name = "first_tab";
            first_tab.Padding = new System.Windows.Forms.Padding(3);
            first_tab.Size = new System.Drawing.Size(412, 359);
            first_tab.TabIndex = 0;
            first_tab.Text = "First tab";
            first_tab.UseVisualStyleBackColor = true;
            // 
            // second_tab
            // 
            second_tab.Location = new System.Drawing.Point(4, 24);
            second_tab.Name = "second_tab";
            second_tab.Padding = new System.Windows.Forms.Padding(3);
            second_tab.Size = new System.Drawing.Size(412, 359);
            second_tab.TabIndex = 1;
            second_tab.Text = "Second Tab";
            second_tab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 438);
            Controls.Add(tabControl1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Music Logger";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeSongs;
        private System.Windows.Forms.Button addSongs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage first_tab;
        private System.Windows.Forms.TabPage second_tab;
    }
}

