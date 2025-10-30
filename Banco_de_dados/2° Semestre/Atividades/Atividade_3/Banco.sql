create database DB_CDs;
use DB_CDs;

create table artista (
cod_art int not null primary key,
nome_art varchar(100) not null unique
);

create table gravadora (
cod_grav int not null primary key,
nome_grav varchar(50) not null unique
);

create table categoria (
cod_cat int not null primary key,
nome_cat varchar(100) not null unique
);

create table estado (
sigla_est char(2) not null primary key,
nome_est varchar(100) not null unique
);

create table cidade (
cod_cid int not null primary key,
sigla_est char(2) not null,
nome_cid varchar(100) not null,
constraint cidade_estado foreign key (sigla_est) references estado (sigla_est)
);

create table cliente (
cod_cli int not null primary key,
cod_cid int not null,
nome_cli varchar(100) not null,
endereco_cli varchar(200) not null,
renda_cli decimal(10,2) not null,
sexo_cli char(1) not null,
constraint cliente_cid foreign key (cod_cid) references cidade (cod_cid),
constraint renda_cliente check (renda_cli >= 0),
constraint sexo_cliente check (sexo_cli in ('F','M'))
);

create table conjuge (
cod_cli int not null primary key,
nome_conj varchar(100) not null,
renda_conj decimal(10,2) not null,
sexo_conj char(1) not null,
constraint cliente_conj foreign key (cod_cli) references cliente (cod_cli),
constraint renda_conjuge check (renda_conj >= 0),
constraint sexo_conjuge check (sexo_conj in ('F','M'))
);

create table funcionario (
cod_func int not null primary key,
nome_func varchar(100) not null,
end_func varchar(200),
sal_func decimal(10,2) not null,
sexo_func char(1) not null,
constraint salario_funcionario check (sal_func >= 0),
constraint sexo_funcionario check (sexo_func in ('F','M'))
);

create table dependente (
cod_dep int not null primary key,
cod_func int not null,
nome_dep varchar(100) not null,
sexo_dep char(1) not null,
constraint funcionario_dependente foreign key (cod_func) references funcionario (cod_func),
constraint sexo_dependente check (sexo_dep in ('F','M'))
);

create table titulo (
cod_tit int not null primary key,
cod_cat int not null,
cod_grav int not null,
nome_cd varchar(100) not null unique,
val_cd decimal(10,2) not null,
qtd_estq int not null,
constraint categoria_titulo foreign key (cod_cat) references categoria (cod_cat),
constraint gravadora_titulo foreign key (cod_grav) references gravadora (cod_grav),
constraint valor_dvd check (val_cd > 0),
constraint quantidad_dvd check (qtd_estq >= 0)
);

create table pedido (
cod_ped int not null primary key,
cod_func int not null,
cod_cli int not null,
qtd_cd int not null,
data_ped datetime not null,
val_cd decimal(10,2) not null,
constraint cliente_pedido foreign key (cod_cli) references cliente (cod_cli),
constraint funcionario_pedido foreign key (cod_func) references funcionario (cod_func),
constraint valor_pedido check (val_cd > 0)
);

create table titulo_pedido (
num_ped int not null,
cod_tit int not null,
qtd_cd int not null,
val_cd decimal(10,2) not null,
constraint numero_pedido foreign key (num_ped) references pedido (cod_ped),
constraint codigo_pedido foreign key (cod_tit) references titulo (cod_tit),
constraint quantidade_cd check (qtd_cd >= 1),
constraint valor_cd check (val_cd > 0)
);

create table titulo_artista (
cod_tit int not null,
cod_art int not null,
constraint codigo_titulo foreign key (cod_tit) references titulo (cod_tit),
constraint codigo_artista foreign key (cod_art) references artista (cod_art)
);