
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
            artisttbx = new System.Windows.Forms.TextBox();
            allSongs = new System.Windows.Forms.Label();
            removeSongs = new System.Windows.Forms.Button();
            addSongs = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            songGenre = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            durationsectbx = new System.Windows.Forms.NumericUpDown();
            titletbx = new System.Windows.Forms.TextBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label3 = new System.Windows.Forms.Label();
            emailtbx = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            usernametbx = new System.Windows.Forms.TextBox();
            createUser = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tabControl1 = new System.Windows.Forms.TabControl();
            first_tab = new System.Windows.Forms.TabPage();
            allsongsrefreshbtn = new System.Windows.Forms.Button();
            favrefreshbtn = new System.Windows.Forms.Button();
            favoriteadder = new System.Windows.Forms.Button();
            Songslbl = new System.Windows.Forms.Label();
            Favis = new System.Windows.Forms.Label();
            userSongs = new System.Windows.Forms.ListBox();
            favoritesongs = new System.Windows.Forms.ListBox();
            second_tab = new System.Windows.Forms.TabPage();
            allSongslbx = new System.Windows.Forms.ListBox();
            userswitcher = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            userlistview = new System.Windows.Forms.ListBox();
            songusercounterlbl = new System.Windows.Forms.Label();
            allsongsbtn = new System.Windows.Forms.Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)durationsectbx).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tabControl1.SuspendLayout();
            first_tab.SuspendLayout();
            second_tab.SuspendLayout();
            SuspendLayout();
            // 
            // artisttbx
            // 
            artisttbx.Location = new System.Drawing.Point(115, 20);
            artisttbx.Name = "artisttbx";
            artisttbx.Size = new System.Drawing.Size(209, 23);
            artisttbx.TabIndex = 0;
            // 
            // allSongs
            // 
            allSongs.AutoSize = true;
            allSongs.Location = new System.Drawing.Point(260, 12);
            allSongs.Name = "allSongs";
            allSongs.Size = new System.Drawing.Size(59, 15);
            allSongs.TabIndex = 1;
            allSongs.Text = "All Songs!";
            // 
            // removeSongs
            // 
            removeSongs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            removeSongs.Location = new System.Drawing.Point(173, 131);
            removeSongs.Name = "removeSongs";
            removeSongs.Size = new System.Drawing.Size(132, 49);
            removeSongs.TabIndex = 2;
            removeSongs.Text = "Remove Song";
            removeSongs.UseVisualStyleBackColor = true;
            // 
            // addSongs
            // 
            addSongs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            addSongs.Location = new System.Drawing.Point(19, 131);
            addSongs.Name = "addSongs";
            addSongs.Size = new System.Drawing.Size(132, 49);
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
            groupBox1.Controls.Add(durationsectbx);
            groupBox1.Controls.Add(titletbx);
            groupBox1.Controls.Add(artisttbx);
            groupBox1.Controls.Add(removeSongs);
            groupBox1.Controls.Add(addSongs);
            groupBox1.Location = new System.Drawing.Point(12, 218);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(328, 208);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Song";
            // 
            // songGenre
            // 
            songGenre.FormattingEnabled = true;
            songGenre.Location = new System.Drawing.Point(113, 92);
            songGenre.Margin = new System.Windows.Forms.Padding(2);
            songGenre.Name = "songGenre";
            songGenre.Size = new System.Drawing.Size(129, 23);
            songGenre.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(61, 97);
            label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(38, 15);
            label8.TabIndex = 9;
            label8.Text = "Genre";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(45, 68);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(53, 15);
            label7.TabIndex = 8;
            label7.Text = "Duration";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(71, 47);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(29, 15);
            label6.TabIndex = 7;
            label6.Text = "Title";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(64, 24);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 15);
            label5.TabIndex = 6;
            label5.Text = "Artist";
            // 
            // durationsectbx
            // 
            durationsectbx.Location = new System.Drawing.Point(115, 68);
            durationsectbx.Margin = new System.Windows.Forms.Padding(2);
            durationsectbx.Name = "durationsectbx";
            durationsectbx.Size = new System.Drawing.Size(126, 23);
            durationsectbx.TabIndex = 5;
            // 
            // titletbx
            // 
            titletbx.Location = new System.Drawing.Point(115, 45);
            titletbx.Name = "titletbx";
            titletbx.Size = new System.Drawing.Size(209, 23);
            titletbx.TabIndex = 4;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(emailtbx);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(usernametbx);
            groupBox2.Controls.Add(createUser);
            groupBox2.Location = new System.Drawing.Point(12, 39);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(328, 173);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "User";
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
            // emailtbx
            // 
            emailtbx.Location = new System.Drawing.Point(144, 75);
            emailtbx.Name = "emailtbx";
            emailtbx.Size = new System.Drawing.Size(127, 23);
            emailtbx.TabIndex = 8;
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
            // usernametbx
            // 
            usernametbx.Location = new System.Drawing.Point(144, 38);
            usernametbx.Name = "usernametbx";
            usernametbx.Size = new System.Drawing.Size(127, 23);
            usernametbx.TabIndex = 7;
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
            tabControl1.Location = new System.Drawing.Point(368, 39);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(420, 387);
            tabControl1.TabIndex = 9;
            // 
            // first_tab
            // 
            first_tab.Controls.Add(allsongsrefreshbtn);
            first_tab.Controls.Add(favrefreshbtn);
            first_tab.Controls.Add(favoriteadder);
            first_tab.Controls.Add(Songslbl);
            first_tab.Controls.Add(Favis);
            first_tab.Controls.Add(userSongs);
            first_tab.Controls.Add(favoritesongs);
            first_tab.Location = new System.Drawing.Point(4, 24);
            first_tab.Name = "first_tab";
            first_tab.Padding = new System.Windows.Forms.Padding(3);
            first_tab.Size = new System.Drawing.Size(412, 359);
            first_tab.TabIndex = 0;
            first_tab.Text = "Music";
            first_tab.UseVisualStyleBackColor = true;
            // 
            // allsongsrefreshbtn
            // 
            allsongsrefreshbtn.Location = new System.Drawing.Point(171, 196);
            allsongsrefreshbtn.Name = "allsongsrefreshbtn";
            allsongsrefreshbtn.Size = new System.Drawing.Size(69, 69);
            allsongsrefreshbtn.TabIndex = 6;
            allsongsrefreshbtn.Text = "See Song List";
            allsongsrefreshbtn.UseVisualStyleBackColor = true;
            allsongsrefreshbtn.Click += allsongsrefreshbtn_Click;
            // 
            // favrefreshbtn
            // 
            favrefreshbtn.Location = new System.Drawing.Point(171, 126);
            favrefreshbtn.Name = "favrefreshbtn";
            favrefreshbtn.Size = new System.Drawing.Size(69, 68);
            favrefreshbtn.TabIndex = 5;
            favrefreshbtn.Text = "See Favorite List";
            favrefreshbtn.UseVisualStyleBackColor = true;
            favrefreshbtn.Click += favrefreshbtn_Click;
            // 
            // favoriteadder
            // 
            favoriteadder.Location = new System.Drawing.Point(171, 266);
            favoriteadder.Name = "favoriteadder";
            favoriteadder.Size = new System.Drawing.Size(69, 83);
            favoriteadder.TabIndex = 4;
            favoriteadder.Text = "Add to Favorites";
            favoriteadder.UseVisualStyleBackColor = true;
            favoriteadder.Click += favoriteadder_Click;
            // 
            // Songslbl
            // 
            Songslbl.AutoSize = true;
            Songslbl.Location = new System.Drawing.Point(54, 12);
            Songslbl.Name = "Songslbl";
            Songslbl.Size = new System.Drawing.Size(39, 15);
            Songslbl.TabIndex = 3;
            Songslbl.Text = "Songs";
            // 
            // Favis
            // 
            Favis.AutoSize = true;
            Favis.Location = new System.Drawing.Point(288, 12);
            Favis.Name = "Favis";
            Favis.Size = new System.Drawing.Size(84, 15);
            Favis.TabIndex = 2;
            Favis.Text = "Favorite Songs";
            // 
            // userSongs
            // 
            userSongs.FormattingEnabled = true;
            userSongs.ItemHeight = 15;
            userSongs.Location = new System.Drawing.Point(6, 30);
            userSongs.Name = "userSongs";
            userSongs.Size = new System.Drawing.Size(159, 319);
            userSongs.TabIndex = 1;
            // 
            // favoritesongs
            // 
            favoritesongs.FormattingEnabled = true;
            favoritesongs.ItemHeight = 15;
            favoritesongs.Location = new System.Drawing.Point(246, 30);
            favoritesongs.Name = "favoritesongs";
            favoritesongs.Size = new System.Drawing.Size(160, 319);
            favoritesongs.TabIndex = 0;
            // 
            // second_tab
            // 
            second_tab.Controls.Add(allsongsbtn);
            second_tab.Controls.Add(allSongslbx);
            second_tab.Controls.Add(userswitcher);
            second_tab.Controls.Add(label4);
            second_tab.Controls.Add(userlistview);
            second_tab.Controls.Add(allSongs);
            second_tab.Location = new System.Drawing.Point(4, 24);
            second_tab.Name = "second_tab";
            second_tab.Padding = new System.Windows.Forms.Padding(3);
            second_tab.Size = new System.Drawing.Size(412, 359);
            second_tab.TabIndex = 1;
            second_tab.Text = "Users";
            second_tab.UseVisualStyleBackColor = true;
            // 
            // allSongslbx
            // 
            allSongslbx.FormattingEnabled = true;
            allSongslbx.ItemHeight = 15;
            allSongslbx.Location = new System.Drawing.Point(197, 34);
            allSongslbx.Name = "allSongslbx";
            allSongslbx.Size = new System.Drawing.Size(187, 244);
            allSongslbx.TabIndex = 3;
            // 
            // userswitcher
            // 
            userswitcher.Location = new System.Drawing.Point(184, 289);
            userswitcher.Name = "userswitcher";
            userswitcher.Size = new System.Drawing.Size(119, 64);
            userswitcher.TabIndex = 2;
            userswitcher.Text = "Switch User";
            userswitcher.UseVisualStyleBackColor = true;
            userswitcher.Click += userswitcher_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(49, 12);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(79, 15);
            label4.TabIndex = 1;
            label4.Text = "User View List";
            // 
            // userlistview
            // 
            userlistview.FormattingEnabled = true;
            userlistview.ItemHeight = 15;
            userlistview.Location = new System.Drawing.Point(6, 34);
            userlistview.Name = "userlistview";
            userlistview.Size = new System.Drawing.Size(172, 319);
            userlistview.TabIndex = 0;
            // 
            // songusercounterlbl
            // 
            songusercounterlbl.AutoSize = true;
            songusercounterlbl.Location = new System.Drawing.Point(684, 9);
            songusercounterlbl.Name = "songusercounterlbl";
            songusercounterlbl.Size = new System.Drawing.Size(100, 15);
            songusercounterlbl.TabIndex = 10;
            songusercounterlbl.Text = "CounterSongUser";
            // 
            // allsongsbtn
            // 
            allsongsbtn.Location = new System.Drawing.Point(309, 289);
            allsongsbtn.Name = "allsongsbtn";
            allsongsbtn.Size = new System.Drawing.Size(94, 64);
            allsongsbtn.TabIndex = 4;
            allsongsbtn.Text = "All Songs";
            allsongsbtn.UseVisualStyleBackColor = true;
            allsongsbtn.Click += allsongsbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 438);
            Controls.Add(songusercounterlbl);
            Controls.Add(tabControl1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Music Logger";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)durationsectbx).EndInit();
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

        private System.Windows.Forms.TextBox artisttbx;
        private System.Windows.Forms.Label allSongs;
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
        private System.Windows.Forms.TextBox titletbx;
        private System.Windows.Forms.ComboBox songGenre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown durationsectbx;
        private System.Windows.Forms.Button favoriteadder;
        private System.Windows.Forms.Button userswitcher;
        private System.Windows.Forms.Button allsongsrefreshbtn;
        private System.Windows.Forms.Button favrefreshbtn;
        private System.Windows.Forms.ListBox allSongslbx;
        private System.Windows.Forms.Button allsongsbtn;
    }
}

