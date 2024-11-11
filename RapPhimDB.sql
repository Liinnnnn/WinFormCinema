--create database QLRapPhim

use QLRapPhim

create table tblUser(
	UserID int IDENTITY(1,1) primary key,
	Name nvarchar(50),
	Gender nvarchar(10),
	BirthDay Date,
	TypeUser varchar(10) --HSSV:-10%,
);

CREATE TABLE tblCinema (
    CinemaID varchar(20) primary key,
    CinemaName NVARCHAR(50) NOT NULL,
    Address NVARCHAR(100)
);

CREATE TABLE tblShowRoom (
    RoomID int IDENTITY(1,1) primary key,
	RoomName nvarchar(50),
	CinemaID varchar(20)
	FOREIGN KEY (CinemaID) REFERENCES tblCinema(CinemaID),
);

create table tblStaff
(
	StaffID varchar(50) primary key,
	Name nvarchar(50),
	Gender nvarchar(10),
	BirthDay Date,
	NumberPhone varchar(12),
	WorkStartDate Date,
	Password nvarchar(20),
	Type_Account nvarchar(10),
	CinemaID varchar(20)
	foreign key (CinemaID) references tblCinema(CinemaID)
);

create table tblFilm
(
	FilmID varchar(20) primary key,
	Name nvarchar(50),
	Language nvarchar(50),
	Director nvarchar(50),
	ProductionDate Date,
	Price int,
	Status nvarchar(20),
	FilmImg nvarchar(50),
	AgeAllowed int
);

create table tblShowtime
(
	ShowtimeID varchar(50) primary key,
	FilmID varchar(20),
	CinemaID varchar(20),
	RoomID int,
	Showtime datetime,
	FOREIGN KEY (FilmID) REFERENCES tblFilm(FilmID),
    FOREIGN KEY (CinemaID) REFERENCES tblCinema(CinemaID),
	FOREIGN KEY (RoomID) REFERENCES tblShowRoom(RoomID)
	on update cascade
);


create table tblInvoice
(
	InvoiceID int IDENTITY(1,1) PRIMARY key,
    PaymentDate DATETIME NOT NULL,
    PaymentMethod NVARCHAR(50), -- Phương thức thanh toán (ví dụ: thẻ, tiền mặt)
	Discount int,
	ToTal int,
    UserID INT,
	StaffID varchar(50),
    FOREIGN KEY (UserID) REFERENCES tblUser(UserID),
    FOREIGN KEY (StaffID) REFERENCES tblStaff(StaffID)
	on update cascade
);

--CREATE TABLE tblSeat (
--	SeatID int IDENTITY(1,1) primary key,
--    SeatName nvarchar(50),
--	Status int,
--	RoomID nvarchar(50),
--    FOREIGN KEY (RoomID) REFERENCES tblShowRoom(RoomID),
--);

create table tblTicket
(
	TicketID int IDENTITY(1,1) primary key,
	TypeTicket varchar(10), --HSSV: hoc sinh sinh vien, C < 10 tuoi, N: vé bình thường 
	ShowtimeID varchar(50),
	InvoiceID int,
	Seat nvarchar(10),
	FinalPrice int,
	FOREIGN KEY (ShowtimeID) REFERENCES tblShowtime(ShowtimeID),
	FOREIGN KEY (InvoiceID) REFERENCES tblInvoice(InvoiceID)
	on update cascade
);


