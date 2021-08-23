USE SPMEDGROUP;
GO

INSERT INTO TIPOUSUARIO(tipoUsuario)
VALUES ('Administrador'), ('Médico'), ('Paciente');
GO

INSERT INTO ESPECIALIDADES(especialidade)
VALUES ('Acupuntura'), ('Anestesiologia'), ('Angiologia'), ('Cardiologia'), 
('Cirurgia Cardiovascular'), ('Cirurgia da Mão'), ('Cirurgia do Aparelho Digestivo'), 
('Cirurgia Geral'), ('Cirurgia Pediátrica'), ('Cirurgia Plástica'), ('Cirurgia Torácica'), 
('Cirurgia Vascular'), ('Dermatologia'), ('Radioterapia'), ('Urologia'), ('Pediatria'), ('Psiquiatria');
GO

INSERT INTO USUARIO(idTipoUsuario, email, senha, nome)
VALUES (3, 'ligia@gmail.com', 'ligia123', 'Ligia'), (3, 'alexandre@gmail.com', 'alexandre123', 'Alexandre'), 
(3, 'fernando@gmail.com', 'fernando123', 'Fernando'), (3, 'henrique@gmail.com', 'henrique123', 'Henrique'),
(3, 'joao@gmail.com', 'joao123', 'Joao'), (3, 'bruno@gmail.com', 'bruno123', 'Bruno'),
(3, 'mariana@gmail.com', 'mariana123', 'Mariana'), (2, 'ricardo.lemos@spmedicalgroup.com.br', 'ricardo123', 'Ricardo Lemos'),
(2, 'roberto.possarle@spmedicalgroup.com.br', 'roberto123', 'Roberto Possarle'), (2, 'helena.souza@spmedicalgroup.com.br', 'helena123', 'Helena Strada');
GO

INSERT INTO CLINICAS(nomeClinica, razaoSocial, CNPJ, endereco)
VALUES ('Clinica Possarle', 'SP Medical Group', '86400902000130', 'Av. Barão Limeira, 532, São Paulo, SP');
GO

INSERT INTO CONSULTAS(idPaciente, idMedico, dataConsulta, situacao)
VALUES (7, 10, '20/01/2020 15:00', 'Realizada'), (2, 9, '06/01/2020 10:00', 'Cancelada'), (3, 9, '07/02/2020 11:00', 'Realizada'),
(2, 9, '06/02/2018 10:00', 'Realizada'), (4, 8, '07/02/2019 11:00', 'Cancelada'), 
(7, 10, '08/03/2020 15:00', 'Agendada'), (4, 8 '09/03/2020 11:00', 'Agendada');
GO

