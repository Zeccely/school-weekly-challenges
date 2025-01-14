Select emp.EmployeeNumber, emp.FirstName, emp.LastName, pro.ProjectID, pro.[Name],
ass.HoursWorked
From Employee as emp
Inner Join ASSIGNMENT as ass on ass.EmployeeNumber = emp.EmployeeNumber
Inner Join Project as pro on pro.ProjectID = ass.ProjectID
Inner Join DEPARTMENT as dpt  on dpt.DepartmentName = emp.Department
Where DepartmentName = 'Administration'