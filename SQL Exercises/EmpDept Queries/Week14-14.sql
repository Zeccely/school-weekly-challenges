Select employee.Ename [Employee Name], employee.Job, manager.Ename [Manager Name], dp.Dname ManagerDept, dp.Loc DeptLocation
From Emp employee
Inner Join Emp manager on manager.Empno = employee.Mgr
Inner Join Dept dp on dp.Deptno = manager.Deptno  --The place where you inner join matters
where employee.Empno not in (
Select p.Mgr 
From Emp p
where p.Mgr is not null)     
