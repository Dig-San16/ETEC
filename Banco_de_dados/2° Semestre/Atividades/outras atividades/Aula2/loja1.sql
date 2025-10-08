create database loja1

use loja1

create table FORNECEDOR(
id_instrutor int primary key,
nome_instrutor varchar(100),
logradouro_instrutor varchar(255),
bairro_instrutor varchar(100),
cidade_instutor varchar(50),
estado_instrutor char(2),
tel_res varchar(12),
tel_cel varchar(12),
email_instrutor varchar(100)
);

insert into FORNECEDOR values
(1, "Emanoela Vieira", "Rua Afonso Monteiro, 125", "Santa Maria", "Diadema", "SP", "45678912", "11963852741", "emanoela@mail.com"),
(2, "Viviane Sheila", "Rua Rafael Moises, 111", "Santa Maria", "Diadema", "SP", "36251478", "11985742365", "viviane@mail.com"),
(3, "Cleiton de Andrade", "Rua Antonio Serafim, 22", "Cooperativa", "São Bernardo do Campo", "SP", "65832147", "11985263254", "cleiton@mail.com"),
(4, "Alice Vieira", "Rua Angelo Marçon, 54", "Jd Nazareth", "São Bernardo do Campo", "SP", "74589632", "11952236478", "alice@mail.com"),
(5, "Vania Lúcia", "Rua José Bonifácio, 2654", "Conceição", "Diadema", "SP", "25786369", "11999805475", "vania@mail.com");


 