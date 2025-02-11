Select EmployeeNumber, FirstName, LastName
From EMPLOYEE
Where EmployeeNumber in(Select EmployeeNumber
From ASSIGNMENT 
where HoursWorked >(Select AVG(HoursWorked)
From ASSIGNMENT ass));