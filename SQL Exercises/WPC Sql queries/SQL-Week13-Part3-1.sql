Select COUNT (*) "AllRunbyMarketing"
from PROJECT as pro
Inner join DEPARTMENT dpt on dpt.DepartmentName = pro.Department
Where DepartmentName = 'Marketing'
Group by Department

