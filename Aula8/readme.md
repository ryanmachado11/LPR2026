```md
# 📂 Aula 08: Structs (Registros)

Este diretório contém os exercícios práticos desenvolvidos para exercitar a utilização de structs (registros) como forma de organizar e representar entidades compostas por diferentes tipos de dados. Os exercícios foram resolvidos utilizando as linguagens C# e C++.

---

## 📝 Conteúdo Estudado

- Variáveis compostas
- Structs (Registros)
  - Implementação em C# e C++

---

## 💻 Exercícios Práticos

Abaixo estão as descrições dos 5 exercícios propostos:

### 🎬 Exercício 1: Cadastro de Filmes

Defina uma struct chamada `Filme` contendo os seguintes campos:

- Titulo
- Diretor
- AnoLancamento
- DuracaoMinutos

O programa deve:

- Solicitar os dados de 3 filmes.
- Armazená-los em um vetor de structs.
- Exibir todos os filmes cadastrados.
- Informar qual é o filme mais antigo.

---

### 📦 Exercício 2: Controle de Produtos

Defina uma struct chamada `Produto` contendo os seguintes campos:

- Nome
- Codigo
- Preco
- Quantidade

O programa deve:

- Permitir ao usuário inserir os dados de 3 produtos.
- Armazenar os produtos em um vetor de structs.
- Calcular e exibir o valor total em estoque, considerando o preço e a quantidade de cada produto.

---

### 📚 Exercício 3: Cadastro de Livros

Defina uma struct chamada `Livro` contendo os seguintes campos:

- Titulo
- Autor
- AnoPublicacao
- NumeroPaginas
- Preco

O programa deve:

- Permitir ao usuário inserir os dados de 3 livros.
- Calcular e exibir o preço total dos livros cadastrados.
- Calcular e exibir a média de páginas dos livros.

---

### 🦸 Exercício 4: Seleção de Heróis da Marvel

Desenvolva um programa em C# que simule um sistema de seleção de heróis da Marvel para uma equipe.

Funcionalidades:

#### Cadastro de Heróis

- Criar uma função chamada `cadastrarHeroi`.
- Permitir o cadastro de até 5 heróis.
- Armazenar nome, poder e pontuação em uma struct.

#### Seleção de Equipe

- Criar uma função chamada `selecionarEquipe`.
- Exibir os heróis cadastrados.
- Permitir a seleção de 3 heróis para formar uma equipe.

#### Pontuação Total

- Criar uma função chamada `calcularPontuacaoTotal`.
- Somar a pontuação dos heróis selecionados.

#### Exibição da Equipe

- Criar uma função chamada `exibirEquipe`.
- Exibir os heróis selecionados, seus poderes e a pontuação total da equipe.

#### Menu

- Criar uma função chamada `menuPrincipal`.
- Exibir as opções disponíveis do sistema.
- Executar a funcionalidade escolhida pelo usuário.

**Requisitos adicionais:**

- O programa deve permanecer em execução até o usuário escolher sair.
- Utilizar structs para armazenar as informações dos heróis e da equipe.
- Não utilizar classes ou listas.
- Utilizar vetores para armazenamento dos dados.

---

### 🏢 Exercício 5: Sistema de Chamados

Uma empresa deseja controlar os chamados abertos pelos funcionários.

Criar uma struct chamada `Chamado` contendo:

- Numero
- Solicitante
- Setor
- Prioridade (1 a 3)
- Status
- Descricao

O programa deve possuir as seguintes funções:

#### cadastrarChamado()

- Permite cadastrar até 10 chamados.
- O status inicial deve ser "Aberto".

#### listarChamados()

- Exibe todos os chamados cadastrados.

#### atualizarStatus()

- Solicita o número do chamado.
- Permite alterar o status para:
  - Em andamento
  - Resolvido
  - Cancelado

#### classificarPrioridade()

Recebe a prioridade e retorna:

- 1 = Baixa
- 2 = Média
- 3 = Alta

#### estatisticas()

Exibe:

- Quantos chamados estão abertos.
- Quantos estão em andamento.
- Quantos foram resolvidos.
- Quantos foram cancelados.

---

## 🎯 Objetivo da Aula

Compreender e utilizar structs (registros) para representar entidades compostas por diferentes tipos de dados, organizando informações relacionadas em uma única estrutura e aplicando esse conceito na resolução de problemas utilizando vetores e funções.
```
