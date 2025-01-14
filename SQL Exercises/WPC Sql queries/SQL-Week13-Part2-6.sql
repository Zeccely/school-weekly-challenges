Select Distinct ProjectID, [Name], StartDate, Department, BudgetCode
from Project as pro
Inner Join DEPARTMENT as dpt on dpt.DepartmentName = pro.Department