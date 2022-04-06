--PASSO 1:

CREATE TABLE Departamento
(
   Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
   CodigoDepartamento varchar (255) NOT NULL,
   NomeResponsavel varchar(255) NOT NULL,
   LoginResponsavel varchar(255) NULL,
   EmailResponsavel varchar(255) NULL
);

GO;

--PASSO 2:

CREATE OR ALTER PROCEDURE InsertOrUpdateDepartamento 
	@CodDepartamento nvarchar(255),
	@NomeResponsavel varchar(255),
	@LoginResponsavel varchar(255),
  @EmailResponsavel varchar(255) 
AS
	IF EXISTS (SELECT Id FROM Departamento WHERE CodigoDepartamento = @CodDepartamento)		
		BEGIN
			UPDATE Departamento
			SET 
				NomeResponsavel = @NomeResponsavel,
				LoginResponsavel = @LoginResponsavel,
				EmailResponsavel = @EmailResponsavel
			WHERE
				CodigoDepartamento = @CodDepartamento;	
		END
	ELSE 		
		BEGIN
			INSERT INTO Departamento(CodigoDepartamento, NomeResponsavel, LoginResponsavel, EmailResponsavel)
			VALUES (@CodDepartamento, @NomeResponsavel, @LoginResponsavel, @EmailResponsavel);
		END
	

	SELECT * FROM Departamento WHERE @CodDepartamento = @CodDepartamento

--PASSO 3:

EXEC InsertOrUpdateDepartamento 
	@CodDepartamento = '1', 
	@NomeResponsavel = 'REPONSAVEL 1',
	@LoginResponsavel = 'RESP1',
	@EmailResponsavel = 'RESP1@GMAIL.COM';

	
EXEC InsertOrUpdateDepartamento 
	@CodDepartamento = '2', 
	@NomeResponsavel = 'REPONSAVEL 2',
	@LoginResponsavel = 'RESP2',
	@EmailResponsavel = 'RESP2@GMAIL.COM';

EXEC InsertOrUpdateDepartamento 
	@CodDepartamento = '1', 
	@NomeResponsavel = 'REPONSAVEL 1',
	@LoginResponsavel = 'RESP1',
	@EmailResponsavel = 'RESP1@GMAIL.COM';
