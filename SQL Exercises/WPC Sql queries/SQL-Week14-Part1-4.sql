Select emp.EmployeeNumber, Count(ass.projectID) TotalProjects
From EMPLOYEE emp
Inner Join ASSIGNMENT ass on ass.EmployeeNumber = emp.EmployeeNumber
Inner Join PROJECT pro on ass.ProjectID = pro.ProjectID
Group by emp.EmployeeNumber 
having Count(ass.ProjectID) > 2