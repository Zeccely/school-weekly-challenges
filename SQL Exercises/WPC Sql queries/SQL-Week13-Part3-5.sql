Select  pro.ProjectID, Min(Cast(HoursWorked as float)) MinHoursWorked,
Max(Cast(HoursWorked as float)) MaxHoursWorked
From PROJECT pro
Inner Join ASSIGNMENT ass on ass.ProjectID = pro.ProjectID
Inner Join Employee emp on emp.EmployeeNumber = ass.EmployeeNumber
Group by pro.ProjectID