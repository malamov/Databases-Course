USE TelerikAcademy

--4. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
SELECT * FROM Departments

--5.Write a SQL query to find all department names.
SELECT Name FROM Departments

--6.Write a SQL query to find the salary of each employee.
SELECT FirstName , Salary FROM Employees

--7. Write a SQL to find the full name of each employee.
SELECT FirstName + ' ' + LastName AS [Full Name] FROM Employees

--8. Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like �John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
SELECT FirstName + '.' + LastName + '@telerik.com' AS [Full Email Adress] FROM Employees

--9. Write a SQL query to find all different employee salaries.
SELECT DISTINCT Salary FROM Employees

--10. Write a SQL query to find all information about the employees whose job title is �Sales Representative�.
SELECT * FROM Employees e
WHERE e.JobTitle = 'Sales Representative'

--11. Write a SQL query to find the names of all employees whose first name starts with "SA".
SELECT CONCAT(FirstName,' ',LastName) AS [Full Name] FROM Employees e
WHERE e.FirstName LIKE 'SA%'

--12. Write a SQL query to find the names of all employees whose last name contains "ei".
SELECT CONCAT(FirstName,' ',LastName) AS [Full Name] FROM Employees e
WHERE e.LastName LIKE '%ei%'

--13. Write a SQL query to find the salary of all employees whose salary is in the range [20000�30000].
SELECT CONCAT(FirstName,' ',LastName) AS [Full Name],Salary FROM Employees 
WHERE Salary BETWEEN 20000 AND 30000

--14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
SELECT CONCAT(FirstName,' ',LastName) AS [Full Name],Salary FROM Employees 
WHERE Salary IN (25000, 14000, 12500 , 23600)

--15. Write a SQL query to find all employees that do not have manager.
SELECT CONCAT(FirstName,' ',LastName) AS [Full Name] FROM Employees
WHERE ManagerID IS NULL

--16. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
SELECT CONCAT(FirstName,' ',LastName) AS [Full Name],Salary FROM Employees 
WHERE Salary < 50000
ORDER BY Salary DESC

--17. Write a SQL query to find the top 5 best paid employees.
SELECT TOP 5 CONCAT(FirstName,' ',LastName) AS [Full Name],Salary FROM Employees
ORDER BY Salary DESC

--18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.
SELECT CONCAT (FirstName, ' ', LastName) AS [Full Name], AddressText
FROM Employees e JOIN Addresses a
ON e.AddressID = a.AddressID

--19. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
SELECT CONCAT (FirstName, ' ', LastName) AS [Full Name], AddressText
FROM Employees,Addresses
WHERE Employees.AddressID = Addresses.AddressID

--20. Write a SQL query to find all employees along with their manager.
SELECT CONCAT (e.FirstName, ' ', e.LastName) AS FullName, CONCAT (m.FirstName, ' ', m.LastName) AS ManagerFullName
FROM Employees e JOIN Employees m
ON e.ManagerID = m.EmployeeID

--21. Write a SQL query to find all employees, along with their manager and their address.
-- Join the 3 tables: Employees e, Employees m and Addresses a.
SELECT CONCAT (e.FirstName, ' ', e.LastName) AS FullName, CONCAT (m.FirstName, ' ', m.LastName) AS ManagerFullName, a.AddressText
FROM Employees e, Employees m, Addresses a
WHERE e.ManagerID = m.EmployeeID AND a.AddressID = e.AddressID

--22. Write a SQL query to find all departments and all town names as a single list. Use UNION.
SELECT Name FROM Departments
UNION
SELECT Name FROM Towns

-- Task 23 - Write a SQL query to find all the employees and the manager for each of them along with
-- the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName,  CONCAT(m.FirstName, ' ', m.LastName) ManagerFullName
FROM Employees e
RIGHT OUTER JOIN Employees m
ON e.ManagerID = m.EmployeeID

SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName,  CONCAT(m.FirstName, ' ', m.LastName) ManagerFullName
FROM Employees m
LEFT JOIN Employees e
ON e.ManagerID = m.EmployeeID

-- Task 24 - Write a SQL query to find the names of all employees from the departments
-- "Sales" and "Finance" whose hire year is between 1995 and 2005.
SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName, d.Name, e.HireDate
FROM Employees e JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name IN('Sales', 'Finance') AND year(e.HireDate) BETWEEN 1995 AND 2005

SELECT CONCAT(e.FirstName, ' ', e.LastName) AS FullName, d.Name, e.HireDate
FROM Employees e, Departments d
WHERE e.DepartmentID = d.DepartmentID AND d.Name IN('Sales', 'Finance') AND year(e.HireDate) BETWEEN 1995 AND 2005