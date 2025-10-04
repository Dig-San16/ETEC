CREATE TABLE funcionario (
    id_funcionario INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100),
    salario DECIMAL(10,2),
    sexo CHAR(1)
);

CREATE TABLE dependente (
    id_dependente INT AUTO_INCREMENT PRIMARY KEY,
    id_funcionario INT NOT NULL,
    nome VARCHAR(100),
    tipo VARCHAR(35),
    sexo CHAR(1),
    CONSTRAINT Ref_dependente_funcionario FOREIGN KEY (id_funcionario) REFERENCES funcionario(id_funcionario)
);

CREATE TABLE estado (
    id_estado INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100)
);

CREATE TABLE cidade (
    id_cidade INT AUTO_INCREMENT PRIMARY KEY,
    id_estado INT NOT NULL,
    nome VARCHAR(100),
    CONSTRAINT Ref_estado FOREIGN KEY (id_estado) REFERENCES estado(id_estado)
);

CREATE TABLE bairro (
    id_bairro INT AUTO_INCREMENT PRIMARY KEY,
    id_cidade INT NOT NULL,
    nome VARCHAR(100),
    CONSTRAINT Ref_cidade FOREIGN KEY (id_cidade) REFERENCES cidade(id_cidade)
);

CREATE TABLE cliente (
    id_cliente INT AUTO_INCREMENT PRIMARY KEY,
    id_estado INT NOT NULL,
    id_cidade INT NOT NULL,
    id_bairro INT NOT NULL,
    estado_civil VARCHAR(20),
    renda DECIMAL(10,2),
    sexo CHAR(1),
    CONSTRAINT Ref_estado_cliente FOREIGN KEY (id_estado) REFERENCES estado(id_estado),
    CONSTRAINT Ref_cidade_cliente FOREIGN KEY (id_cidade) REFERENCES cidade(id_cidade),
    CONSTRAINT Ref_bairro_cliente FOREIGN KEY (id_bairro) REFERENCES bairro(id_bairro)
);

CREATE TABLE conjuge (
    id_conjuge INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    nome VARCHAR(100),
    renda DECIMAL(10,2),
    sexo CHAR(1),
    CONSTRAINT Ref_conjuge_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
);

CREATE TABLE pedido (
    id_pedido INT AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    id_funcionario INT NOT NULL,
    valor_pedido DECIMAL(10,2),
    CONSTRAINT Ref_pedido_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente),
    CONSTRAINT Ref_pedido_funcionario FOREIGN KEY (id_funcionario) REFERENCES funcionario(id_funcionario)
);

-- Parte do DVD

CREATE TABLE gravadora (
    id_gravadora INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100)
);

CREATE TABLE categoria (
    id_categoria INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100)
);

CREATE TABLE artista (
    id_artista INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100)
);

CREATE TABLE dvd (
    id_dvd INT AUTO_INCREMENT PRIMARY KEY,
    id_gravadora INT NOT NULL,
    id_categoria INT NOT NULL,
    id_artista INT NOT NULL,
    nome VARCHAR(100),
    valor DECIMAL(10,2),
    qtd INT,
    CONSTRAINT Ref_gravadora_dvd FOREIGN KEY (id_gravadora) REFERENCES gravadora(id_gravadora),
    CONSTRAINT Ref_categoria_dvd FOREIGN KEY (id_categoria) REFERENCES categoria(id_categoria),
    CONSTRAINT Ref_artista_dvd FOREIGN KEY (id_artista) REFERENCES artista(id_artista)
);

-- INSERTS

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
