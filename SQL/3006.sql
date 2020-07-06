--SELECT ProductID, ProductName
--FROM Products
--WHERE (UnitPrice < 5.0)

--SELECT CategoryName
--FROM Categories
--WHERE CategoryName LIKE '[BS]%';

--SELECT COUNT (*) AS "Number of Orders"
--FROM Orders
--WHERE EmployeeID IN (5, 7);

--SELECT *
--FROM Categories
--WHERE CategoryName LIKE '[a-p]%';

--SELECT FirstName + ' ' + LastName + ', ' + HomePhone AS 'Employee Name and Contact Number'
--FROM Employees

--SELECT CompanyName AS 'Company Name', City + ',' + Country AS City
--FROM Customers
--WHERE Region IS NULL

--SELECT DISTINCT Country
--FROM Customers
--WHERE Region IS NOT NULL

--SELECT TOP 2 UnitPrice,
--		Quantity,
--		Discount, 
--		UnitPrice * Quantity AS 'Gross Total', 
--		UnitPrice * (Quantity * (1-discount)) AS 'Total with discount'
--FROM [Order Details]
--ORDER BY 'Gross Total' DESC;

--SELECT SUBSTRING ('alex', 2, 3) AS 'Substrings';

--SELECT CHARINDEX ('y', 'Harry') AS 'Index of letter';

--SELECT LEFT ('Chen', 3) AS 'Return N letters from name';

--SELECT RIGHT ('Christian', 3) AS 'Return n letter from right of name'

--SELECT LTRIM('    Amazing  ');

--SELECT REPLACE ('Nishant', 'i', 'a')

--SELECT UPPER('leo')
--SELECT LOWER('JOHN')

--SELECT LEN('Sparta')

--SELECT PostalCode AS 'Post Code',
--LEFT(PostalCode, CHARINDEX(' ', PostalCode)-1) AS 'Post Code Region',
--CHARINDEX(' ', PostalCode) AS 'Space found',
--Country
--FROM Customers
--WHERE Country = 'UK'

--SELECT *
--FROM Products
--WHERE CHARINDEX('''', ProductName) > 0

--SELECT * FROM Products
--WHERE (ProductName LIKE '%''%');

--SELECT GETDATE();

--SELECT SYSDATETIME();

--SELECT DATEADD(dd, 4, GETDATE()) AS 'Due date';

SELECT FORMAT(OrderDate, 'dd/MM/yyyy'), FORMAT(ShippedDate, 'dd/MM/yyyy'), DATEDIFF(dd, OrderDate, ShippedDate) AS 'Ship time'
FROM Orders

SELECT FORMAT(o.OrderDte, 'dd/MM/yyyy') AS 'Order Date'
FORMAT((od.UnitPrice*od.Quantity)*(1-od.Discount),'C', 'en-GB') AS 'Net total',
