use obk;
drop table Manager;
drop table Store;
drop table Category;
drop table Menu;
drop table Orderlist;

create table Manager(
	managerNo int not null AUTO_INCREMENT,
	passwd varchar(10) not null,
	primary key (managerNo)
);

create table Store(
	sNo int AUTO_INCREMENT,
	sName varchar(20) not null,
	primary key (sNo)
);

create table Category(
	cNo int AUTO_INCREMENT,
	cName varchar(10) not null,
	primary key (cNo)
);

create table Menu(
	cNo int not null,
	mNo int not null AUTO_INCREMENT,
	mName varchar(20) not null,
	mPrice int not null,
	mImage varchar(100) not null,
	soldoutYn varchar(1) default ('N'),
	primary key (mNo)
);

create table Orderlist(
	oNo int not null AUTO_INCREMENT,
	mNo int not null,
	mName varchar(20) not null,
	mPrice int not null,
	allPrice int not null,
	oCount int not null,
	oTemp varchar(5) not null,
	oSize varchar(10) not null,
	oShot int not null,
	oCream int not null,
	sNo int not null,
	comYn varchar(1) not null default ('N'),
	comDate datetime not null default (SYSDATE()),
	primary key (oNo)
);