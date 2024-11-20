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
            this._name = name;
            this._amount = amount;
        }
        
    }
}

class ExpenseManager
{
    public Expense _expense;
    
    public List<Expense> _expenseList = new List<Expense>();

    public List<Expense> AddExpense(Expense expense)
        {
            //var adder = $"{this._name} - {this._amount}"; I thought I needed this so it would display like this but can't I do that on the form?
            _expenseList.Add(expense);

            return _expenseList;
        }
}