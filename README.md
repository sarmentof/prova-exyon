# Matriz de Conhecimento

O sistema foi criado usando as tecnologias .Net Core para o back-end e ReactJS para o front-end.

O banco de dados utilizado foi o MS SQL Server na versão 2019.

## Requisitos

- O usuário deve poder acessar com um login existente ou criar um novo login.
- Ao acessar o sistema, o usuário deve poder escolher seus Conhecimentos e inserir notas de avaliação para os mesmos.
- Ao final, deve ser exibido um gráfico de colunas com as notas cadastradas pelo usuário.


## Implementação Backend

- O backend foi implementado usando .Net Core e Entity Framework, usando a abordagem DB First.
- Está preparado para utilização de autenticação com JWT (Não implementado)

## Implementação Frontend

- O frontend foi implementado usando ReactJS, estilizado com a biblioteca Styled Component para dar agilidade no uso de CSS.
- Foi iniciada a implementação de rotas entre as páginas internas usando o react-dom, que posibilita a chamada de páginas apenas para usuários autenticados.
- Também está previsto o uso de localStorage para armazenamento de informações não sensíveis com o uso de React Hooks, uma abordagem mais moderna e facilitadora para manipulação de estados de objetos.