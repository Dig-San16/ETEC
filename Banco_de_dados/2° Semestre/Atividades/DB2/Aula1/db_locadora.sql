create database locadora;

use locadora;

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
UF_estado varchar(2)
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
genero_func varchar(2),
salario_func decimal(10,3),
num_func int,
logradouro_func varchar(255),
id_bairro int,
constraint foreign key(id_bairro) references BAIRRO(id_bairro)
);

create table CLIENTE(
id_cli int primary key,
nome_cli varchar(255),
genero_cli varchar(2),
renda_cli decimal(10,3),
num_cli int,
logradouro_cli varchar(255),
estcivil_cli varchar(12),
id_bairro int,
constraint foreign key(id_bairro) references BAIRRO(id_bairro)
);

create table CONJUGE(
id_conj int primary key,
nome_conj varchar(255),
genero_conj varchar(2),
renda_conj decimal(10,3),
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
genero_depen varchar(2),
tipo_depen varchar(20),
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

INSERT INTO estado values
(1,"São Paulo","SP"),
(2,"Rio de Janeiro","RJ"),
(3,"Santa Catarina","SC"),
(4,"Mato Grosso","MT"),
(5,"Ceara","CE"),
(6,"Bahia","BA"),
(7,"Minas Gerais","MG"),
(8,"Parana","PR"),
(9,"Para","PA"),
(10,"Roraima","RR"),
(11,"Maranhao","MA"),
(12,"Amazonas","AM"),
(13,"Paraiba","PB"),
(14,"Sergipe","SE"),
(15,"Tocantins","TO"),
(16,"Rondonia","RO"),
(17,"Pernambuco","PE"),
(18,"Piaui","PI"),
(19,"Goias","GO"),
(20,"Amapa","AP");

INSERT INTO cidade VALUES
(21, "Sao Paulo", 1),
(22, "Rio de Janeiro", 2),
(23, "Florianopolis", 3),
(24,"Cuiaba", 4),
(25, "Fortaleza", 5),
(26,"Salvador", 6),
(27, "Belo Horizonte", 7),
(28, "Curitiba", 8),
(29,"Belem", 9),
(30, "Boa Vista", 10),
(31, "Sao Luis", 11),
(32, "Manaus", 12),
(33, "Joao Pessoa", 13),
(34, "Aracaju", 14),
(35, "Palmas", 15),
(36, "Porto Velho", 16),
(37, "Recife", 17),
(38, "Teresina", 18),
(39, "Goiania", 19),
(40, "Macapa", 20);

INSERT INTO bairro VALUES
(41,"Vila Mariana",21),
(42,"Copa Cabana",22),
(43,"Lagoa da Conceicao",23),
(44,"Goiabeiras",24),
(45,"Aldeota",25),
(46,"Barra",26),
(47,"Savassi",27),
(48,"Batel",28),
(49,"Batista Campos",29),
(50,"Centro",30),
(51,"Renascenca",31),
(52,"Adrianopolis",32),
(53,"Tambau",33),
(54,"Atalaia",34),
(55,"Plano Diretor Sul",35),
(56,"Embratel",36),
(57,"Boa Viagem",37),
(58,"Ininga",38),
(59,"Setor Bueno",39),
(60,"Trem",40);

INSERT INTO artista VALUES
(61,"Fernanda Torres"),
(62,"Fernanda Montenegro"),
(63,"Wagner Moura"),
(64,"Lazaro Ramos"),
(65,"Tais Araujo"),
(66,"Selton Mello"),
(67,"Alice Braga"),
(68,"Rodigo Santoro"),
(69,"Gloria Pires"),
(70,"Tony Ramos"),
(71,"Camila Pitanga"),
(72,"Lima Duarte"),
(73,"Matheus Solano"),
(74,"Debora Falabella"),
(75,"Bruno Gagliasso"),
(76,"Caua Reymond"),
(77,"Vladimir Bricht"),
(78,"Jose Wilker"),
(79,"Antonio Bandeiras"),
(80,"Andreia Horta");

INSERT INTO Gravadora VALUES
(81, "PlayArte"),
(82, "Sony Music"),
(83, "Universal Music"),
(84, "Warner Music"),
(85, "BMG"),
(86, "EMI"),
(87, "Som Livre"),
(88, "Deckdisc"),
(89, "Trama"),
(90, "Indie Records"),
(91, "Roadrunner Records"),
(92, "Nuclear Blast"),
(93, "Sub Pop"),
(94, "Domino Recording"),
(95, "Matador Records"),
(96, "XL Recordings"),
(97, "4AD"),
(98, "Roc Nation"),
(99, "Big Machine Records"),
(100, "Aftermath Entertainment");

INSERT INTO cliente VALUES
(101,"Kaua Berato", "M", "1.400", "51", "Rua Benedito Pereira Martins", "Solteiro",41),
(102, "Ana Clara Souza", "F", "2.300", "102", "Avenida Brasil", "Casada",42),
(103, "Lucas Martins", "M", "1.800", "45", "Rua das Flores", "Solteiro",43),
(104, "Mariana Lima", "F", "3.000", "78", "Rua João Pessoa", "Solteira",44),
(105, "Pedro Henrique", "M", "2.100", "88", "Rua dos Andradas", "Solteiro",45),
(106, "Julia Fernandes", "F", "2.500", "23", "Rua XV de Novembro", "Casada",46),
(107, "Carlos Eduardo", "M", "1.200", "12", "Rua José Bonifácio", "Solteiro",47),
(108, "Fernanda Rocha", "F", "2.900", "64", "Rua Antonio Prado", "Divorciada",48),
(109, "João Victor", "M", "3.300", "35", "Rua da Liberdade", "Casado",49),
(110, "Patrícia Melo", "F", "2.100", "97", "Rua Coronel Fabriciano", "Solteira",50),
(111, "Mateus Oliveira", "M", "1.600", "58", "Rua da Paz", "Solteiro",51),
(112, "Beatriz Gomes", "F", "3.100", "76", "Rua das Acacias", "Casada",52),
(113, "Rafael Torres", "M", "2.800", "18", "Rua Bela Vista", "Casado",53),
(114, "Larissa Costa", "F", "2.000", "84", "Rua Santo Antonio", "Solteira",54),
(115, "Bruno Silva", "M", "1.900", "30", "Rua São Joao", "Solteiro",55),
(116, "Gabriela Ribeiro", "F", "2.400", "66", "Rua Dom Pedro II", "Solteira",56),
(117, "Thiago Almeida", "M", "1.700", "39", "Rua Miguel Calmon", "Divorciado",57),
(118, "Isabela Nunes", "F", "3.200", "50", "Rua Alvares Cabral", "Casada",58),
(119, "Diego Santos", "M", "2.600", "29", "Rua Campos Sales", "Solteiro",59),
(120, "Camila Duarte", "F", "2.300", "11", "Rua Dom Bosco", "Solteira",60);

INSERT INTO funcionario VALUES
(121, "Vinicius Pereira", "M", "2.400", "56", "Rua dos Angicos", 41),
(122, "Larissa Monteiro", "F", "3.200", "34", "Rua das Laranjeiras", 42),
(123, "Carlos Henrique", "M", "2.800", "12", "Rua Bela Vista", 43),
(124, "Juliana Silva", "F", "2.500", "65", "Avenida Central", 44),
(125, "Pedro Lima", "M", "3.000", "98", "Rua Sao Paulo", 45),
(126, "Fernanda Oliveira", "F","2.600", "41", "Rua dos Cravos", 46),
(127, "Marcos Vinicius", "M", "2.100", "23", "Rua do Comercio", 47),
(128, "Amanda Costa", "F", "2.900", "77", "Rua Santa Luzia", 48),
(129, "Diego Souza", "M", "2.350",  "39", "Rua das Palmeiras", 49),
(130, "Tatiane Ramos", "F", "3.100", "82", "Rua das Hortensias", 50),
(131, "Bruno Rocha", "M", "2.200",  "11", "Rua do Sol", 51),
(132, "Camila Ferreira","F", "2.700", "44", "Rua da Alegria", 52),
(133, "Ricardo Mendes", "M", "2.900", "66", "Rua do Contorno", 53),
(134, "Isabela Martins","F", "2.800", "37", "Rua das Acacias", 54),
(135, "Luiz Felipe", "M", "3.000",  "19", "Avenida das Nacoes", 55),
(136, "Renata Dias", "F", "2.450", "29", "Rua Tiradentes", 56),
(137, "André Luiz", "M",  "2.600", "91", "Rua 7 de Setembro", 57),
(138, "Natália Ribeiro", "F", "3.200", "50", "Rua Alvorada", 58),
(139, "Gabriel Fonseca", "M", "2.300", "31", "Rua Brasil", 59),
(140, "Eduarda Nogueira", "F", "2.750", "72", "Rua Presidente Vargas", 60);

INSERT INTO dependente VALUES
(141, "Antonio Martins", "M", "Pai", 121),
(142, "Maria Oliveira", "F", "Mãe", 122),
(143, "João Martins", "M", "Filho", 123),
(144, "Ana Martins", "F", "Filha", 124),
(145, "Pedro Santos", "M", "Pai", 125),
(146, "Carla Santos", "F", "Mãe", 126),
(147, "Lucas Santos", "M", "Filho", 127),
(148, "Juliana Santos", "F", "Filha", 128),
(149, "Roberto Lima", "M", "Pai", 129),
(150, "Fernanda Lima", "F", "Mãe", 130),
(151, "Thiago Lima", "M", "Filho", 131),
(152, "Mariana Lima", "F", "Filha", 122),
(153, "Ricardo Alves", "M", "Pai", 133),
(154, "Patrícia Alves", "F", "Mãe", 134),
(155, "Gustavo Alves", "M", "Filho", 135),
(156, "Camila Alves", "F", "Filha", 136),
(157, "José Ferreira", "M", "Pai", 137),
(158, "Cláudia Ferreira", "F", "Mãe", 138),
(159, "André Ferreira", "M", "Filho", 139),
(160, "Beatriz Ferreira", "F", "Filha", 140);

INSERT INTO conjuge VALUES
(161,"Olivia Palito", "F", "1.500", 101),
(162,"Mario Silva", "M", "2.000", 102),
(163,"Carla Souza", "F", "1.800", 103),
(164,"João Mendes", "M", "2.200", 104),
(165,"Fernanda Costa", "F", "1.750", 105),
(166,"Ricardo Oliveira", "M", "3.000", 106),
(167,"Patrícia Lima", "F", "2.100", 107),
(168,"André Ferreira", "M", "2.500", 108),
(169,"Juliana Alves", "F", "1.900", 109),
(170,"Roberto Martins", "M", "2.300", 110),
(171,"Camila Rocha", "F", "1.700", 111),
(172,"Paulo Santos", "M", "2.800", 112),
(173,"Bianca Nunes", "F", "1.950", 113),
(174,"Fábio Cardoso", "M", "2.400", 114),
(175,"Larissa Pinto", "F", "1.600", 115),
(176,"Eduardo Barbosa", "M", "2.700", 116),
(177,"Sabrina Teixeira", "F", "2.050", 117),
(178,"Gustavo Ramos", "M", "3.100", 118),
(179,"Vanessa Moreira", "F", "1.850", 119),
(180,"Marcelo Dias", "M", "2.600", 120);

INSERT INTO categoria VALUES
(181, "Suspense"),
(182, "Romance"),
(183, "Ação"),
(184, "Comédia"),
(185, "Drama"),
(186, "Ficção Científica"),
(187, "Terror"),
(188, "Fantasia"),
(189, "Mistério"),
(190, "Aventura"),
(191, "Histórico"),
(192, "Biografia"),
(193, "Musical"),
(194, "Documentário"),
(195, "Guerra"),
(196, "Policial"),
(197, "Infantil"),
(198, "Animação"),
(199, "Western"),
(200, "Thriller");

INSERT INTO pedido VALUES
(201, "Compra de DVD", "2021-12-30", "50.30", 121, 101),
(202, "Aluguel de DVD", "2022-01-02", "30.00", 122, 102),
(203, "Compra de DVD", "2022-01-05", "55.50", 123, 103),
(204, "Aluguel de DVD", "2022-01-08", "28.75", 124, 104),
(205, "Compra de DVD", "2022-01-11", "60.00", 125, 105),
(206, "Aluguel de DVD", "2022-01-14", "32.50", 126, 106),
(207, "Compra de DVD", "2022-01-17", "52.90", 127, 107),
(208, "Aluguel de DVD", "2022-01-20", "29.90", 128, 108),
(209, "Compra de DVD", "2022-01-23", "58.20", 129, 109),
(210, "Aluguel de DVD", "2022-01-26", "31.00", 130, 110),
(211, "Compra de DVD", "2022-01-29", "54.50", 121, 111),
(212, "Aluguel de DVD", "2022-02-01", "30.80", 122, 112),
(213, "Compra de DVD", "2022-02-04", "59.90", 123, 113),
(214, "Aluguel de DVD", "2022-02-07", "33.20", 124, 114),
(215, "Compra de DVD", "2022-02-10", "56.00", 125, 115),
(216, "Aluguel de DVD", "2022-02-13", "31.50", 126, 116),
(217, "Compra de DVD", "2022-02-16", "53.75", 127, 117),
(218, "Aluguel de DVD", "2022-02-19", "29.50", 128, 118),
(219, "Compra de DVD", "2022-02-22", "57.80", 129, 119),
(220, "Aluguel de DVD", "2022-02-25", "32.00", 130, 120);

INSERT INTO dvd VALUES
(221, "Premonição 3", "15.50", "19", 181, 81, 201),
(222, "Diário de uma Paixão", "18.00", "22", 182, 82, 202),
(223, "Vingadores: Ultimato", "25.50", "30", 183, 83, 203),
(224, "Se Beber, Não Case", "14.75", "25", 184, 84, 204),
(225, "A Vida é Bela", "16.50", "18", 185, 85, 205),
(226, "Interestelar", "22.00", "20", 186, 86, 206),
(227, "Invocação do Mal", "17.80", "15", 187, 87, 207),
(228, "O Senhor dos Anéis", "24.50", "28", 188, 88, 208),
(229, "Sherlock Holmes", "19.90", "21", 189, 89, 209),
(230, "Indiana Jones", "20.50", "23", 190, 90, 210),
(231, "Gladiador", "21.75", "19", 191, 91, 211),
(232, "Bohemian Rhapsody", "18.20", "17", 192, 92, 212),
(233, "La La Land", "19.50", "16", 193, 93, 213),
(234, "Planeta Terra", "16.80", "20", 194, 94, 214),
(235, "Corações de Ferro", "22.30", "14", 195, 95, 215),
(236, "O Silêncio dos Inocentes", "20.90", "18", 196, 96, 216),
(237, "Toy Story", "17.50", "25", 197, 97, 217),
(238, "Meu Malvado Favorito", "16.75", "27", 198, 98, 218),
(239, "O Bom, o Mau e o Feio", "21.00", "15", 199, 99, 219),
(240, "Garota Exemplar", "18.90", "19", 200, 100, 220);

INSERT INTO dvd_has_artista VALUES
(241, 221, 61),
(242, 222, 62),
(243, 223, 63),
(244, 224, 64),
(245, 225, 65),
(246, 226, 66),
(247, 227, 67),
(248, 228, 68),
(249, 229, 69),
(250, 230, 70),
(251, 231, 71),
(252, 232, 72),
(253, 233, 73),
(254, 234, 74),
(255, 235, 75),
(256, 236, 76),
(257, 237, 77),
(258, 238, 78),
(259, 239, 79),
(260, 240, 80);