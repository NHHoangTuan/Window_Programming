create database DataPhone
go

use DataPhone
go

CREATE TABLE Phone (
    PhoneID INTEGER PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(MAX),
    ImagePath NVARCHAR(MAX),
    Manufacturer NVARCHAR(MAX),
    Price INTEGER
);

-- Insert data into the Phone table
INSERT INTO Phone (Name, ImagePath, Manufacturer, Price) VALUES
    ( 'iPhone 14 Pro Max', 'Images/1.png', 'Apple', 27290000),
    ( 'iPhone 14 Pro', 'Images/2.png', 'Apple', 25290000),
    ( 'Samsung Galaxy S21 FE', 'Images/3.png', 'Samsung', 10990000),
    ( 'Xiaomi Redmi 12C', 'Images/4.png', 'Xiaomi', 2890000),
	( 'Samsung Galaxy S23 Ultra', 'Images/5.png', 'Samsung', 26990000),
    ( 'iPhone 11 64GB', 'Images/6.png', 'Apple', 10590000),
	( 'Vivo Y35', 'Images/7.png', 'Vivo', 6290000),
    ( 'OPPO Reno8 T 5G', 'Images/8.png', 'OPPO', 10990000),
	( 'Samsung Galaxy A23', 'Images/9.png', 'Samsung', 4790000),
    ( 'Samsung Galaxy S20 FE', 'Images/10.png', 'Samsung', 8650000),
	( 'iPhone 14 128GB', 'Images/11.png', 'Apple', 19590000),
    ( 'iPhone 15', 'Images/12.png', 'Apple', 21990000),
	( 'iPhone 15 Plus', 'Images/13.png', 'Apple', 24990000),
    ( 'iPhone 15 Pro', 'Images/14.png', 'Apple', 28190000),
	( 'iPhone 15 Pro Max', 'Images/15.png', 'Apple', 32990000);
    