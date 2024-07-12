<strong>Desafio prático de Programação - Autoglass</strong></br>
</br>
O que desenvolver?</br>
Você irá criar API para a gestão de produtos, com os seguintes recursos:</br>
</br>
•	Recuperar um registro por código;</br>
</br>
•	Listar registros</br>
 	Filtrando a partir de parâmetros e paginando a resposta</br>
</br>
•	Inserir </br>
  Criar validação para o campo data de fabricação que não poderá ser maior ou igual a data de validade.</br>
</br>
•	Editar</br>
  Criar validação para o campo data de fabricação que não poderá ser maior ou igual a data de validade.</br>
</br>
•	Excluir </br>
  A exclusão deverá ser lógica, atualizando o campo situação com o valor Inativo.</br>
</br>
Campos no escopo de produtos são</br>
</br>
•	Código do produto (sequencial e não nulo)</br>
•	Descrição do produto (não nulo)</br>
•	Situação do produto (Ativo ou Inativo)</br>
•	Data de fabricação</br>
•	Data de validade</br>
•	Código do fornecedor</br>
•	Descrição do fornecedor</br>
•	CNPJ do fornecedor</br>
</br>
Requisitos</br>
</br>
Obrigatório</br>
•	Construir a Web-api em dotnet core ou dotnet 5.</br>
•	Construir a estrutura em camadas e em DDD.</br>
</br>
Diferenciais</br>
•	Utilizar ORM</br>
•	Utilizar a biblioteca Automapper para fazer o mapeamento entity-DTO.</br>
•	Fazer teste unitários
