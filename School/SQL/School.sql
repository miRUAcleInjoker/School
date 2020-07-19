create schema if not exists School collate utf8_general_ci;

create table if not exists StudentScore
(
	sid int not null,
	cid int not null,
	score int not null,
	primary key (sid, cid)
);

create table if not exists course
(
	cid int auto_increment
		primary key,
	cname varchar(30) null,
	tid int null
);

create table if not exists student
(
	sid int auto_increment
		primary key,
	sname varchar(30) not null,
	sage int(3) not null,
	ssex tinyint not null
);

create table if not exists teacher
(
	tid int auto_increment
		primary key,
	tname varchar(30) null
);

