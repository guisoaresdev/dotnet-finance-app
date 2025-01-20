# API de Alocação de Recursos

## Sobre o projeto

A ideia deste projeto é desenvolver uma REST API capaz de cadastrar novos endpoints para alocar recursos específicos da web que os usuários possam necessitar.  
O objetivo principal é praticar o uso do .NET, explorando suas funcionalidades e o desenvolvimento de APIs RESTful.

---

## Funcionalidades

- **Cadastro de endpoints**: Permite criar endpoints personalizados para diferentes recursos.
- **Listagem de endpoints**: Retorna todos os endpoints registrados.
- **Atualização de endpoints**: Atualiza os detalhes de um endpoint existente.
- **Exclusão de endpoints**: Remove endpoints cadastrados.
- **Validação de endpoints**: Verifica se um endpoint está funcional.

---

## Tecnologias utilizadas

- **.NET LTS Version 8.0**
- **C#**
- **Entity Framework Core** (para persistência de dados)
- **Swagger** (para documentação e testes da API)

---

## Rodando o projeto

### Pré-requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)

### Configuração do ambiente

1. Clone o repositório para sua máquina:
```
git clone https://github.com/guisoaresdev/dotnet-api-4-api.git
```
2. Navegue até o diretório do projeto:

```
cd dotnet-api-4-api
```

3. Restaure as dependências do projeto:

```
dotnet restore
```

4. Inicie o servidor de desenvolvimento:

```
dotnet run
```
