#include <iostream>
#include <string>
using namespace std;
int main() {
    int n1, n2;
    cout << "Digite o primeiro numero: ";
    cin >> n1;
    cout << "Digite o segundo numero: ";
    cin >> n2;
    if (n1 % n2 == 0 || n2 % n1 == 0) {
        cout << "Os numeros sao multiplos." << endl;
    } else {
        cout << "Os numeros nao sao multiplos." << endl;
    }
    return 0;
}