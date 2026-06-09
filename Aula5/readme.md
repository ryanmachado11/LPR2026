# 📂 Aula 05: Estruturas de Repetição

Este diretório contém os exercícios práticos desenvolvidos para exercitar a implementação de malhas de repetição e comparar o comportamento de contadores e acumuladores. Os exercícios foram resolvidos utilizando as linguagens C# e C++.

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
Construa um algoritmo que calcule a média aritmética de um conjunto de números pares fornecidos pelo usuário. O usuário deve fornecer primeiro a quantidade de números que serão digitados, e em seguida, os números considerados na média. O usuário pode digitar números ímpares, que devem ser ignorados.

*Exemplo:* Se for informado que serão digitados 5 números (2, 7, 8, 6, 10), o programa deve considerar apenas os pares (2, 8, 6 e 10) e ignorar o 7.

| ENTRADA | SAÍDA |
| :--- | :---: |
| 5 2 7 8 6 10 | 6,5 |

---

### 🎲 Exercício 2 (DO WHILE): Jogo de Adivinhação
Construa um algoritmo de adivinhação de números onde o sistema gera um número inteiro aleatório de 1 a 100.

O usuário deve digitar números no console até acertar o número gerado. A cada chute, o programa deve responder com "chutou alto", "chutou baixo" ou "acertou". Após acertar, deve ser mostrado quantas tentativas foram usadas.

*Código utilizado para gerar o número:*
- **C#:** `Random numAleatorio = new Random(); int valorInteiro = numAleatorio.Next(1, 100);`
- **C++:** `random_device numAleatorio; uniform_int_distribution<> distribuicao(1, 100); int valorInteiro = distribuicao(numAleatorio);`

---

### 🔢 Exercício 3 (FOR): Soma de Ímpares Múltiplos de 3
Elabore um algoritmo que calcule a soma de todos os números ímpares múltiplos de 3 que se encontrem no conjunto dos números de 50 a 500.

| ENTRADA | SAÍDA |
| :---: | :---: |
| *(Nenhuma)* | 20475 |

---

### 🧮 Exercício 4: Soma dos Dígitos do Quadrado
*ESCOLHA A MELHOR ESTRUTURA DE REPETIÇÃO:* Solicite ao usuário para inserir um número e calcule a soma dos dígitos do quadrado desse número.

*Exemplo:* Se o número for 123, o quadrado é 15129 (123 * 123). A soma dos dígitos será: 1 + 5 + 1 + 2 + 9 = 18.

| ENTRADA | SAÍDA |
| :---: | :---: |
| 123 | 18 |

---

### 🌌 Exercício 5: Treinamento Jedi
*ESCOLHA A MELHOR ESTRUTURA DE REPETIÇÃO:* Crie um programa que simula o treinamento de um Jedi. O usuário deve inserir o número de horas de treinamento por dia. O programa deve calcular o total de horas de treinamento em uma semana, desconsiderando sábados e domingos, e informar quantos dias, semanas e meses seriam necessários para alcançar o total de 1000 horas de treinamento. Considere 1 mês = 4,5 semanas.