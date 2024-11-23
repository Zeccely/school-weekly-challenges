using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInances
{
    class ExpenseManager
    {
        public Expense _expense;
        private List<Expense> _expenseList;
       
        
        public ExpenseManager()
        {
            _expenseList = new List<Expense>();

        }

        public void AddExpense(Expense expense)
        {
            _expenseList.Add(expense);
        }
        
        public List<Expense> GetExpenseList() 
        { 
            return _expenseList; 
        }

        public List<Expense> GetSameAmount(double maney)
        {
            List<Expense> sameExpense = new List<Expense>();

            foreach (Expense expense in _expenseList)
            {
                if (expense._amount == maney)
                {
                    sameExpense.Add(expense);
                }
            }
            return sameExpense;
        } 











        //public List<Expense> AddShowExpense(Expense expense)
        //{
        //    _expenseList.Add(expense);

        //    return _expenseList;          WE ARE NEVER DOING THIS AGAIN
        //}
    }
}
