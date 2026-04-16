create database hospital;
use hospital;

create table paciente (
	Id INT AUTO_INCREMENT PRIMARY KEY,
    nome varchar(100) not null,
    idade int not null,
    cpf int not null UNIQUE,
    preferencial char(1) not null,
    constraint pref_pac check (preferencial in ('S','N'))
);