--insert tblCinema
insert tblCinema (CinemaID,CinemaName,Address) values (N'SKPGP',N'Skope Giải Phóng',N'67-Định Công-Hoàng Mai-Hà Nội')
insert tblCinema (CinemaID,CinemaName,Address) values (N'SKPNT',N'Skope Nguyễn Trãi',N'120-Nguyễn Trãi-Thanh Xuân-Hà Nội')
insert tblCinema (CinemaID,CinemaName,Address) values (N'SKPCG',N'Skope Cầu Giấy',N'3-Cầu Giấy-Đống Đa-Hà Nội')
insert tblCinema (CinemaID,CinemaName,Address) values (N'SKPHD',N'Skope Hải Dương',N'158-Ngô Quyền-Hải Dương')
--insert tblStaff
insert tblStaff (StaffID,Name,Password,Type_Account) values ('Admin','admin','admin','Admin')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV001',N'Nguyễn Thế Định',N'Nam','5-18-2004','0984983258','2-25-2024','123','Staff','SKPHD')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV002',N'Nguyễn Văn Hải',N'Nam','8-8-2004','0947365489','4-5-2023','123','Staff','SKPNT')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV003',N'Nguyễn Tuần Linh',N'Nữ','3-8-2005','0947884783','7-4-2022','123','Staff','SKPCG')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV004',N'Vũ Đức Duy Anh',N'Nam','10-20-2004','0968473463','9-1-2024','123','Staff','SKPGP')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV005',N'Phí Gia Huy',N'Nam','9-2-2003','0875673245','1-1-2023','123','Staff','SKPGP')
insert tblStaff (StaffID,Name,Gender,BirthDay,NumberPhone,WorkStartDate,Password,Type_Account,CinemaID) values (N'NV006',N'Nguyễn Minh Hiếu','Nam','4-4-2004','0985746375','2-25-2024','123','Staff','SKPHD')
--insert tblFilm
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status,AgeAllowed) values (N'PB',N'Peaky Blinders',N'Tiếng Anh',N'Steven Knight','9-12-2013',50000,N'Đang Chiếu','17')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status,AgeAllowed) values (N'CC',N'CoCo',N'Tiếng Anh',N'Lee Unkrich','10-20-2017',70000,'Đang Chiếu','13')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status,AgeAllowed) values (N'MDD',N'Mộ Đom Đóm',N'Tiếng Nhật',N'Takahata Isao','4-16-1988',70000,N'Đang Chiếu','13')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status,AgeAllowed) values (N'BWY',N'Be With You',N'Tiếng Hàn',N'Lee Jang-hoon','3-14-2018',70000,N'Đang Chiếu','13')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status,AgeAllowed) values (N'NBN',N'Nhà Bà Nữ',N'Tiếng Việt',N'Trấn Thành','1-11-2023',80000,N'Ngừng Chiếu','13')
insert tblFilm (FilmID,Name,Language,Director,ProductionDate,Price,Status,AgeAllowed) values (N'EVT',N'Em Và Trịnh',N'Tiếng Việt',N'Phan Gia Nhật Linh','6-10-2022',70000,N'Đang Chiếu','17')
--insert ShowRoom
insert tblShowRoom (RoomName,CinemaID) values ('SKPGP01','SKPGP')
insert tblShowRoom (RoomName,CinemaID) values ('SKPGP02','SKPGP')
insert tblShowRoom (RoomName,CinemaID) values ('SKPGP03','SKPGP')
insert tblShowRoom (RoomName,CinemaID) values ('SKPGP04','SKPGP')

insert tblShowRoom (RoomName,CinemaID) values ('SKPCG01','SKPCG')
insert tblShowRoom (RoomName,CinemaID) values ('SKPCG02','SKPCG')
insert tblShowRoom (RoomName,CinemaID) values ('SKPCG03','SKPCG')

insert tblShowRoom (RoomName,CinemaID) values ('SKPNT01','SKPNT')
insert tblShowRoom (RoomName,CinemaID) values ('SKPNT02','SKPNT')
insert tblShowRoom (RoomName,CinemaID) values ('SKPNT03','SKPNT')
insert tblShowRoom (RoomName,CinemaID) values ('SKPNT04','SKPNT')
insert tblShowRoom (RoomName,CinemaID) values ('SKPNT05','SKPNT')

insert tblShowRoom (RoomName,CinemaID) values ('SKPHD01','SKPHD')
insert tblShowRoom (RoomName,CinemaID) values ('SKPHD02','SKPHD')
insert tblShowRoom (RoomName,CinemaID) values ('SKPHD03','SKPHD')
insert tblShowRoom (RoomName,CinemaID) values ('SKPHD04','SKPHD')

--insert Showtime
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST1','PB','SKPCG','9-11-2024 18:00:00','5')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST2','CC','SKPCG','9-11-2024 20:00:00','5')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST3','NBN','SKPCG','9-11-2024 22:00:00','5')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST4','MDD','SKPCG','9-11-2024 18:00:00','6')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST5','EVT','SKPCG','9-11-2024 20:00:00','6')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST6','BWY','SKPCG','9-11-2024 22:00:00','6')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST7','MDD','SKPCG','9-11-2024 18:00:00','7')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST8','PB','SKPCG','9-11-2024 20:00:00','7')
insert tblShowtime (ShowtimeID,FilmID,CinemaID,Showtime,RoomID) values ('ST9','NBN','SKPCG','9-11-2024 22:00:00','7')
