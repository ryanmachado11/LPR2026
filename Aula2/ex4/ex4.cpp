#include <iostream>
using namespace std;

int main() {
int codigo1, codigo2, quantidade1, quantidade2;
float valor1, valor2, total;

cout << "Insira o codigo, quantidade e valor do primeiro produto: ";
cin >> codigo1 >> quantidade1 >> valor1;

cout << "Insira o codigo, quantidade e valor do segundo produto: ";
cin >> codigo2 >> quantidade2 >> valor2;

total = (quantidade1 * valor1) + (quantidade2 * valor2);
cout << "VALOR A PAGAR: R$ " << total << endl;
return 0;
}