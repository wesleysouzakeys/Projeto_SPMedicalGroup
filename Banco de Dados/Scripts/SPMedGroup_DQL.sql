USE SPMEDGROUP;
GO


SELECT * FROM TIPOUSUARIO;
GO

SELECT * FROM CLINICAS;
GO

SELECT * FROM ESPECIALIDADES;
GO

SELECT * FROM USUARIO;
GO

SELECT * FROM PACIENTES;
GO

SELECT * FROM CONSULTAS;
GO

SELECT * FROM MEDICO;
GO

SELECT Paciente.nomePaciente AS [Nome do Paciente], Medico.nomeMedico AS [Nome do Médico], Situacao.descricao AS [Situação], dataConsulta AS [Data da Consulta], Consulta.descricao AS [Descrição da Consulta]
FROM Consulta
INNER JOIN Paciente ON Consulta.idPaciente = Paciente.idPaciente
INNER JOIN Medico ON  Consulta.idMedico = Medico.idMedico
INNER JOIN Situacao ON Consulta.idSituacao = Situacao.idSituacao;
GO

--Consultas de um paciente
SELECT Paciente.nomePaciente AS [Nome do Paciente], Situacao.descricao AS [Situação], dataConsulta AS [Data da Consulta]
FROM Consulta
INNER JOIN Paciente ON Consulta.idPaciente = Paciente.idPaciente
INNER JOIN Situacao ON Consulta.idSituacao = Situacao.idSituacao
WHERE Consulta.idPaciente = 7;
GO


--Consultas de um médico
SELECT Medico.nomeMedico AS [Nome do Médico] , Situacao.descricao AS [Situação], dataConsulta AS [Data da Consulta]
FROM Consulta
INNER JOIN Medico ON  Consulta.idMedico = Medico.idMedico
INNER JOIN Situacao ON Consulta.idSituacao = Situacao.idSituacao
WHERE Consulta.idMedico = 2;
GO

--Login
SELECT  TipoUsuario.tituloTipoUsuario, Usuario.email, Usuario.senha FROM Usuario
INNER JOIN TipoUsuario ON Usuario.idTipoUsuario = TipoUsuario.idTipoUsuario
WHERE email = 'ligia@gmail.com'
AND senha = '444';
GO


--Mostra a quantidade de usuários 
SELECT COUNT (idUsuario) AS [Quantidade de usuários]
FROM USUARIO;
GO


--Função que retorna idade do usuário
CREATE FUNCTION F_IdadeUsuario ()
RETURNS TABLE 
AS 
RETURN SELECT nomePaciente, DATEDIFF(year, DataNascimento, GETDATE()) Idade FROM Paciente;
GO

SELECT * FROM F_IdadeUsuario ();
GO




--Stored Procedure que retorna a quantidade de médicos de uma determinada especialidade
CREATE PROCEDURE P_MedicosEspecialidade (@idEspecialidade SMALLINT)
AS 
BEGIN
SELECT nomeMedico AS [Nome do Médico],tituloEspecialidade AS [Especialidade]
FROM Medico
INNER JOIN Especialidade
ON Medico.idEspecialidade = Especialidade.idEspecialidade
WHERE Especialidade.idEspecialidade = 2
END

EXEC P_MedicosEspecialidade @idEspecialidade = 2;
GO