Select FirstName, LastName, Count(ass.ProjectID) TotalProjects
From Employee emp
Inner Join Assignment ass on ass.EmployeeNumber = emp.EmployeeNumber
Inner Join Project pro on pro.ProjectID = ass.ProjectID
Group by FirstName, LastName
having Count(ass.ProjectID) > 2