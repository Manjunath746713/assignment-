DECLARE @myvar as numeric(7,2) = 3

SELECT POWER(@myvar,3)
SELECT SQUARE(@myvar) 
SELECT POWER(@myvar,0.5) 
SELECT SQRT(@myvar)

GO

DECLARE @myvar as numeric(7,2) = 12.345

SELECT FLOOR(@myvar) 
SELECT CEILING(@myvar) 
SELECT ROUND(@myvar,-1) as myRound 

GO

SELECT PI() as myPI
SELECT EXP(1) as e

DECLARE @myvar AS NUMERIC(7,2) = -456

SELECT ABS(@myvar) as myABS, SIGN(@myvar) as mySign 

GO

SELECT RAND(345) 
