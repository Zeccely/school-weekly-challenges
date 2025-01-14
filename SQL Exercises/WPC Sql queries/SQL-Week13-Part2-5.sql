Select Distinct  emp.EmployeeNumber, emp.FirstName, emp.LastName
From EMPLOYEE as emp
Inner Join ASSIGNMENT as ass on ass.EmployeeNumber = emp.EmployeeNumber

