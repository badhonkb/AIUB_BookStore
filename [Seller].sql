create database Book_Store
use Book_Store
create table [Seller]
( 
	Name VARCHAR(50),
    Gender varchar (50),
	DOB  varchar (50),
	Gmail Varchar(50),
	Mobile_No varchar (50),
	NID_Birth_Cirtificate_No Varchar(50),
	Division varchar (50),
	District  varchar (50),
	User_Id VARCHAR(50) PRIMARY KEY,
	Password VARCHAR(50)
);

select * from [Seller]

use Book_Store
insert into [Seller] values('mohim','Male' ,'Thursday, May 18, 2000' ,'mdkhanpatowary980@gmail.com ','01628409592','234567','Chattogram','Feni','ak1','ak' );


DROP TABLE Seller;
