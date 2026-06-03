# 📂 Aula 05: Estruturas de Repetição

Este diretório contém os exercícios práticos desenvolvidos para exercitar a implementação de malhas de repetição e comparar o comportamento de contadores e acumuladores. Os exercícios foram resolvidos de forma flexível utilizando as linguagens C# e C++.

---

## 📝 Conteúdo Estudado

- Estruturas de repetição
  - Enquanto (While)
  - Repita (Do While)
  - Para (For)
- Comparador de estruturas de repetição
  - Contador x acumulador

---

## 💻 Exercícios Práticos

Abaixo estão as descrições exatas e os exemplos de cada um dos 5 exercícios propostos:

### 📊 Exercício 1 (WHILE): Média de Números Pares
Construa um algoritmo que calcule a média aritmética de um conjunto de números pares fornecidos pelo usuário. O usuário deve fornecer primeiro a quantidade de números que serão digitados, e em seguida, os números considerados na média. O usuário pode digitar números ímpares, que devem ser ignorados. Por exemplo, no caso da tabela abaixo, o 5 informa que serão digitados 5 números (2 7 8 6 10), e para a média devem ser considerados apenas os números pares (2, 8, 6 e 10) ignorando o número 7 digitado.

| ENTRADA | SAÍDA |
| :--- | :---: |
| 5 2 7 8 6 10 | 6,5 |

### 🎲 Exercício 2 (DO WHILE): Jogo de Adivinhação
Construa um algoritmo de adivinhação de números. Com as linhas abaixo, o algoritmo gerará um número inteiro aleatório de 1 a 100:

**C#**
```csharp
Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);