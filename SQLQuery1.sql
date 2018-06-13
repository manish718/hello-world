Create Table Actors(
Actor_ID int Constraint pk_Actor_ID primary key identity(1,1) NOT NULL,
Name VARCHAR(50) NOT NULL,
Sex CHAR(1) Constraint ck_Sex CHECK(Sex='M' or Sex='m' or Sex='f' or Sex='F') NOT NULL,
DOB datetime NOT NULL,
Bio NVARCHAR(50) 


)

go

Create Table Producer(
Producer_ID int Constraint pk_Producer_ID primary key identity(1,1) NOT NULL,
Name VARCHAR(50) NOT NULL,
Sex CHAR(1) Constraint ck__Producer_Sex CHECK(Sex='M' or Sex='m' or Sex='f' or Sex='F') NOT NULL,
DOB datetime NOT NULL,
Bio NVARCHAR(50) 

)
go
Create Table Movies(
Movie_ID int Constraint pk_Movie_ID primary key identity(1,1) NOT NULL,
YearOfRelease datetime NOT NULL,
Plot NVARCHAR(50) ,
Poster VARBINARY(max) NOT NULL,
P_ID int CONSTRAINT fk_ProducerID REFERENCES Producer(Producer_ID)

)
go
Create Table Movie_Cast(
ID int Constraint pk_Movie_Cast primary key identity(1,1) NOT NULL,
A_ID int Constraint fk_A_ID_Movie_Cast REFERENCES Actors(Actor_ID),
M_ID int Constraint fk_M_ID_Movie_Cast REFERENCES Movies(Movie_ID)
)