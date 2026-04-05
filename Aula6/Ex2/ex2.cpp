#include <iostream>
#include <locale>

using namespace std;

double calcularMediaPares(int qtd) {
    int soma = 0;
    int contadorpares = 0;

    while (qtd > 0) {
        int numero;
        cout << "Digite um numero: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contadorpares++;
        }
        qtd--;
    }

    if (contadorpares > 0) {
        return static_cast<double>(soma) / contadorpares;
    }
    return -1; 
}

int somaDigitosDoQuadrado(int n) {
    int quadrado = n * n;
    int somaDigitos = 0;

    while (quadrado > 0) {
        somaDigitos += quadrado % 10;
        quadrado /= 10;
    }
    return somaDigitos;
}

int main() {
    
    int opcao;

    do {
        cout << "\n--- MENU DE EXERCICIOS ---" << endl;
        cout << "1. Media de numeros pares (Ex 01/03)" << endl;
        cout << "2. Soma dos digitos do quadrado (Ex 04)" << endl;
        cout << "0. Sair" << endl;
        cout << "Escolha uma opção: ";
        cin >> opcao;

        switch (opcao) {
            case 1: {
                int qtd;
                cout << "Quantos numeros deseja inserir? ";
                cin >> qtd;
                
                double resultado = calcularMediaPares(qtd);
                if (resultado != -1) {
                    cout << "A media dos numeros pares e: " << resultado << endl;
                } else {
                    cout << "Nenhum numero par foi digitado." << endl;
                }
                break;
            }
            case 2: {
                int num;
                cout << "Digite um numero: ";
                cin >> num;
                
                int soma = somaDigitosDoQuadrado(num);
                cout << "A soma dos digitos de " << num << " ao quadrado e: " << soma << endl;
                break;
            }
            case 0:
                cout << "Saindo do programa..." << endl;
                break;
            default:
                cout << "Opção invalida!" << endl;
        }
    } while (opcao != 0);

    return 0;
}