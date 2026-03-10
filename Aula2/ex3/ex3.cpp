#include <iostream>
using namespace std;

int main() {
int num, horas;
float valor, salario;

cout << "Insira o numero do funcionario: ";
cin >> num;

cout << "Insira o numero de horas trabalhadas: ";
cin >> horas;

cout << "Insira o valor por hora: ";
cin >> valor;

salario = horas * valor;
cout << "NUMBER = " << num << "\nSALARY = U$ " << salario << endl;
return 0;
}