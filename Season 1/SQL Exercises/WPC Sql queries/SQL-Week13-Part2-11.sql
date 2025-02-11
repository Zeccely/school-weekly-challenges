Select *
From EMPLOYEE as emp
Inner Join DEPARTMENT as dpt on dpt.DepartmentName = emp.Department
Where DepartmentName <> 'Accounting' 