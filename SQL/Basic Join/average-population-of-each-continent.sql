select p.continent, sum(c.population) / count(c.name)
from city c
    inner join country p on p.code = c.countrycode
group by p.continent