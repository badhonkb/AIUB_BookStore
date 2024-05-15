use Book_Store
create table [BookInfo]
( 
	Book_ID int PRIMARY KEY IDENTITY(1,1),
	Title VARCHAR(50),
	Author_Name varchar (50),
	Category varchar (50),  
	Quantity int, 
	Price int

);


INSERT INTO [BookInfo] (Title, Author_Name, Category, Quantity, Price)
VALUES ('Book1', 'Author1', 'Fiction', 100, 20),
       ('Book2', 'Author2', 'Non-Fiction', 50, 30);

select * from [BookInfo]

DROP TABLE IF EXISTS [BookInfo];

drop table [BookInfo]