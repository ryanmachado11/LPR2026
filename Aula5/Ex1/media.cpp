# include <iostream>
using namespace std;
int main() {
    int quantidade, numero, contador, soma = 0;

    cout << "Digite a quantidade de numeros: ";
    cin >> quantidade;

    for (int i = 0; i < quantidade; i++) {
        cout << "Digite o numero " << i + 1 << ": ";
        cin >> numero;
        soma += numero;
    }

    if (contador > 0) {
        double media = (double)soma / quantidade;
        cout << "A media dos numeros digitados e: " << media << endl;
    } else {
        cout << "Nenhum numero foi digitado." << endl;
    }
}
