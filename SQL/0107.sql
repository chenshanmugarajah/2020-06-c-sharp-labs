--SELECT SUM(UnitsOnOrder) AS 'Total on Order',
		--AVG(UnitsOnOrder) AS 'Avg on Order',
		--MIN(UnitsOnOrder) AS 'Min on Order',
		--MAX(UnitsOnOrder) AS 'Max on Order',
		--SupplierID
--FROM Products
--GROUP BY SupplierID

--SELECT CategoryID, AVG (ReorderLevel) AS "Average Reorder Level"
--FROM Products
--GROUP BY CategoryID
--ORDER BY "Average Reorder Level" DESC
--ORDER BY AVG (ReorderLevel) DESC

-- === Filter based on an average ===
--SELECT SupplierID,
--SUM (UnitsOnOrder) AS "Total on Order",
--AVG (UnitsOnOrder) AS "Average on Order"
--FROM Products
--GROUP BY SupplierID
--HAVING AVG(UnitsOnOrder)>26

--SELECT et.EmployeeID, e.FirstName + ' ' + e.LastName AS "Employee name",
--COUNT(et.TerritoryID) AS "Number of territories covered"
--FROM EmployeeTerritories et
--INNER JOIN Employees e
--ON et.EmployeeID = e.EmployeeID
--GROUP BY et.EmployeeID, e.FirstName + ' ' + e.LastName
--HAVING COUNT(et.TerritoryID)>5

--SELECT s.name, c.name
--FROM student s
--INNER JOIN course c
--ON s.course = c.id

--SELECT s.SupplierID, s.CompanyName, AVG(p.UnitsOnOrder) AS "Average of units on order"
--FROM Products p
--INNER JOIN Suppliers s
--ON s.SupplierID = p.SupplierID
--GROUP BY s.CompanyName, s.SupplierID
--HAVING AVG(p.UnitsOnOrder)=0
--ORDER BY AVG(p.UnitsOnOrder) DESC

--SELECT p.ProductName, p.UnitPrice, s.CompanyName AS "Supplier", c.CategoryName AS "Category"
--FROM Products p
--INNER JOIN Suppliers s ON p.SupplierID = s.SupplierID
--INNER JOIN Categories c ON p.CategoryID = c.CategoryID

--SELECT c.CompanyName AS "Customer Name", e.FirstName + ' ' + e.LastName AS "Employee Name"
--FROM Orders o
--INNER JOIN Employees
--ON o.EmployeeID

--SELECT o.OrderID, FORMAT(o.OrderDate, 'dd/MM/yyyy') AS "Order date", o.Freight, c.CompanyName AS "Customer Name", e.FirstName + ' ' + e.LastName AS "Employees Name"
--FROM Orders o
--JOIN Employees e ON e.EmployeeID = o.EmployeeID
--JOIN Customers c ON c.CustomerID = o.CustomerID

--SELECT e.FirstName + ' ' + e.LastName AS "Employee Name", m.FirstName + ' ' + m.LastName AS "Manager Name"
--FROM Employees e
--FULL JOIN Employees m ON e.ReportsTo = m.EmployeeID;

--SELECT CompanyName AS "Customer", CustomerID
--FROM Customers
--WHERE CustomerID NOT IN (SELECT CustomerID FROM Orders)

--SELECT c.CompanyName AS "Customers", c.CustomerID
--FROM Customers c
--LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
--WHERE o.OrderID IS NULL

--SELECT OrderID, ProductID, UnitPrice, Quantity, Discount, (SELECT MAX(UnitPrice) FROM [Order Details] od) AS "Max price"
--FROM [Order Details]

--SELECT od.ProductID, sq1.totalamt AS "Total Sold for this Product", 
--UnitPrice, UnitPrice/totalamt*100 AS "% of Total"
--    FROM [Order Details] od
--    INNER JOIN 
--        (SELECT ProductID, SUM(UnitPrice*Quantity) AS totalamt
--        FROM [Order Details]
--        GROUP BY ProductID) sq1 ON sq1.ProductID=od.ProductID;

--SELECT ProductID, SUM(UnitPrice*Quantity) AS "TotalSold", UnitPrice, UnitPrice/SUM(UnitPrice*Quantity) AS "% of Total"
--FROM [Order Details]

--select 'union'
--select e.employeeid, e.FirstName from employees e
--union all
--select s.supplierid, s.CompanyName from suppliers s

--Using a Subquery in the WHERE clause, list all Orders (Order ID, Product ID, Unit Price, Quantity and Discount) from the
--[Order Details] table where the product has been discontinued

--Now repeat the same exercise using a simple join

--SELECT o.OrderID, o.ProductID, o.UnitPrice, o.Quantity, o.Discount
--FROM [Order Details] o
--WHERE o.ProductID IN (SELECT ProductID FROM Products WHERE Discontinued=1)