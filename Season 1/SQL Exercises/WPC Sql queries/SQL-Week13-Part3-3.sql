Select AVG(CAST(MaxHours as float)) AvgMaxHoursMarketing
From Project pro
Inner Join DEPARTMENT dpt on dpt.DepartmentName = pro.Department
Where DepartmentName = 'Marketing'
Group by DepartmentName