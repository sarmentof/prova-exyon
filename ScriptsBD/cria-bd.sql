-- Scripts criação de tabelas
use [MATRIZDB]
CREATE TABLE  Criterios (
                idCriterio INT IDENTITY NOT NULL,
                nomeCriterio NVARCHAR(255) NOT NULL,
                valorCriterio INT NOT NULL,
                CONSTRAINT idCriterio PRIMARY KEY (idCriterio)
)

CREATE TABLE  TiposAssunto (
                idTipoAssunto INT IDENTITY NOT NULL,
                nomeTipoAssunto NVARCHAR(255) NOT NULL,
                CONSTRAINT idTipoAssunto PRIMARY KEY (idTipoAssunto)
)

CREATE TABLE  Assuntos (
                idAssunto INT IDENTITY NOT NULL,
                idTipoAssunto INT NOT NULL,
                nomeAssunto NVARCHAR(255) NOT NULL,
                CONSTRAINT idAssunto PRIMARY KEY (idAssunto, idTipoAssunto)
)

CREATE TABLE  Usuarios (
                idUsuario INT IDENTITY NOT NULL,
                nome NVARCHAR(255) NOT NULL,
                cpf NVARCHAR(14) NOT NULL,
                dtNascimento DATETIME NOT NULL,
                login NVARCHAR(255) NOT NULL,
                senha NVARCHAR(255) NOT NULL,
                CONSTRAINT idUsuario PRIMARY KEY (idUsuario)
)

CREATE TABLE  NotasUsuariosAssunto (
                idNotaUsuarioAssunto INT IDENTITY NOT NULL,
                idAssunto INT NOT NULL,
                idTipoAssunto INT NOT NULL,
                idUsuario INT NOT NULL,
                idCriterio INT NOT NULL,
                CONSTRAINT idNotaUsuarioAssunto PRIMARY KEY (idNotaUsuarioAssunto, idAssunto, idTipoAssunto, idUsuario, idCriterio)
)

ALTER TABLE  NotasUsuariosAssunto ADD CONSTRAINT Criterios_NotasUsuarioAssunto_fk
FOREIGN KEY (idCriterio)
REFERENCES  Criterios (idCriterio)
ON DELETE CASCADE
ON UPDATE CASCADE

ALTER TABLE  Assuntos ADD CONSTRAINT TipoAssunto_Assunto_fk
FOREIGN KEY (idTipoAssunto)
REFERENCES  TiposAssunto (idTipoAssunto)
ON DELETE CASCADE
ON UPDATE CASCADE

ALTER TABLE  NotasUsuariosAssunto ADD CONSTRAINT Assunto_NotasUsuarioAssunto_fk
FOREIGN KEY (idAssunto, idTipoAssunto)
REFERENCES  Assuntos (idAssunto, idTipoAssunto)
ON DELETE CASCADE
ON UPDATE CASCADE

ALTER TABLE  NotasUsuariosAssunto ADD CONSTRAINT Usuarios_NotasUsuarioAssunto_fk
FOREIGN KEY (idUsuario)
REFERENCES  Usuarios (idUsuario)
ON DELETE CASCADE
ON UPDATE CASCADE