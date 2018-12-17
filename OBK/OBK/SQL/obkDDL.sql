#create database obk;
use obk;

create table Admin(
	aNo int not null AUTO_INCREMENT,
	aName varchar(10) not null,
	passwd varchar(10) not null,
	primary key (aNo)
);

create table Store(
	sNo int not null AUTO_INCREMENT,
	sName varchar(20) not null,
	sCity varchar(20) not null,
	sGu varchar(20) not null,
	primary key (sNo)
);

create table Category(
	cNo int AUTO_INCREMENT,
	cName varchar(10) not null,
	primary key (cNo)
);

create table Menu(
	mNo int not null AUTO_INCREMENT,
	cNo int not null,
	mName varchar(20) not null,
	mPrice int not null,
	mImage varchar(100) not null,
	DegreeYn int not null,
	SizeYn int not null,
	ShotYn int not null,
	CreamYn int not null,
	sellYn varchar(1) default ('Y'),
	soldoutYn varchar(1) default ('N'),
	primary key (mNo),
	CONSTRAINT FK_Menu_Category FOREIGN KEY (cNo) REFERENCES Category (cNo)
);

create table Orderlist(
	oNo int not null AUTO_INCREMENT,
	mNo int not null,
	sNo int not null,
	oCount int not null,
	oDegree int not null,
	oSize int not null,
	oShot int not null,
	oCream int not null,
	comYn varchar(1) not null default ('N'),
	comDate datetime not null default (SYSDATE()),
	primary key (oNo),
	CONSTRAINT FK_Orderlist_Menu FOREIGN KEY (mNo) REFERENCES Menu (mNo),
	CONSTRAINT FK_Orderlist_Store FOREIGN KEY (sNo) REFERENCES Store (sNo)
);