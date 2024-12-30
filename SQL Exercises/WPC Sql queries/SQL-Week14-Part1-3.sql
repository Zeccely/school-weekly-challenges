Select emp.EmployeeNumber, Count(ass.ProjectID) NrProjectsmorethan20
From Employee emp
Inner Join ASSIGNMENT ass on ass.EmployeeNumber = emp.EmployeeNumber
Inner Join Project pro on ass.ProjectID = pro.ProjectID
where HoursWorked > 20
Group by emp.EmployeeNumber
Having Count(ass.ProjectID) >= 2 