-- Script alimenta tb TipoAssunto
insert into TipoAssunto values ('Banco de Dados')
insert into TipoAssunto values ('BI')
insert into TipoAssunto values ('Arquitetura')
insert into TipoAssunto values ('Análise de Sistemas')
insert into TipoAssunto values ('Desenvolvimento de Sistemas')
insert into TipoAssunto values ('Testes')
insert into TipoAssunto values ('Infraestrutura')
insert into TipoAssunto values ('Redes')

-- Script alimenta tb Assunto
insert into Assunto values (1, 'MongoDB')
insert into Assunto values (1, 'PostgreSQL')
insert into Assunto values (2, 'PowerBI')
insert into Assunto values (2, 'Tableau')
insert into Assunto values (3, 'MVC')
insert into Assunto values (3, 'SOA')
insert into Assunto values (4, 'Levantamento de Requisitos')
insert into Assunto values (4, 'Fluxogramas')
insert into Assunto values (5, 'JavaScript')
insert into Assunto values (5, '.Net Core')
insert into Assunto values (6, 'Testes Unitários')
insert into Assunto values (6, 'Automação de Testes')
insert into Assunto values (7, 'Cloud')
insert into Assunto values (7, 'Windows Server')
insert into Assunto values (7, 'Linux')
insert into Assunto values (8, 'Firewall')
insert into Assunto values (8, 'VPN')


-- Script alimenta tb Usuarios
insert into Usuarios values ('Administrador', '052.100.127-78', '07/18/1980', 'admin', 'desktoprlz')

-- Script alimenta tb Criterios
insert into Criterios values ('Nenhum', 0)
insert into Criterios values ('Muito Pouco', 1)
insert into Criterios values ('Razoável', 2)
insert into Criterios values ('Bom', 3)
insert into Criterios values ('Ótimo', 4)