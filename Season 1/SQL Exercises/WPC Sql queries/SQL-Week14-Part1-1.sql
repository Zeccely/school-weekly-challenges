Select DepartmentName, SUM(MaxHours) TotalMax
From DEPARTMENT as dpt
Inner Join Project pro on dpt.DepartmentName = pro.Department
Group by DepartmentName
Having SUM(MaxHours) > 140 --This is not an arythmetic operation.