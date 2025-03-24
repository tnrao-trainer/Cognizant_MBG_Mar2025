-- SQL Queries to demonstrate functions and filtrations in MySql

select * from emps;


delete from emps where empno = 7844;

SELECT ename, salary, salary + 1000 AS New_Salary 
FROM emps;



SELECT ename, salary 
FROM emps
WHERE salary < 5000;


SELECT ename, salary, deptno
FROM emps
WHERE salary > 5000 AND deptno = 20;


-- Commonly Used SQL Functions with Examples

SELECT empno, CONCAT(ename, ' - ', job) AS employee_details 
FROM emps;

SELECT ename, NULLIF(salary, 1250) AS salary_check
FROM emps;



 
 
SELECT deptno, AVG(salary) AS avg_salary
FROM emps
GROUP BY deptno;



SELECT MIN(salary) AS lowest_salary 
FROM emps;


SELECT MAX(salary) AS highest_salary 
FROM emps;

 
SELECT ename, NULLIF(salary, 1250) AS salary_check
FROM emps;

 
 
-- **ORDER BY** - Sorts the result
 
SELECT ename, salary 
FROM emps
ORDER BY salary DESC;

 

-- GROUP BY - Groups rows that have the same values,  '
-- Shows the number of employees in each department.
SELECT deptno, COUNT(empno) AS total_employees
FROM emps
GROUP BY deptno;


-- HAVING - Filters groups created by GROUP BY
-- Eg:  Displays departments where the average salary is greater than 60,000.

SELECT deptno, round(AVG(salary)) AS avg_salary
FROM emps
GROUP BY deptno
HAVING round(AVG(salary)) > 4000;


--  Another Example it includes all options 
-- Eg:  Groups emps by department, filters departments with average salary > 60K, and sorts the result.

SELECT deptno, COUNT(empno) AS total_employees, AVG(salary) AS avg_salary
FROM emps
GROUP BY deptno
HAVING AVG(salary) > 4000
ORDER BY avg_salary DESC;





