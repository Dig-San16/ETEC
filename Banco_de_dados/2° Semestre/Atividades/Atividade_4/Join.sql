create table cargo (
cod_cargo int not null primary key,
nome_cargo varchar(30) unique
);

create table funcionario (
cod_func int not null primary key,
cod_cargo int not null,
nome_func varchar(30),
salario_func decimal(4,2),
RG_func int,
constraint cod_cargo_pk foreign key (cod_cargo) references cargo(cod_cargo)
);

create table dependente (
cod_dep int not null primary key,
cod_func int not null,
nome_dep varchar(45)
);

insert into cargo values 
(1, "Presidente"),
(2, "Gerente"),
(3, "Supervisor"),
(4, "Revisor"),
(5, "Redator");

insert into funcionario values
(1,5,"Luiz Peireira",3000.00, 27291905),
(2,5,"Antonio Almeida", 3000.00, 15970247),
(3,3, "Donizete Ribeiro", 2800.00, 27151908),
(4,3, "Gabriela Moura", 4700.00, 255279145),
(5,2, "Emilio Duarte", 5000.00, 17278246),
(6,1,"Carolina Ferreira", 9000.00, 18154578);

insert into dependente values 
(1,1, "Mariana Leme"),
(2,1, "Camila Leme"),
(3,1, "Josival Leme"),
(4,2, "Clavis ALmeida"),
(5,2, "Duval Almeida"),
(6,5, "Fabiana Duarte"),
(7,5, "Joana Duarte");

/*Código com inner join*/
select cargo.nome_cargo, funcionario.nome_func
from cargo inner join funcionario
on cargo.cod_cargo=funcionario.cod_cargo;

/*Código com left join*/
select cargo.nome_cargo, funcionario.nome_func
from cargo left join funcionario
on cargo.cod_cargo=funcionario.cod_cargo;

/*Código com right join*/
select cargo.nome_cargo, funcionario.nome_func
from cargo right join funcionario
on cargo.cod_cargo=funcionario.cod_cargo;

/*Código com where*/
select cargo.nome_cargo, funcionario.nome_func
from cargo, funcionario
where cargo.cod_cargo=funcionario.cod_cargo;

/*Códigos com 2 joins*/
select funcionario.nome_func, cargo.nome_cargo
from cargo 
inner join funcionario
on cargo.cod_cargo=funcionario.cod_cargo
inner join dependente
on funcionario.cod_func=dependente.cod_func;

select funcionario.nome_func, cargo.nome_cargo, dependente.nome_dep
from cargo 
inner join funcionario
on cargo.cod_cargo = funcionario.cod_cargo
left join dependente
on funcionario.cod_func = dependente.cod_func;