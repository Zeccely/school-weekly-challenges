
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
            songGenre = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            textBox2 = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            emailtbx = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            usernametbx = new System.Windows.Forms.TextBox();
            createUser = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tabControl1 = new System.Windows.Forms.TabControl();
            first_tab = new System.Windows.Forms.TabPage();
            Songslbl = new System.Windows.Forms.Label();
            Favis = new System.Windows.Forms.Label();
            userSongs = new System.Windows.Forms.ListBox();
            favoritesongs = new System.Windows.Forms.ListBox();
            second_tab = new System.Windows.Forms.TabPage();
            label4 = new System.Windows.Forms.Label();
            userlistview = new System.Windows.Forms.ListBox();
            songusercounterlbl = new System.Windows.Forms.Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tabControl1.SuspendLayout();
            first_tab.SuspendLayout();
            second_tab.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(164, 34);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(297, 31);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(484, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // removeSongs
            // 
            removeSongs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            removeSongs.Location = new System.Drawing.Point(247, 218);
            removeSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            removeSongs.Name = "removeSongs";
            removeSongs.Size = new System.Drawing.Size(189, 82);
            removeSongs.TabIndex = 2;
            removeSongs.Text = "Remove Song";
            removeSongs.UseVisualStyleBackColor = true;
            // 
            // addSongs
            // 
            addSongs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addSongs.Location = new System.Drawing.Point(27, 218);
            addSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            addSongs.Name = "addSongs";
            addSongs.Size = new System.Drawing.Size(189, 82);
            addSongs.TabIndex = 3;
            addSongs.Text = "Add Song";
            addSongs.UseVisualStyleBackColor = true;
            addSongs.Click += addSongs_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(songGenre);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(removeSongs);
            groupBox1.Controls.Add(addSongs);
            groupBox1.Location = new System.Drawing.Point(17, 363);
            groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox1.Size = new System.Drawing.Size(469, 347);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Song";
            // 
            // songGenre
            // 
            songGenre.FormattingEnabled = true;
            songGenre.Location = new System.Drawing.Point(162, 153);
            songGenre.Name = "songGenre";
            songGenre.Size = new System.Drawing.Size(182, 33);
            songGenre.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(87, 161);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(58, 25);
            label8.TabIndex = 9;
            label8.Text = "Genre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(64, 114);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(81, 25);
            label7.TabIndex = 8;
            label7.Text = "Duration";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(101, 78);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(44, 25);
            label6.TabIndex = 7;
            label6.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(91, 40);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 25);
            label5.TabIndex = 6;
            label5.Text = "Artist";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(164, 114);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(180, 31);
            numericUpDown1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(164, 75);
            textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(297, 31);
            textBox2.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(emailtbx);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(usernametbx);
            groupBox2.Controls.Add(createUser);
            groupBox2.Location = new System.Drawing.Point(17, 65);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Size = new System.Drawing.Size(469, 288);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(69, 122);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(76, 32);
            label3.TabIndex = 7;
            label3.Text = "Email:";
            // 
            // emailtbx
            // 
            emailtbx.Location = new System.Drawing.Point(206, 125);
            emailtbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            emailtbx.Name = "emailtbx";
            emailtbx.Size = new System.Drawing.Size(180, 31);
            emailtbx.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(69, 60);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 32);
            label2.TabIndex = 6;
            label2.Text = "Username:";
            // 
            // usernametbx
            // 
            usernametbx.Location = new System.Drawing.Point(206, 63);
            usernametbx.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            usernametbx.Name = "usernametbx";
            usernametbx.Size = new System.Drawing.Size(180, 31);
            usernametbx.TabIndex = 7;
            // 
            // createUser
            // 
            createUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            createUser.Location = new System.Drawing.Point(127, 173);
            createUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            createUser.Name = "createUser";
            createUser.Size = new System.Drawing.Size(189, 82);
            createUser.TabIndex = 6;
            createUser.Text = "Add User";
            createUser.UseVisualStyleBackColor = true;
            createUser.Click += createUser_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(first_tab);
            tabControl1.Controls.Add(second_tab);
            tabControl1.Location = new System.Drawing.Point(526, 65);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(600, 645);
            tabControl1.TabIndex = 9;
            // 
            // first_tab
            // 
            first_tab.Controls.Add(Songslbl);
            first_tab.Controls.Add(Favis);
            first_tab.Controls.Add(userSongs);
            first_tab.Controls.Add(favoritesongs);
            first_tab.Location = new System.Drawing.Point(4, 34);
            first_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            first_tab.Name = "first_tab";
            first_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            first_tab.Size = new System.Drawing.Size(592, 607);
            first_tab.TabIndex = 0;
            first_tab.Text = "Music";
            first_tab.UseVisualStyleBackColor = true;
            // 
            // Songslbl
            // 
            Songslbl.AutoSize = true;
            Songslbl.Location = new System.Drawing.Point(393, 20);
            Songslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Songslbl.Name = "Songslbl";
            Songslbl.Size = new System.Drawing.Size(62, 25);
            Songslbl.TabIndex = 3;
            Songslbl.Text = "Songs";
            // 
            // Favis
            // 
            Favis.AutoSize = true;
            Favis.Location = new System.Drawing.Point(89, 20);
            Favis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Favis.Name = "Favis";
            Favis.Size = new System.Drawing.Size(129, 25);
            Favis.TabIndex = 2;
            Favis.Text = "Favorite Songs";
            // 
            // userSongs
            // 
            userSongs.FormattingEnabled = true;
            userSongs.ItemHeight = 25;
            userSongs.Location = new System.Drawing.Point(307, 57);
            userSongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            userSongs.Name = "userSongs";
            userSongs.Size = new System.Drawing.Size(243, 529);
            userSongs.TabIndex = 1;
            // 
            // favoritesongs
            // 
            favoritesongs.FormattingEnabled = true;
            favoritesongs.ItemHeight = 25;
            favoritesongs.Location = new System.Drawing.Point(36, 57);
            favoritesongs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            favoritesongs.Name = "favoritesongs";
            favoritesongs.Size = new System.Drawing.Size(227, 529);
            favoritesongs.TabIndex = 0;
            // 
            // second_tab
            // 
            second_tab.Controls.Add(label4);
            second_tab.Controls.Add(userlistview);
            second_tab.Location = new System.Drawing.Point(4, 34);
            second_tab.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            second_tab.Name = "second_tab";
            second_tab.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            second_tab.Size = new System.Drawing.Size(592, 607);
            second_tab.TabIndex = 1;
            second_tab.Text = "Users";
            second_tab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(70, 20);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(120, 25);
            label4.TabIndex = 1;
            label4.Text = "User View List";
            // 
            // userlistview
            // 
            userlistview.FormattingEnabled = true;
            userlistview.ItemHeight = 25;
            userlistview.Location = new System.Drawing.Point(9, 57);
            userlistview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            userlistview.Name = "userlistview";
            userlistview.Size = new System.Drawing.Size(244, 529);
            userlistview.TabIndex = 0;
            // 
            // songusercounterlbl
            // 
            songusercounterlbl.AutoSize = true;
            songusercounterlbl.Location = new System.Drawing.Point(977, 15);
            songusercounterlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            songusercounterlbl.Name = "songusercounterlbl";
            songusercounterlbl.Size = new System.Drawing.Size(152, 25);
            songusercounterlbl.TabIndex = 10;
            songusercounterlbl.Text = "CounterSongUser";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1143, 730);
            Controls.Add(songusercounterlbl);
            Controls.Add(tabControl1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Music Logger";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tabControl1.ResumeLayout(false);
            first_tab.ResumeLayout(false);
            first_tab.PerformLayout();
            second_tab.ResumeLayout(false);
            second_tab.PerformLayout();
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
        private System.Windows.Forms.TextBox emailtbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametbx;
        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage first_tab;
        private System.Windows.Forms.TabPage second_tab;
        private System.Windows.Forms.ListBox userlistview;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox userSongs;
        private System.Windows.Forms.ListBox favoritesongs;
        private System.Windows.Forms.Label Favis;
        private System.Windows.Forms.Label Songslbl;
        private System.Windows.Forms.Label songusercounterlbl;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox songGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

