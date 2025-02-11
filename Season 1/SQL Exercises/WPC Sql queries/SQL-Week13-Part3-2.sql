Select Sum (MaxHours) MaxHoursMarketing
From PROJECT pro
Inner Join DEPARTMENT dpt on dpt.DepartmentName = pro.Department
Where DepartmentName = 'Marketing'
Group by Department