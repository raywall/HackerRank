select 
    cast(
        sqrt(
            power(max(lat_n)  - min(lat_n),  2)
          + power(max(long_w) - min(long_w), 2)
        ) as decimal(18, 4)) 
from 
    station