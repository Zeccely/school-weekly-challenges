Select Distinct emp.EmployeeNumber, FirstName, LastName, Department
From EMPLOYEE as emp
Inner Join ASSIGNMENT as ass on ass.EmployeeNumber = emp.EmployeeNumber
Where HoursWorked > 50