#include <iostream>
using namespace std;

int main() {
    cout << "Calculador de distancia entre cidades" << endl;

    int matriz[4][4] = {
        {0, 524, 521, 882},
        {524, 0, 434, 586},
        {521, 434, 0, 429},
        {882, 586, 429, 0}
    };

    int origem;
    int destino;

    do{

    cout << "Para sair, selecione a mesma cidade de origem e destino." << endl;

    cout << "insira a cidade de origem (1 - Vitoria, 2 - Belo Horizonte, 3 - Rio de Janeiro, 4 - Sao Paulo): ";
    cin >> origem;

    cout << "insira a cidade a ser visitada (1 - Vitoria, 2 - Belo Horizonte, 3 - Rio de Janeiro, 4 - Sao Paulo): ";
    cin >> destino;

    if (origem >= 1 && origem <= 4 && destino >= 1 && destino <= 4) {
        cout << "A distancia entre as cidades é: " << matriz[origem - 1][destino - 1] << " km" << endl;
    } else {
        cout << "Cidade inválida. Por favor, insira um número entre 1 e 4." << endl;
    }

    } while (origem != destino);
    
    return 0;
}