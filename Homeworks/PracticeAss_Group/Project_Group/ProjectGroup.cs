using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project_Group
{
    
    public class Project_Group
    {
        private string Name;
        private List<Member> MemberList = new List<Member>();
        string info;

        public Project_Group(string name)
        {
            this.Name = name;
        }
        public string AddName()
        { 
            return Name; 
        }
        public string GetInfo(string name)
        {
            string infononr;
            if (this.Name == name)
            {
                infononr = $"{this.Name}: No student number provided";
                return infononr;
            }
            else
            {
                return infononr = string.Empty;
            }
        }
        public string GetInfo(string name, int studentID)
        {
            
            foreach (Member item in MemberList)
            {
               string info = $"{item.GetInfo()}";
               
            }
            return info;
        }
    }


}

