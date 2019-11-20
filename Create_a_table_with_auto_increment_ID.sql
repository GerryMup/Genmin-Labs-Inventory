CREATE TABLE Inventory (
    Item_ID int IDENTITY(1,1) PRIMARY KEY,
    Name varchar(255) NOT NULL,
    Description varchar(255),
    Manufacturer varchar(100),
	Category varchar (100),
	Number varchar (25),
	Available varchar (3),
	Condition varchar (50),
	Location varchar (100),
);