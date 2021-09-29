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

--Insert para o Administrador
INSERT INTO USUARIO(idTipoUsuario, email, senha, nome)
VALUES (1, 'adm@adm.com', 'adm123', 'Administrador');
GO

INSERT INTO CLINICAS(nomeClinica, razaoSocial, CNPJ, endereco)
VALUES ('Clinica Possarle', 'SP Medical Group', '86400902000130', 'Av. Barão Limeira, 532, São Paulo, SP');
GO

INSERT INTO CONSULTAS(idPaciente, idMedico, dataConsulta, situacao)
VALUES (7, 3, '20/01/2020 15:00', 'Realizada'), (2, 2, '06/01/2020 10:00', 'Cancelada'), (3, 2, '07/02/2020 11:00', 'Realizada'),
(2, 2, '06/02/2018 10:00', 'Realizada'), (4, 1, '07/02/2019 11:00', 'Cancelada'), 
(7, 3, '08/03/2020 15:00', 'Agendada'), (4, 1, '09/03/2020 11:00', 'Agendada');
GO

INSERT INTO MEDICO(idUsuario, idEspecialidade, idClinica, crm)
VALUES (8, 2, 1, '54356-SP'), (9, 17, 1, '53452-SP'), (10, 16, 1, '65463-SP');
GO

INSERT INTO PACIENTES (idUsuario, dataNascimento, telefone, RG, CPF, endereco)
VALUES (1, '13/10/1983', '11 3456-7654', '43522543-5', '94839859000', 'Rua Estado de Israel 240, São Paulo, Estado de São Paulo, 04022-000'),
	   (2, '23/07/2001', '11 8765-6543', '32654345-7', '73556944057', 'Av. Paulista, 1578 - Bela Vista, São Paulo - SP, 01310-200'),
	   (3, '10/10/1978', '11 7208-4453', '54636525-3', '16839338002', 'Av. Ibirapuera - Indianópolis, 2927,  São Paulo - SP, 04029-200'),
	   (4, '13/10/1985', '11 3456-6543', '54366362-5', '14332654765', 'R. Vitória, 120 - Vila Sao Jorge, Barueri - SP, 06402-030'),
	   (5, '27/08/1975', '11 7656-6377', '32544444-1', '91305348010', 'R. Ver. Geraldo de Camargo, 66 - Santa Luzia, Ribeirão Pires - SP, 09405-380'),
	   (6, '21/03/1972', '11 5436-8769', '54566266-7', '79799299004', 'Alameda dos Arapanés, 945 - Indianópolis, São Paulo - SP, 04524-001'),
	   (7, '05/03/2018', null, '54566266-8', '13771913039', 'R Sao Antonio, 232 - Vila Universal, Barueri - SP, 06407-140');
GO
