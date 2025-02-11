Select ProjectID, [Name], StartDate
From PROJECT as pro
Inner Join DEPARTMENT as dpt on dpt.DepartmentName = pro.Department
Where BudgetCode = 'BC-400-10'