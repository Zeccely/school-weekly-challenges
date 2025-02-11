Select em1.Ename Manager, em1.Job, em1.Sal
From emp em1
inner Join Emp em2 on em1.Empno = em2.Mgr --give me the data where managers manage people
Group by Em1.Ename, em1.Job, em1.Sal
having Count(em2.Empno) >= 1--give me the ids of managers that manage more than 1 person?
