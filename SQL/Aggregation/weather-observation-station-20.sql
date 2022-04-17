select 
    cast(lat_n as decimal(18,4))
from
(
    select
        lat_n, 
        row_number() over (order by lat_n) as id
    from
        station
) as d
where
    id = (select round((count(lat_n) + 1) / 2,0) from station);