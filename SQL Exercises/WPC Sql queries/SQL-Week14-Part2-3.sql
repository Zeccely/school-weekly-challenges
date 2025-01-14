Select EmployeeNumber, FirstName, LastName
From EMPLOYEE
where Department in 
( Select DepartmentName
from DEPARTMENT
where OfficeNumber = 'BLDG01-300');