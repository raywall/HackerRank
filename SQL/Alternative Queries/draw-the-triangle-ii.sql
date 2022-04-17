declare @count int = 1

BEGIN
    WHILE @count <= 20   
    BEGIN
        select right('* * * * * * * * * * * * * * * * * * * *', @count * 2);
        set @count = @count + 1;
    END;
END;