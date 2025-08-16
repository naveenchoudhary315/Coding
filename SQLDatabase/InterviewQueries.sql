
 --Find the second highest salary
Select max(salary) as SecondHighestSalary from Employee
 where salary < (select max(salary) from Employee);


 --Usng CTE to find the second highest salary
 SELECT Salary
FROM (
    SELECT Salary, ROW_NUMBER() OVER (ORDER BY Salary DESC) AS rn
    FROM Employee
) t
WHERE rn = 2;
 
 -- Find employees who earn the highest salary in each department
SELECT e.Name, e.Salary, d.DepartmentName
FROM Employee e
JOIN Department d ON e.DepartmentId = d.DepartmentId
WHERE e.Salary = (
    SELECT MAX(Salary) 
    FROM Employee 
    WHERE DepartmentId = e.DepartmentId
);


--Find duplicate employee names
 
	SELECT Name, COUNT(*) AS Count
	FROM Employee
	GROUP BY Name
	HAVING COUNT(*) > 1
 
