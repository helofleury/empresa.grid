create database aula;
use aula;

create table cliente
(
CPF char(11),
Nome varchar(80),
dtNascimento date,
rua varchar(500),
numero char (5)
);

insert into cliente (CPF, Nome, dtNascimento, rua, numero) values ("11111111111", "heloisa", "2004-07-12", "tudobom", 23);

select * from cliente;

alter table cliente drop numero;
alter table cliente add numero int (5);

select * from cliente;

insert into cliente (CPF, Nome, dtNascimento, rua, numero) values ("11111111111", "heloisa", "2004-07-12", "tudobom", 23);
insert into cliente (CPF, Nome, dtNascimento, rua, numero) values('543 ','435453','2014-08-02','543',543543);

select * from cliente;


