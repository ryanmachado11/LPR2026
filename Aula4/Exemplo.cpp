#include <iostream>
#include <string>
using namespace std;
int main() {
double preco;
int codigoOrigem;
string regiao;
// Leitura do preço e código de origem
cout << "Digite o preco do produto: ";
cin >> preco;
cout << "Digite o codigo de origem (1 - Sul, 2 - Norte, 3 -Leste, 4 - Oeste): ";
cin >> codigoOrigem;
// Determinação da região de procedência
switch (codigoOrigem) {
case 1:
regiao = "Sul";
break;
case 2:
regiao = "Norte";
break;
case 3:
regiao = "Leste";
break;
case 4:
regiao = "Oeste";
break;
default:
regiao = "Importado";
break;
}
cout << "Valor do produto: R$ " << preco << endl;
cout << "Regiao de procedencia: " << regiao << endl;
return 0;
}