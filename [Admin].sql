create database Book_Store
use Book_Store
create table [Admin]
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

USE Book_Store;

insert into [Admin] values('Mohim','Male' ,'Thursday, May 18, 2000' ,'mohim92@gmail.com ','01628409592','Chattogram','Feni','Admin1','admin1' );
insert into [Admin] values('Mohim','Male' ,'Thursday, May 18, 2000' ,'mohim92@gmail.com ','01628409592','Chattogram','Feni','11','11' );

USE Book_Store;
insert into [Admin] values('Mohim','Male' ,'Thursday, May 18, 2000' ,'sajibahmedrifat1234@gmail.com ','01628409592','Chattogram','Feni','123','321' );



select * from [Admin]
