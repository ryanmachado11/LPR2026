#include <iostream>
#include <string>
using namespace std;

struct Produto {
    string nome;
    int codigo;
    float preco;
    int quantidade;
};

int main() {
    Produto vetor[3];
    float valorTotal = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Digite o nome do produto: ";
        cin >> vetor[i].nome;
        cout << "Digite o codigo do produto: ";
        cin >> vetor[i].codigo;
        cout << "Digite o preco do produto: ";
        cin >> vetor[i].preco;
        cout << "Digite a quantidade do produto: ";
        cin >> vetor[i].quantidade;

        valorTotal += vetor[i].preco * vetor[i].quantidade;  
    }

    cout << "O valor total do estoque e: " << valorTotal << endl;

    return 0;
}