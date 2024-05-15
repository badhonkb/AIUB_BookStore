create database Book_Store
use Book_Store
create table [Buyer]
( 
	Name VARCHAR(50),
    Gender varchar (50),
	DOB  varchar (50),
	Gmail Varchar(50),
	Mobile_Number varchar (50),
	Division varchar (50),
	District  varchar (50),
	User_Id VARCHAR(50) PRIMARY KEY,
	Password VARCHAR(50)
);

select * from [Buyer]
select * from [Seller]

select * from [Buyer] b,[Seller] s where b.User_Id=s.User_Id;

insert into [Buyer] values('Mohim','Male' ,'Thursday, May 18, 2000' ,'mohim92@gmail.com ','01628409592','Chattogram','Feni','Admin1','admin1' );

use Book_Store
insert into [Buyer] values('gafana','Male' ,'Thursday, May 18, 2000' ,'aminaferdous1120@gmail.com ','01628409592','Chattogram','Feni','b','b' );

SELECT * FROM [Seller] 
    WHERE UPPER(User_Id) = UPPER('salma')
    UNION ALL
    SELECT * FROM [Buyer] 
    WHERE UPPER(User_Id) = UPPER('salma') ;

	SELECT * FROM [Buyer] WHERE User_Id = 'salma';