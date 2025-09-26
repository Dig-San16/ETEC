CREATE TABLE Alunos (
    id_aluno SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    data_nascimento DATE NOT NULL,
    cpf VARCHAR(14) UNIQUE,
    endereco VARCHAR(200),
    telefone VARCHAR(15),
    email VARCHAR(100)
);

-- Tabela de Cursos
CREATE TABLE Cursos (
    id_curso SERIAL PRIMARY KEY,
    nome_curso VARCHAR(100) NOT NULL,
    descricao TEXT,
    carga_horaria INT
);

-- Tabela de Professores
CREATE TABLE Professores (
    id_professor SERIAL PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    especialidade VARCHAR(100),
    telefone VARCHAR(15),
    email VARCHAR(100)
);

-- Tabela de Turmas
CREATE TABLE Turmas (
    id_turma SERIAL PRIMARY KEY,
    id_curso INT NOT NULL,
    id_professor INT NOT NULL,
    ano INT NOT NULL,
    semestre INT NOT NULL,
    FOREIGN KEY (id_curso) REFERENCES Cursos(id_curso),
    FOREIGN KEY (id_professor) REFERENCES Professores(id_professor)
);

-- Relação Aluno ↔ Turma (matrícula do aluno)
CREATE TABLE Matriculas (
    id_matricula SERIAL PRIMARY KEY,
    id_aluno INT NOT NULL,
    id_turma INT NOT NULL,
    data_matricula DATE DEFAULT CURRENT_DATE,
    FOREIGN KEY (id_aluno) REFERENCES Alunos(id_aluno),
    FOREIGN KEY (id_turma) REFERENCES Turmas(id_turma),
    UNIQUE (id_aluno, id_turma) -- Evita matrícula duplicada
);

INSERT INTO Alunos (nome, data_nascimento, cpf, endereco, telefone, email)
VALUES 
('Maria Silva', '2005-03-15', '123.456.789-00', 'Rua das Flores, 123', '(11)99999-1111', 'maria.silva@email.com'),
('João Santos', '2004-07-22', '987.654.321-00', 'Av. Brasil, 456', '(11)98888-2222', 'joao.santos@email.com'),
('Ana Costa', '2006-11-05', '111.222.333-44', 'Rua Verde, 789', '(11)97777-3333', 'ana.costa@email.com');

-- Inserindo Cursos
INSERT INTO Cursos (nome_curso, descricao, carga_horaria)
VALUES
('Informática Básica', 'Curso introdutório de informática.', 160),
('Matemática Aplicada', 'Curso para reforço e aprofundamento em matemática.', 200),
('Inglês Intermediário', 'Curso de inglês nível intermediário.', 180);

-- Inserindo Professores
INSERT INTO Professores (nome, especialidade, telefone, email)
VALUES
('Carlos Oliveira', 'Informática', '(11)95555-4444', 'carlos.oliveira@email.com'),
('Fernanda Lima', 'Matemática', '(11)96666-5555', 'fernanda.lima@email.com'),
('Roberto Souza', 'Inglês', '(11)97777-6666', 'roberto.souza@email.com');

-- Inserindo Turmas
INSERT INTO Turmas (id_curso, id_professor, ano, semestre)
VALUES
(1, 1, 2025, 1), -- Turma de Informática Básica com Carlos
(2, 2, 2025, 1), -- Turma de Matemática Aplicada com Fernanda
(3, 3, 2025, 1); -- Turma de Inglês com Roberto

-- Inserindo Matrículas
INSERT INTO Matriculas (id_aluno, id_turma)
VALUES
(1, 1), -- Maria matriculada em Informática
(2, 2), -- João matriculado em Matemática
(3, 3), -- Ana matriculada em Inglês
(1, 3);