# 📂 Aula 07: Estruturas de Dados

Este diretório contém os exercícios práticos desenvolvidos para exercitar a implementação de vetores e matrizes como forma de organização e representação de dados avançada. Os exercícios foram resolvidos utilizando as linguagens C++ e C#.

---

## 📝 Conteúdo Estudado

- Estruturas de dados
- Variáveis compostas
- Vetores
  - Implementação em C# e C++
- Matrizes
  - Implementação em C# e C++

---

## 💻 Exercícios Práticos

Abaixo estão as descrições exatas e os exemplos de cada um dos 6 exercícios propostos:

### 📋 Exercício 1 (VETOR): Maior Valor e Posição

Construa um algoritmo que leia 5 números inteiros e os armazene em um vetor. Ao final, o programa deve exibir todos os números digitados, o maior valor armazenado e a posição em que esse valor se encontra.

| ENTRADA | SAÍDA |
| :---: | :--- |
| 8 3 12 7 5 | Vetor: 8 3 12 7 5 |
| | Maior valor: 12 |
| | Posição: 2 |

---

### 🔢 Exercício 2 (VETOR): Separação de Pares e Ímpares

Construa um algoritmo que leia 10 números inteiros e armazene-os em um vetor (use o for para fazer a leitura). Depois, crie **automaticamente** dois vetores, um contendo apenas os números pares e outro os números ímpares digitados.

| ENTRADA | SAÍDA |
| :---: | :--- |
| 5 8 7 9 6 4 10 8 10 9 | PAR: 8 6 4 10 8 10 |
| | ÍMPAR: 5 7 9 9 |

---

### 🔍 Exercício 3 (VETOR): Pesquisa no Vetor

Construa um algoritmo que leia 10 números inteiros. Depois solicite para o usuário um número que ele gostaria de pesquisar no vetor. Caso o número exista no vetor, mostre em qual posição (ou quais) ele aparece e quantas ocorrências foram detectadas.

---

### 🔢 Exercício 4 (MATRIZ): Soma de Elementos de uma Matriz 3x3

Construa um algoritmo que leia uma matriz 3x3 de números inteiros. Ao final, o programa deverá mostrar a matriz digitada e calcular a soma de todos os elementos da matriz.

| ENTRADA | SAÍDA |
| :---: | :---: |
| 1 2 3 | 1 2 3 |
| 4 5 6 | 4 5 6 |
| 7 8 9 | 7 8 9 |
| | Soma = 45 |

---

### 🗺️ Exercício 5 (MATRIZ): Distância entre Cidades

A tabela a seguir mostra a distância de quatro cidades entre si. Por exemplo, a distância entre Vitória e Belo Horizonte é de 524 km.

|  | Vitória | Belo Horizonte | Rio de Janeiro | São Paulo |
| :--- | :---: | :---: | :---: | :---: |
| **Vitória** | — | 524 | 521 | 882 |
| **Belo Horizonte** | 524 | — | 434 | 586 |
| **Rio de Janeiro** | 521 | 434 | — | 429 |
| **São Paulo** | 882 | 586 | 429 | — |

Crie um programa que leia essa matriz e informe ao usuário a distância entre duas cidades por ele fornecidas. O programa deve ficar repetindo até que o usuário informe a mesma cidade como origem e destino.

---

### ✖️ Exercício 6 (MATRIZ): Multiplicação de Matrizes A×B

Crie um algoritmo que leia duas matrizes A e B, de tamanho 3x3, e calcule A×B.

*Exemplo de multiplicação:*

B × A = `[[-1, 3], [4, 2]]` × `[[1, 2], [3, 4]]` = `[[8, 10], [10, 16]]`