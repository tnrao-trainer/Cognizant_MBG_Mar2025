create database Apr2025Db

CREATE TABLE Students (
    StudentID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Age INT,
    Course NVARCHAR(50)
);


SELECT * FROM Students;
