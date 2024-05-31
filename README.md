# API_Desafio_ATS_2

API Web com o ASP.NET Core 8.0 com MongoDB para um sistema de ATS com CRUD de candidatos e vagas, além da possibilidade do candidato se candidatar a uma vaga, obter a lista de candidatos candidatos a uma vaga através do ID da vaga e do candidato enviar seu currículo.

**Pré-requisito**
Ter o MongoDB instalado. A API se conecta ao MongoDB através da porta padrão **27017**. Caso o MongoDB utilize outra porta, altere o arquivo **appsettings.json**, informando a porta na propriedade **"ConnectionString"** de **"MongoDbSettings"**. Caso deseje, altere o nome da database na propriedade **"DatabaseName"**.

Para executar a aplicação, abra o projeto no Visual Studio e inicie a execução através do Ctrl + F5. 
Será aberto a janela do Browser com a página do Swagger onde poderá ser testado os Endpoints para o CRUD, mas também é possível utilizar o Postman para efetuar testes, através de importação do arquivo **Desafio ATS.postman_collection.json** em **DesafioATS.API**.
