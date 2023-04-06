IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'confitec_banco')
  BEGIN
    CREATE DATABASE confitec_banco
  END
  GO

IF NOT EXISTS(SELECT * FROM sys.sysusers WHERE name = 'confitecUser')
  BEGIN
	CREATE LOGIN confitecUser WITH PASSWORD = 'confitecUser';
	USE confitec_banco
	CREATE USER confitecUser FOR LOGIN confitecUser WITH DEFAULT_SCHEMA=[dbo]
	ALTER ROLE db_datareader ADD MEMBER confitecUser
	ALTER ROLE db_datawriter ADD MEMBER confitecUser
  END
  GO

IF NOT EXISTS(SELECT * FROM sys.tables WHERE name = 'Usuario')
  BEGIN
    USE confitec_banco
    CREATE TABLE Usuario(
        id BIGINT NOT NULL IDENTITY(1,1),
        primeiroNome VARCHAR(20),
		ultimoNome VARCHAR(20),
		email VARCHAR(20),
		dataNacimento DateTime,
		escolaridade int,
		PRIMARY KEY (id)
    )
  END
  GO
