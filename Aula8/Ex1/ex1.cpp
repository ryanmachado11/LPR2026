#include <iostream>
#include <string>
using namespace std;

struct Filme {
    string Titulo;
    string Diretor;
    int AnoLancamento;
    float DuracaoMinutos;
};
int main() {
    
    Filme vetor[3];

    for (int i = 0; i < 3; i++) {
        cout << "Digite o titulo do filme: ";
        cin >> vetor[i].Titulo;
        cout << "Digite o diretor do filme: ";
        cin >> vetor[i].Diretor;
        cout << "Digite o ano de lancamento do filme: ";
        cin >> vetor[i].AnoLancamento;
        cout << "Digite a duracao do filme em minutos: ";
        cin >> vetor[i].DuracaoMinutos;
    }

    cout << "\nInformações dos filmes:\n";

    for (int i = 0; i < 3; i++) {
        cout << "Filme " << i + 1 << ":\n";
        cout << "Titulo: " << vetor[i].Titulo << endl;
        cout << "Diretor: " << vetor[i].Diretor << endl;
        cout << "Ano de Lancamento: " << vetor[i].AnoLancamento << endl;
        cout << "Duracao: " << vetor[i].DuracaoMinutos << " minutos\n\n";
    }

    int indiceMaisAntigo = 0;
    for (int i = 1; i < 3; i++) {
        if (vetor[i].AnoLancamento < vetor[indiceMaisAntigo].AnoLancamento) {
            indiceMaisAntigo = i;
        }
    }

    cout << "O filme mais antigo e: " << vetor[indiceMaisAntigo].Titulo << endl;
    return 0;
}
