CREATE TABLE question (
  ID int NOT NULL primary key identity(1,1),
  Noi_dung nvarchar(40) NOT NULL,
  Hoc_phan nvarchar(20) NOT NULL,
  Kieu_cau_hoi nvarchar(20) NOT NULL
)

CREATE TABLE trac_nghiem (
  STT int NOT NULL primary key identity(1,1),
  ID_question int NOT NULL foreign key references question(ID) ON DELETE CASCADE ,
  A nvarchar(50) NOT NULL,
  B nvarchar(50) NOT NULL,
  C nvarchar(50) NOT NULL,
  D nvarchar(50) NOT NULL,
  Lua_chon char NOT NULL,
  Diem float NOT NULL
)

CREATE TABLE tu_luan (
  STT int NOT NULL primary key identity(1,1),
  ID_question int NOT NULL foreign key references question(ID) ON DELETE CASCADE ,
  Diem float NOT NULL
)

select * from question
select * from trac_nghiem;
select * from tu_luan;

delete from question;

drop table  trac_nghiem, tu_luan;
drop table question;

DBCC CHECKIDENT (question, 1, 0)