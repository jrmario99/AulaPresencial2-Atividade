### Atividade Aula Presencial 2

** Página index (home)**
- Lista dos dados já cadastrados no banco;

** Página de consulta e cadastro contem os seguintes**
- Título da página;
- Todos os campos necessários para a consulta e disponibilização das
informações.
- Botão para consultar os dados;
- Botão para cadastrar os dados;

**A aplicação consulta dados do Webservice - API - Covid19 Brazil API**
- A consulta dos dados ao WebService se dá por Javascript no endereço web: https://covid19-brazil-api-docs.now.sh/  e após essa consulta os dados
devem são cadastrados no banco.
- São consultados os dados de casos de covid por Estado naquele dia e horário, por meio  do serviço, onde é passado a sigla do Estado.

`GET:  https://covid19-brazil-api.now.sh/api/report/v1/brazil/uf/{siglauf}` 

** Página Sobre**
- Disponibiliza informações do Webservice consumido e os serviços disponibilizados;


**A aplicação disponibiliza os seguintes serviços:**

`GET: /api/CasosCovid/Listar `

`GET : /api/CasosCovid/Buscar/{id}`

`DELETE : /api/CasosCovid/DeletarCaso/{id}`

`POST : /api/CasosCovid/Cadastrar`