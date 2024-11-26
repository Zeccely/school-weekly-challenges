using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Group
{
    public class Member
    {

        public int studentID = 0;
        private string Name;

        public Member(string name)
        {
            this.Name = name;
            
        }
        public Member(string name, int studentID)
        {
            this.Name = name;
            this.studentID = studentID;
        }
        public string GetInfo()
        {
            string info;
            if (this.studentID != 0)
            {
                info = $"{this.Name} NR : {studentID}";
                return info;
            }
            else
            {
                info = this.Name;
                return info;
            }
        }
    }
}
