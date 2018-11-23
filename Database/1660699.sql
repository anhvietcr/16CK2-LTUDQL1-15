
Create table Tram (
ID_Tram int primary key not null,
TenTram nvarchar(4000),
Dia_diem nvarchar(4000)
)
Create table Tuyen(
ID_Tuyen int primary key not null,
KhoangCach real,
ThoiGianChay int,
Tram_ID_Tram1 int,
Tram_ID_Tram int
)
Create table Tram_trung_gian(
Tuyen_ID_Tuyen int not null,
Tram_ID_Tram int not null,
Primary key(Tuyen_ID_Tuyen,Tram_ID_Tram)
)

Alter table Tuyen 
add constraint Tuyen_Tram_FK 
foreign key (Tram_ID_Tram)
references Tram(ID_Tram)
go

Alter table Tuyen 
add constraint Tuyen_Tram_FKv2 
foreign key (Tram_ID_Tram1)
references Tram(ID_Tram)
go

Alter table Tram_trung_gian
add constraint Tram_trung_gian_Tuyen_FK 
foreign key (Tuyen_ID_Tuyen)
references Tuyen(ID_Tuyen)
go

Alter table Tram_trung_gian
add constraint Tram_trung_gian_Tram_FK 
foreign key (Tram_ID_Tram)
references Tram(ID_Tram)
go

