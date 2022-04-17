select sum(c.population) 
from city c 
    inner join country p on p.code = c.countrycode
where p.continent = 'Asia'