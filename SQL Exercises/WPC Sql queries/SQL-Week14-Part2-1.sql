Select distinct emp.EmployeeNumber,FirstName, LastName
From EMPLOYEE emp
inner Join ASSIGNMENT ass on ass.EmployeeNumber = emp.EmployeeNumber
inner join Project pro on pro.ProjectID = ass.ProjectID
where pro.ProjectID is not null;
--Sol 1

Select Distinct emp.EmployeeNumber, FirstName, LastName
from EMPLOYEE emp
Where emp.EmployeeNumber in ( 
Select Distinct ass.EmployeeNumber
From ASSIGNMENT ass
where ProjectID is not null)