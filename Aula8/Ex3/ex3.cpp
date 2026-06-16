#include <iostream>
#include <string>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    float Preco;
};

int main() {
    Livro vetor[3];
    float valorTotal = 0;
    float mediapaginas = 0;

    for (int i = 0; i < 3; i++) {
        cout << "Livro " << i + 1 << ":" << endl;
        cout << "Digite o titulo do livro: ";
        cin >> vetor[i].Titulo;
        cout << "Digite o autor do livro: ";
        cin >> vetor[i].Autor;
        cout << "Digite o ano de publicacao do livro: ";
        cin >> vetor[i].AnoPublicacao;
        cout << "Digite o numero de paginas do livro: ";
        cin >> vetor[i].NumeroPaginas;
        cout << "Digite o preco do livro: ";
        cin >> vetor[i].Preco;

        valorTotal += vetor[i].Preco;
        mediapaginas += vetor[i].NumeroPaginas;
    }

    mediapaginas /= 3;

    cout << "O valor total dos livros e: " << valorTotal << endl;
    cout << "A media de paginas dos livros e: " << mediapaginas << endl;

    return 0;
    }