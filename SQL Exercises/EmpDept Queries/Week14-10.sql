Select Deptno, Dname, Loc
from Dept
where deptno not in (
Select Deptno
From Emp)