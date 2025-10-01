create database instrutor;
use instrutor;

CREATE TABLE professor (
    id_professor SERIAL PRIMARY KEY NOT NULL,
    nome_professor VARCHAR(100),
    logadouro VARCHAR(100),
    bairro VARCHAR(100),
    cidade VARCHAR(100),
    estado VARCHAR(10),
    tel_residencial VARCHAR(15),
    tel_celular VARCHAR(15),
    email VARCHAR(100)
);

drop table professor;

INSERT INTO professor values
(1, "Emanuela viera", "Rua Afonso Monteiro, 125", "Santa Maria", "Diadema", "SP", 45678912, 11963852741, "emanoela@mail.com"),
(2, "Viviane sheila", "Rua Rafael Moises, 111", "Santa Maria", "Diadema", "SP", 36251478, 11985742365, "viviane@mail.com"),
(3, "CLeiton de Andrade", "Rua Antonio Serafim, 22", "Cooperativa", "São Bernardo do Campo", "SP", 65832147 , 11985263254, "cleiton@mail.com"),
(4, "ALice Viera", "Rua Angela Marçon, 54", "Jd. Nazareth", "São Bernardo do Campo", "SP", 74589632, 11952236478, "alice@mail.com"),
(5, "Vania Lúcia", "Rua Jose Bonifacio, 2654", "Conceição", "Diadema", "SP", 25786369, 11999805475, "vania@mail.com");

SELECT * FROM professor;

create database Produto;
use Produto;

Create table Produtos(
cod_prod int,
Nome_prod varchar(40),
Tipo_prod varchar(20),
Qtd_prod int,
val_prod decimal(10,2)
);

 
Insert into Produtos values
(1,'Câmera Digital','Digitais',300,400.00),
(2,'DVD Player','Eletrônicos',250,500.00),
(3,'Monitor','Informática',400,900.00),
(4,'Televisor','Eletrônicos',350,650.00),
(5,'Filmadora Digital','Digitais',500,750.00),
(6,'Celular','Telefone',450,850.00),
(7,'Teclado','Informática',300,450.00),
(8,'Videogame','Eletrônicos',1500,3500.00),
(9,'Mouse','Informática',400,60.00),
(10,'impressora', "Informática",200,600.00);

-- AUMENTANDO O PREÇO DOS PRODUTOS IGUAIS OU MENORES QUE 300 REAIS.

-- MOSTRA TUDO DO TIPO DE INFORMATICA 
SELECT * FROM Produtos          
WHERE Tipo_prod='informática';

-- MUDA PERMANENTEMENTE
UPDATE Produtos                   
SET Qtd_prod = Qtd_prod + 50
where Qtd_prod <= 300;

SELECT * FROM Produtos 
WHERE Qtd_prod;

-- DELETANDO OS PRODUTOS DO TIPO TELEFONE: 

DELETE FROM Produtos
WHERE Tipo_prod = "Telefone";

SELECT * FROM Produtos;

-- AUMENTANDO O PREÇO DOS PRODUTOS IGUAIS OU MENORES QUE 700 REAIS USANDO AND E OR

UPDATE produtos
SET val_prod = val_prod * 1.1 
WHERE Tipo_prod = 'informática' 
AND val_prod <=700;

UPDATE produtos
SET val_prod = val_prod * 1.1 
WHERE Tipo_prod='Eletrônico' 
OR val_prod >= 700;

