#include <iostream>
using namespace std;

int reverterNumero(int num) {
    int reverso = 0;
    while (num != 0) {
        int digito = num % 10;      
        reverso = reverso * 10 + digito; 
        num /= 10;                 
    }
    return reverso;
}

int main() {
    int numero;
    cout << "Digite um numero inteiro: ";
    cin >> numero;

    int resultado = reverterNumero(numero);
    cout << "Numero invertido: " << resultado << endl;

    return 0;
}