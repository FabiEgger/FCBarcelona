create database if not exists db_datenbank collate utf8_general_ci;
use db_datenbank;

create table users(
   id int not null auto_increment,
   firstname varchar(100) null,
   username varchar(100) not null unique,
   password varchar(128) not null,
   
   constraint id_PK primary key(id)
)engine=InnoDB;

Insert Into users Values(null, "Fabus", "Eggus", sha2("fabian", 512));

select * from users;