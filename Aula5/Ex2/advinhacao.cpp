#include <iostream>
#include <random>
using namespace std;

int main() {
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);

    int chute;
    int tentativas = 0;

    cout << "Adivinhe o numero (entre 1 e 100):\n";

    do {
        cout << "Digite seu chute: ";
        cin >> chute;

        tentativas++;

        if (chute > valorInteiro) {
            cout << "Chutou alto!\n";
        } else if (chute < valorInteiro) {
            cout << "Chutou baixo!\n";
        } else {
            cout << "Acertou!\n";
        }

    } while (chute != valorInteiro);

    cout << "Voce acertou em " << tentativas << " tentativa(s).\n";

    return 0;
}