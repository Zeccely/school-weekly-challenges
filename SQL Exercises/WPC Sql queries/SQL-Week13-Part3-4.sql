Select DepartmentName, Count(*) NrofProjects
From PROJECT pro
Inner Join DEPARTMENT dpt on dpt.DepartmentName = pro.Department
Group by DepartmentName