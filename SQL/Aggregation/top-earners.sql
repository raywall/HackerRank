select  
    t.total, count(e.employee_id) 
from    
    employee e
    INNER JOIN (
        select   top 1 (salary * months) as total 
        from     employee 
        order by (salary * months) desc) t 
    ON t.total = (e.salary * e.months) 
group by    
    t.total