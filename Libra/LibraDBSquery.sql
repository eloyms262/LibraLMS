select * from UserRegistry;
select * from BookRegistry;
select * from BorrowRegistry;

select * from ArchivedUserRegistry;
select * from ArchivedBookRegistry;

drop table UserRegistry;
drop table BookRegistry;
drop table BorrowRegistry;

create table UserRegistry (
	UserID bigint identity(1,1) primary key not null,
	Username varchar(50) not null,
	UserPassword varchar(50) not null,
	UserType varchar(20) not null,
);

create table BookRegistry (
	BookID bigint identity(1,1) primary key not null,
	BookTitle varchar(50) null,
	BookAuthor varchar(50) null,
	BookPublisher varchar(50) null,
	BookStatus varchar(20) null
);

create table BorrowRegistry (
	BorrowID bigint identity(1,1) primary key not null,
	UserID bigint foreign key (UserID) references UserRegistry(UserID),
	BookID bigint foreign key (BookID) references BookRegistry(BookID),
	BorrowDate date null,
	ReturnDate date null,
);

alter table UserRegistry
alter column Username year;
alter table UserRegistry
alter column UserPassword year;

insert into UserRegistry values 
('Admin', '12345', 'Admin')