select c.name 
from city c
    inner join country p on c.countrycode = p.code 
where p.continent = 'Africa'