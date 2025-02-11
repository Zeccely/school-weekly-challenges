Select Department
From Employee emp
Inner Join DEPARTMENT dpt on dpt.departmentname = emp.department
Group by Department
having count(*) < 2