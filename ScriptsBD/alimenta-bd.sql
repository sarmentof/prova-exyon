-- Script alimenta tb TipoAssunto
insert into TiposAssunto values ('Banco de Dados')
insert into TiposAssunto values ('BI')
insert into TiposAssunto values ('Arquitetura')
insert into TiposAssunto values ('Análise de Sistemas')
insert into TiposAssunto values ('Desenvolvimento de Sistemas')
insert into TiposAssunto values ('Testes')
insert into TiposAssunto values ('Infraestrutura')
insert into TiposAssunto values ('Redes')

-- Script alimenta tb Assuntos
insert into Assuntos values (1, 'MongoDB')
insert into Assuntos values (1, 'PostgreSQL')
insert into Assuntos values (2, 'PowerBI')
insert into Assuntos values (2, 'Tableau')
insert into Assuntos values (3, 'MVC')
insert into Assuntos values (3, 'SOA')
insert into Assuntos values (4, 'Levantamento de Requisitos')
insert into Assuntos values (4, 'Fluxogramas')
insert into Assuntos values (5, 'JavaScript')
insert into Assuntos values (5, '.Net Core')
insert into Assuntos values (6, 'Testes Unitários')
insert into Assuntos values (6, 'Automação de Testes')
insert into Assuntos values (7, 'Cloud')
insert into Assuntos values (7, 'Windows Server')
insert into Assuntos values (7, 'Linux')
insert into Assuntos values (8, 'Firewall')
insert into Assuntos values (8, 'VPN')


-- Script alimenta tb Usuarios
insert into Usuarios values ('Administrador', '032.101.197-78', '07/18/1980', 'admin', 'desktoprlz')

-- Script alimenta tb Criterios
insert into Criterios values ('Nenhum', 0)
insert into Criterios values ('Muito Pouco', 1)
insert into Criterios values ('Razoável', 2)
insert into Criterios values ('Bom', 3)
insert into Criterios values ('Ótimo', 4)