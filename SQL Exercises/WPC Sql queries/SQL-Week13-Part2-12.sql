Select distinct emp.EmployeeNumber, FirstName, LastName, dpt.DepartmentName, emp.Phone, Email
From EMPLOYEE as emp
Inner Join ASSIGNMENT as ass on ass.EmployeeNumber = emp.EmployeeNumber
Inner Join PROJECT as pro on ass.ProjectID = pro.ProjectID
Inner Join DEPARTMENT as dpt on dpt.DepartmentName = emp.Department
Where HoursWorked < 45 and dpt.DepartmentName <> 'Accounting'
