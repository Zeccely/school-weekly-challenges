Select Distinct pro.ProjectID, [Name], pro.Department, dpt.Phone as "Dept Phone",
emp.EmployeeNumber, emp.LastName, emp.FirstName, emp.Phone as "Employee Phone Number"
From Employee as emp
Inner Join Assignment as ass on emp.EmployeeNumber = ass.EmployeeNumber
Inner Join Project as pro on pro.ProjectID = ass.ProjectID
Inner Join Department as dpt on dpt.DepartmentName = pro.Department
Order By ProjectID ASC