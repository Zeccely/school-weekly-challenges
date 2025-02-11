Select EmployeeNumber, FirstName, LastName, Department
from EMPLOYEE
where EmployeeNumber not in 
(Select EmployeeNumber
From ASSIGNMENT
where ProjectID is not null);