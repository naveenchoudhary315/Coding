GO
CREATE TABLE Department (
    DepartmentId INT PRIMARY KEY,
    DepartmentName VARCHAR(100) NOT NULL
);


CREATE TABLE Employee (
    EmployeeId INT PRIMARY KEY,
    Name VARCHAR(100) NOT NULL,
    Salary DECIMAL(10,2),
    DepartmentId INT,
    FOREIGN KEY (DepartmentId) REFERENCES Department(DepartmentId)
);


INSERT INTO Department (DepartmentId, DepartmentName) VALUES
(1, 'HR'),
(2, 'IT'),
(3, 'Finance');

INSERT INTO Employee (EmployeeId, Name, Salary, DepartmentId) VALUES
(101, 'Alice', 6000, 1),
(102, 'Bob', 8000, 2),
(103, 'Charlie', 5000, 2),
(104, 'David', 7500, 3),
(105, 'Eve', 9000, 2);

SELECT * FROM Employee;

----Get employees with salary greater than 7000
--SELECT Name, Salary
--FROM Employee
--WHERE Salary > 7000;


----Find employees with their department names (JOIN)
--SELECT e.Name, e.Salary, d.DepartmentName
--FROM Employee e
--JOIN Department d ON e.DepartmentId = d.DepartmentId;
