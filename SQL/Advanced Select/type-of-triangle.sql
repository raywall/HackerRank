select
case
    when (a + b) <= c then 'Not A Triangle'
    when  a = b and a = c then 'Equilateral'
    when  a = b or b = c or c = a then 'Isosceles'
    else 'Scalene'
end
from triangles