CREATE TABLE Users
(
       Id int primary key identity (1 ,1 ),
       Username varchar (50 ),
       UserId varchar (50 )
)
 
CREATE TABLE Carts
(
       CartId int primary key Identity (1 ,1 ),
       UsersId int foreign key references Users (Id ),
       Guid varchar (50 ),
       Count int
)
 
CREATE TABLE Items
(
       ItemId int primary key Identity (1 ,1 ),
       CartId int foreign key references Carts (CartId ),
       DmGuid varchar (50 )
)

ALTER TABLE Items
	ADD MainTitle varchar(128)
