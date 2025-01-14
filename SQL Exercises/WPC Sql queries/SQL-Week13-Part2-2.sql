Select pro.ProjectID, [Name], pro.Department, emp.EmployeeNumber, emp.LastName, 
emp.FirstName, emp.Phone
From EMPLOYEE as emp
Inner Join ASSIGNMENT as ass on emp.EmployeeNumber = ass.EmployeeNumber
Inner Join Project as pro on pro.ProjectID = ass.ProjectID
Order by ProjectID ASC