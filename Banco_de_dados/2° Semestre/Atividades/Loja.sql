create table funcionario (
id_funcionario SERIAL primary key,
nome varchar(100),
salario numeric(10,2),
sexo char(1)
);

create table dependente (
id_dependente SERIAL primary key,
id_funcionario int not null,
nome varchar(100),
tipo varchar(35),
sexo char(1),
constraint Ref_dependente_funcionario foreign key (id_funcionario) references funcionario(id_funcionario)
);

create table estado (
id_estado serial primary key not null,
nome varchar(100)
);

create table cidade (
id_cidade serial primary key ,
id_estado int not null,
nome varchar(100),
constraint Ref_estado foreign key (id_estado) references estado(id_estado)
);

create table bairro (
id_bairro serial primary key ,
id_cidade int not null,
nome varchar(100),
constraint Ref_cidade foreign key (id_cidade) references cidade(id_cidade)
);


create table cliente (
id_cliente serial primary key not null,
id_estado int not null,
id_cidade int not null,
id_bairro int not null,
estado_civil varchar(20),
renda numeric(10,2),
sexo char(1),
constraint Ref_estado_cliente foreign key (id_estado) references estado(id_estado),
constraint Ref_cidade_cliente foreign key (id_cidade) references cidade(id_cidade),
constraint Ref_bairro_cliente foreign key (id_bairro) references bairro(id_bairro)
);

create table conjuge (
id_conjuge serial primary key not null,
id_cliente int not null,
nome varchar(100),
renda numeric(10,2),
sexo char(1),
constraint Ref_conjuge_cliente foreign key (id_cliente) references cliente(id_cliente)
);



create table pedido (
id_pedido serial primary key not null,
id_cliente int not null,
id_funcionario int not null,
valor_pedido numeric(10,2),
constraint Ref_pedido_cliente foreign key (id_cliente) references cliente(id_cliente),
constraint Ref_pedido_funcionario foreign key (id_funcionario) references funcionario(id_funcionario)
);

--Parte do DVD

create table gravadora (
id_gravadora serial primary key not null,
nome varchar(100)
);

create table categoria (
id_categoria serial primary key not null,
nome varchar(100)
);

create table artista (
id_artista serial primary key not null,
nome varchar(100)
);

create table dvd (
id_dvd serial primary key not null,
id_gravadora int not null,
id_categoria int not null,
id_artista int not null,
nome varchar(100),
valor int,
qtd int,
constraint Ref_gravadora_dvd foreign key (id_gravadora) references gravadora(id_gravadora),
constraint Ref_categoria_dvd foreign key (id_categoria) references categoria(id_categoria),
constraint Ref_artista_dvd foreign key (id_artista) references artista(id_artista)
);

INSERT INTO funcionario (nome, salario, sexo) VALUES
('Ana Souza', 4500.00, 'F'),
('Carlos Lima', 5200.00, 'M'),
('Beatriz Martins', 4800.00, 'F');

INSERT INTO dependente (id_funcionario, nome, tipo, sexo) VALUES
(1, 'João Souza', 'Filho', 'M'),
(1, 'Maria Souza', 'Filha', 'F'),
(2, 'Lucas Lima', 'Filho', 'M');

INSERT INTO estado (nome) VALUES
('São Paulo'),
('Rio de Janeiro');

INSERT INTO cidade (id_estado, nome) VALUES
(1, 'São Paulo'),
(1, 'Campinas'),
(2, 'Rio de Janeiro'),
(2, 'Niterói');

INSERT INTO bairro (id_cidade, nome) VALUES
(1, 'Jardins'),
(1, 'Morumbi'),
(2, 'Cambuí'),
(3, 'Copacabana'),
(4, 'Icaraí');

INSERT INTO cliente (id_estado, id_cidade, id_bairro, estado_civil, renda, sexo) VALUES
(1, 1, 1, 'Solteiro', 3500.00, 'M'),
(1, 2, 3, 'Casado', 5000.00, 'F'),
(2, 3, 4, 'Solteiro', 4000.00, 'M'),
(2, 4, 5, 'Casado', 5500.00, 'F');

INSERT INTO conjuge (id_cliente, nome, renda, sexo) VALUES
(2, 'Carlos Pereira', 5200.00, 'M'),
(4, 'Fernanda Souza', 4800.00, 'F');

INSERT INTO pedido (id_cliente, id_funcionario, valor_pedido) VALUES
(1, 1, 1500.00),
(2, 2, 2200.00),
(3, 3, 1800.00),
(4, 1, 2500.00);

INSERT INTO gravadora (nome) VALUES
('Sony Music'),
('Universal Music'),
('Warner Music');


INSERT INTO categoria (nome) VALUES
('Pop'),
('Rock'),
('Sertanejo');

INSERT INTO artista (nome) VALUES
('Anitta'),
('Legião Urbana'),
('Jorge & Mateus');

INSERT INTO dvd (id_gravadora, id_categoria, id_artista, nome, valor, qtd) VALUES
(1, 1, 1, 'Show Anitta 2023', 50, 100),
(2, 2, 2, 'Legião Urbana Ao Vivo', 60, 80),
(3, 3, 3, 'Jorge & Mateus: Ao Vivo', 40, 120);