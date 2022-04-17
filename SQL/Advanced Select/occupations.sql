SELECT
    Doctors,
    Professors,
    Singers,
    Actors
FROM 
(
    SELECT
        ID,
        MAX(CASE Occupation WHEN 'Doctor'       THEN Name END) As Doctors,
        MAX(CASE Occupation WHEN 'Professor'    THEN Name END) As Professors,
        MAX(CASE Occupation WHEN 'Singer'       THEN Name END) As Singers,
        MAX(CASE Occupation WHEN 'Actor'        THEN Name END) As Actors
    FROM 
    (
        SELECT
            Occupation,
            Name,
            ROW_NUMBER() OVER(PARTITION BY Occupation ORDER BY Name ASC) As ID
        FROM 
            Occupations
    ) As NameLists
    GROUP BY ID
) As Names