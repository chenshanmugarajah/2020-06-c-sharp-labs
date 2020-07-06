--SELECT COUNT (City) AS "Number of Employees in London"
--FROM Employees
--WHERE City = 'London';

--SELECT *
--FROM Employees
--WHERE TitleOfCourtesy = 'Dr.'

--SELECT COUNT (Discontinued)
--FROM Products
--WHERE Discontinued = 1

--SELECT CompanyName, City, Country, Region
--FROM Customers WHERE Region='BC'

--SELECT CompanyName, ContactName
--FROM Customers
--WHERE Country = 'France'
--ORDER BY CompanyName 

--SELECT TOP 5 CompanyName, City
--FROM Customers
--WHERE Country = 'France'

--SELECT ProductNAme, UnitPrice
--FROM Products
--WHERE CategoryID = 1 OR Discontinued = 0

--SELECT *
--FROM Customers
--WHERE Region LIKE '___A'

--SELECT *
--FROM Customers WHERE Region IN ('WA','SP')

--SELECT *
--FROM Customers WHERE Region = 'WA' OR Region = 'SP'

SELECT *
FROM EmployeeTerritories
WHERE TerritoryID BETWEEN 06800 AND 09999