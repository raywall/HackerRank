declare @count int = 20

BEGIN
    WHILE @count > 0   
    BEGIN
        select right('* * * * * * * * * * * * * * * * * * * *', @count * 2);
        set @count = @count - 1;
    END;
END;