CREATE DATABASE SPMEDGROUP;
GO

USE SPMEDGROUP;
GO

CREATE TABLE TIPOUSUARIO(
	idTipoUsuario TINYINT PRIMARY KEY IDENTITY, 
	tipoUsuario VARCHAR(20) UNIQUE NOT NULL
);
GO

CREATE TABLE USUARIO(
	idUsuario SMALLINT PRIMARY KEY IDENTITY,
	idTipoUsuario TINYINT FOREIGN KEY REFERENCES TIPOUSUARIO(idtipoUsuario),
	nome VARCHAR(50) NOT NULL,
	email VARCHAR(50) NOT NULL,
	senha VARCHAR(50) NOT NULL
);
GO

CREATE TABLE PACIENTES(
	idPaciente SMALLINT PRIMARY KEY IDENTITY,
	idUsuario SMALLINT FOREIGN KEY REFERENCES USUARIO(idUsuario),
	dataNascimento DATE NOT NULL,
	telefone CHAR(12) NOT NULL, 
	RG CHAR(10) NOT NULL UNIQUE,
	CPF CHAR(11) NOT NULL UNIQUE,
	endereco VARCHAR(150) NOT NULL
);
GO

CREATE TABLE CLINICAS(
	idClinica SMALLINT PRIMARY KEY IDENTITY,
	nomeClinica VARCHAR(50) NOT NULL,
	CNPJ CHAR(18) NOT NULL UNIQUE,
	razaoSocial VARCHAR(100) NOT NULL,
	endereco VARCHAR(150) NOT NULL
);
GO

CREATE TABLE ESPECIALIDADES(
	idEspecialidade TINYINT PRIMARY KEY IDENTITY,
	especialidade VARCHAR(30)
);
GO

CREATE TABLE MEDICO(
	idMedico SMALLINT PRIMARY KEY IDENTITY,
	idUsuario SMALLINT FOREIGN KEY REFERENCES USUARIO(idUsuario),
	idEspecialidade TINYINT FOREIGN KEY REFERENCES ESPECIALIDADES(idEspecialidade),
	idClinica SMALLINT FOREIGN KEY REFERENCES CLINICAS(idClinica),
	CRM VARCHAR(8) UNIQUE NOT NULL
);
GO

CREATE TABLE CONSULTAS(
	idConsulta SMALLINT PRIMARY KEY IDENTITY,
	idPaciente SMALLINT FOREIGN KEY REFERENCES PACIENTES(idPaciente),
	idMedico SMALLINT FOREIGN KEY REFERENCES MEDICO(idMedico),
	dataConsulta DATETIME NOT NULL,
	situacao VARCHAR(20) NOT NULL,
);
GO