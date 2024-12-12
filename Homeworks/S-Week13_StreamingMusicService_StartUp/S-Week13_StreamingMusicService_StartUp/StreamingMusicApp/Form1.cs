using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicApp
{
    public partial class Form1 : Form //Ahhhhh I don't know how to connect this properly!
    {
        StreamingMusicService Bobusico = new StreamingMusicService("Bobusico");
        List<string> userlistdisplay = new List<string>();
        
        public Form1()
        {
            InitializeComponent();

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void createUser_Click(object sender, EventArgs e)
        {
            string usernamenow = usernametbx.Text.ToString();
            string emailnow = emailtbx.Text.ToString();
            User musiclistener = new User(usernamenow,emailnow);
            Bobusico.AddUser(musiclistener);
            
            //List<string> userlist = new List<string>();
            //userlist.Add(usernamenow);
            //List<User> userlistdisplay = Bobusico.GetUsers(userlist);  got confused with the snackbar. I was trying to get the list from the other side when I can create a user and put it in bobusico
            
            userlistview.Items.Clear();
            userlistdisplay.Add(Bobusico.GetUser(usernamenow));

            foreach (User user in Bobusico.UserList)
            {
                userlistview.Items.Add(string.Join(" ", userlistdisplay));

            }
            
        }
    }
}
