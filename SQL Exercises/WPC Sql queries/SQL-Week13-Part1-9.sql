Select  DISTINCT EmployeeNumber, FirstName, LastName, DepartmentName
From Employee
Inner join DEPARTMENT on Employee.Department = Department.DepartmentName
where Department in ('Administration' , 'Accounting', 'Production', 'Legal')
Order by DepartmentName, LastName ;