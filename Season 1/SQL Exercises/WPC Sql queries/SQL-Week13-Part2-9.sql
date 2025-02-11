Select emp.EmployeeNumber, emp.FirstName, emp.LastName, emp.Email, emp.Department, dpt.OfficeNumber
From Employee as emp
Inner Join DEPARTMENT as dpt on emp.Department = dpt.DepartmentName
order by dpt.DepartmentName