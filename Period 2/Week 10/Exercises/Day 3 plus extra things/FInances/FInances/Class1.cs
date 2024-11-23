using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FInances;

namespace FInances
{
    internal class Expense
    {
        public string _name { get; private set; } 
        public double _amount { get; private set; }

        

        public Expense(string name, double amount)
        {
            _name = name;
            _amount = amount;
        }
         public string ExpenseString()
        {
            return $"{_name} - {_amount}"; //what is Finances.Expense dammit?
        }
        
    }
}

