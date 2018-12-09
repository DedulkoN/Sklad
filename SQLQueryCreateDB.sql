create database Sklad;
go
use Sklad;
go
Create table RoleUsers
(
RoleUserID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
NameRoleUser [varchar](128) Not NULL
)
go
Create table Users
(
UsersID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
UserLogin [varchar](128) Not NULL,
UserPassword [varchar](128) Not NULL,
RolesUser [smallint] REFERENCES RoleUsers(RoleUserID),
FIO [varchar](128) Not NULL,
Phone [varchar](16)  NULL
)
go
Create table Stellazh
(
StellazhID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
StellaxzName [varchar](128) Not NULL
)
go
Create table Shelf
(
ShelfID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
ShelfName [varchar](128) Not NULL
)
go
Create table TypeMaterial
(
TypeID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
TypeName [varchar](128) Not NULL
)
go
Create table purpose
(
purposeID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
purposeName [varchar](128) Not NULL
)
go
Create table Departament
(
DepartamentID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
DepartamentName [varchar](128) Not NULL,
Phone [varchar](16) NULL,
FIOSypervisor [varchar](128) NULL
)
go
Create table Materials
(
MaterialsID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
NameMaterial [varchar](128) not NULL,
TypeMaterialID [smallint] REFERENCES TypeMaterial(TypeID),
DepartamentID [smallint] REFERENCES Departament(DepartamentID),
StellazhID [smallint] REFERENCES Stellazh(StellazhID),
ShelfID [smallint] REFERENCES Shelf(ShelfID),
purposeID [smallint] REFERENCES purpose(purposeID)
)
go
Create table TypeOrders
(
TypeOrdersID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
TypeOrdersName [varchar](128) Not NULL
)
go
Create table Orders
(
OrdersID [smallint] NOT NULL IDENTITY(1,1) PRIMARY KEY,
TypeOrdersID [smallint] REFERENCES TypeOrders(TypeOrdersID),
DateOrder Date not null,
MaterialId [smallint] REFERENCES Materials(MaterialsID),
WhoCreateOrder [smallint] REFERENCES Users(UsersID),
Info [varchar](128) not null
)