Select ProjectId, emp.EmployeeNumber, LastName, FirstName, Phone
From EMPLOYEE as emp
Inner Join Assignment as ass on emp.EmployeeNumber = ass.EmployeeNumber
Order by EmployeeNumber, ProjectID DESC