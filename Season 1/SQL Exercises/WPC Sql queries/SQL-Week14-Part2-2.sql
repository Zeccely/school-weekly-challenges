Select ProjectID, [Name], Department, MaxHours, StartDate, EndDate
From Project pro
where department in (
Select DepartmentName
from Department
where BudgetCode = 'BC-700-10');