Select Empno, Ename, Job, Mgr, Hired, Sal, Comm, Deptno
From Emp em1
where Empno not in (
Select p.Mgr 
From Emp p
where p.Mgr is not null)