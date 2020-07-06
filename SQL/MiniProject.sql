USE Northwind

-- 1.1
--SELECT CustomerID, CompanyName, Address, City, Region, PostalCode, Country
--FROM Customers
--WHERE City IN ('London', 'Paris')
-- CORRECT

-- 1.2
--SELECT ProductName, QuantityPerUnit
--FROM Products
--WHERE QuantityPerUnit LIKE '%Bottle%'
--CORRECT

-- 1.3
--SELECT p.ProductName, p.QuantityPerUnit, s.CompanyName, s.Country
--FROM Products p
--INNER JOIN Suppliers s
--ON s.SupplierID = p.SupplierID
--WHERE QuantityPerUnit LIKE '%Bottle%'
--CORRECT

-- 1.4
--SELECT c.CategoryName, COUNT(p.ProductName) AS "Amount of products"
--FROM Products p
--JOIN Categories c on p.CategoryID = c.CategoryID
--GROUP BY c.CategoryName
--ORDER BY COUNT(p.ProductName) DESC;
--CORRECT

-- 1.5
--SELECT TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS 'Employee name', City
--FROM Employees
--WHERE Country = 'UK'
--CORRECT

-- 1.6 =============
--SELECT r.RegionID, r.RegionDescription, FORMAT(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)), 'C', 'en-gb') AS "Total Sales"
--FROM [Order Details] od
--INNER JOIN Orders o ON o.OrderID = od.OrderID
--INNER JOIN EmployeeTerritories et ON et.EmployeeID = o.EmployeeID
--INNER JOIN Territories t ON t.TerritoryID = et.TerritoryID
--INNER JOIN Region r ON r.RegionID = t.RegionID
--GROUP BY r.RegionDescription, r.RegionID
--HAVING SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) > 1000000
--ORDER BY "Total Sales" DESC
--CORRECT

-- 1.7
--SELECT COUNT (*) AS "Country: USA/UK, Weight: >100"
--FROM Orders o
--WHERE o.Freight > 100 AND o.ShipCountry IN ('USA', 'UK');
--CORRECT

-- 1.8
--SELECT TOP 1 od.OrderID, FORMAT(SUM(od.UnitPrice*od.Quantity*od.Discount), 'C', 'en-gb') AS "Discount Amount"
--FROM [Order Details] od
--GROUP BY od.OrderID
--ORDER BY SUM(od.UnitPrice*od.Quantity*od.Discount) DESC
--CORRECT

-- Exercise 2
--DROP TABLE IF EXISTS Spartans

--Create TABLE Spartans
--(
--	id INT PRIMARY KEY IDENTITY(1,1),
--	Title VARCHAR(50),
--	FirstName VARCHAR (50),
--	LastName VARCHAR (50),
--	UniversityAttended VARCHAR (255),
--	CourseTaken VARCHAR (50),
--	MarkAchieved VARCHAR(50)
--)

--INSERT INTO Spartans VALUES
--(
--	'Mr.',
--	'Chen',
--	'Shanmugarajah',
--	'Middlesex University',
--	'Computer Science',
--	'First'
--),
--(
--	'Dr.',
--	'Test',
--	'Example',
--	'Loughborough',
--	'Computer Science',
--	'First'
--)

--SELECT * FROM Spartans
--CORRECT

-- Exercise 3
-- 3.1
--SELECT e.FirstName + ' ' + e.LastName AS "Employee Name", m.FirstName + ' ' + m.LastName AS "Manager Name"
--FROM Employees e
--LEFT JOIN Employees m ON e.ReportsTo = m.EmployeeID
-- CORRECT

-- 3.2
--SELECT s.CompanyName,SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) As "Supplier Total"
--FROM [Order Details] od
--INNER JOIN Products p ON od.ProductID=p.ProductID
--INNER JOIN Suppliers s ON p.SupplierID=s.SupplierID
--GROUP BY s.CompanyName
--HAVING SUM(od.UnitPrice*od.Quantity*(1-od.Discount))>10000
--ORDER BY SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) DESC;
--CORRECT


-- 3.3
--SELECT TOP(10) c.CustomerID, c.CompanyName, FORMAT(SUM(od.Quantity*od.UnitPrice*(1-od.Discount)), 'C', 'en-gb') AS "Value of order"
--FROM [Order Details] od
--INNER JOIN Orders o ON o.OrderID = od.OrderID
--INNER JOIN Customers c ON c.CustomerID = o.CustomerID
--WHERE FORMAT(o.OrderDate, 'yyyy') = (SELECT TOP 1 FORMAT(Orders.OrderDate, 'yyyy') FROM Orders ORDER BY Orders.OrderDate DESC) AND o.ShippedDate IS NOT NULL
----WHERE o.OrderDate > DATEADD(YEAR, -1, (SELECT TOP 1 FORMAT(Orders.OrderDate, 'yyyy') FROM Orders ORDER BY Orders.OrderDate DESC))
--GROUP BY c.CompanyName, c.CustomerID
--ORDER BY SUM(od.Quantity*od.UnitPrice*(1-od.Discount)) DESC
-- CORRECT

-- 3.4
--SELECT FORMAT(o.OrderDate, 'MM/yyyy') AS "Month" ,
--AVG(CAST(DATEDIFF(day, o.OrderDate, o.ShippedDate) AS DECIMAL(10,2))) AS "Days from ordered till shipped"
--FROM Orders o
--WHERE o.ShippedDate IS NOT NULL
--GROUP BY FORMAT(o.OrderDate, 'MM/yyyy')
--ORDER BY FORMAT(o.OrderDate, 'MM/yyyy')
-- CORRECT