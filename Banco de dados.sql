CREATE TABLE livros (
	id_livro INT NOT NULL,
	titulo VARCHAR(100) NOT NULL,
	autor VARCHAR(100) NOT NULL,
	editora VARCHAR(60) NOT NULL,
	ano_publicacao VARCHAR(4) NOT NULL,
	categoria VARCHAR(50) NOT NULL,
	PRIMARY KEY (id_livro)
);

CREATE TABLE perfil(
	id_perfil INT NOT NULL,
	descricao_perfil VARCHAR(45),
	PRIMARY KEY (id_perfil)
);

CREATE TABLE usuarios (
	id_usuario INT NOT NULL,
	nome VARCHAR(100) NOT NULL,
	matricula INT NOT NULL,
	usuario VARCHAR(120) NOT NULL,
	senha VARCHAR(100) NOT NULL,
	id_perfil INT,
	endereco VARCHAR(100) NOT NULL,
	PRIMARY KEY (id_usuario),
	FOREIGN KEY (id_perfil) REFERENCES perfil (id_perfil)
);

CREATE TABLE emprestimos (
	id_emprestimo INT NOT NULL,
	id_livro INT NOT NULL,
	id_usuario INT NOT NULL,
	data_emprestimo VARCHAR(12),
	data_devolucao VARCHAR(12),
	PRIMARY KEY (id_emprestimo),
	FOREIGN KEY (id_livro) REFERENCES livros(id_livro),
	FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario)
);
