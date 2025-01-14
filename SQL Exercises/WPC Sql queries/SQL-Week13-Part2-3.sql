Select pro.ProjectID, [Name], emp.Department, dpt.Phone as "Department Phone Number",
emp.EmployeeNumber, emp.LastName, emp.FirstName, emp.Phone as "Employee Phone Number"
From EMPLOYEE as emp
Inner Join ASSIGNMENT as ass on emp.EmployeeNumber = ass.EmployeeNumber
Inner Join PROJECT as pro on pro.ProjectID = ass.ProjectID
Inner Join DEPARTMENT as dpt on dpt.DepartmentName = emp.Department
--Inner Join Project as pro on pro.Department = dpt.DepartmentName 
Where pro.Department = 'Marketing'
Order by ProjectID ASC