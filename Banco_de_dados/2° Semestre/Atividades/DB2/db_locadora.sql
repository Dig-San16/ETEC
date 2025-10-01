create database LOCADORA;
use LOCADORA;

create table CATEGORIA(
id_categoria int primary key,
nome_categ varchar(100)
);

create table GRAVADORA(
id_gravadora int primary key,
nome_grav varchar(100)
);

create table ESTADO(
id_estado int primary key,
nome_estado varchar(100),
UF_estado varchar(6)
); 

create table CIDADE(
id_cidade int primary key,
nome_cidade varchar(100),
id_estado int,
constraint foreign key(id_estado) references ESTADO(id_estado)
);

create table BAIRRO(
id_bairro int primary key,
nome_bairro varchar(100),
id_cidade int,
constraint foreign key(id_cidade) references CIDADE(id_cidade)
);

create table FUNCIONARIO(
id_func int primary key,
nome_func varchar(255),
genero_func varchar(10),
salario_func decimal(10,2),
num_func decimal(10,2),
logradouro_func varchar(255),
id_bairro int,
constraint foreign key(id_bairro) references BAIRRO(id_bairro)
);

create table CLIENTE(
id_cli int primary key,
nome_cli varchar(255),
genero_cli varchar(10),
renda_cli decimal(10,2),
num_cli decimal(10,2),
logradouro_cli varchar(255),
estcivil_cli varchar(15),
id_bairro int,
constraint foreign key(id_bairro) references BAIRRO(id_bairro)
);

create table CONJUGE(
id_conj int primary key,
nome_conj varchar(255),
genero_conj varchar(10),
renda_conj decimal(10,2),
id_cli int,
constraint foreign key(id_cli) references CLIENTE(id_cli)
);

create table PEDIDO(
id_pedido int primary key,
descricao_ped varchar(255),
data_ped DATE,
valor_ped decimal(10,2),
id_func int,
id_cli int,
constraint foreign key(id_func) references FUNCIONARIO(id_func),
constraint foreign key(id_cli) references CLIENTE(id_cli)
);

create table DEPENDENTE(
id_depen int primary key,
nome_depen varchar(255),
genero_depen varchar(10),
tipo_depen decimal(10,2),
id_func int,
constraint foreign key(id_func) references FUNCIONARIO(id_func)
);

create table ARTISTA(
id_artista int primary key,
nome_artista varchar(255)
);

create table DVD(
id_dvd int primary key,
nome_dvd varchar(255),
valor_dvd decimal(10,2),
qtde_estoque int,
id_categoria int,
id_gravadora int,
id_pedido int,
constraint foreign key(id_categoria) references CATEGORIA(id_categoria),
constraint foreign key(id_gravadora) references GRAVADORA(id_gravadora),
constraint foreign key(id_pedido) references PEDIDO(id_pedido)
);

create table DVD_HAS_ARTISTA(
id_dvd_artista int primary key,
id_dvd int,
id_artista int,
constraint foreign key(id_dvd) references DVD(id_dvd),
constraint foreign key(id_artista) references ARTISTA(id_artista)
);

drop table CATEGORIA

select * from DVD_HAS_ARTISTA
