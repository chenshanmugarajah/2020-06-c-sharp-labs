--SELECT FirstName + ' ' + LastName AS 'Name', FLOOR(DATEDIFF(dd, BirthDate, GETDATE())/365.25) AS 'Age'
--FROM Employees

--SELECT
--CASE
--WHEN DATEDIFF(dd, OrderDate, ShippedDate) < 10 THEN 'On time'
--ELSE 'Overdue'
--END
--AS 'Status'
--FROM Orders

SELECT
FLOOR(DATEDIFF(dd, BirthDate, GETDATE())/365.25) AS 'Age',
CASE
WHEN DATEDIFF(dd, BirthDate, GETDATE())/365.25 > 65 THEN 'Retired'
WHEN DATEDIFF(dd, BirthDate, GETDATE())/365.25 > 60 THEN 'Retirement due'
ELSE 'More than 5 years to go'
END
AS 'Time till retirement'
FROM Employees