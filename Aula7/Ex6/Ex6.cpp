#include <iostream>
using namespace std;

int main() {
    int matriz1[3][3], matriz2[3][3], resultado[3][3];

    cout << "Digite os elementos da primeira matriz (3x3):" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            cout << "Elemento [" << i << "][" << j << "]: ";
            cin >> matriz1[i][j];
        }
    }

    cout << "Digite os elementos da segunda matriz (3x3):" << endl;
    for (int i = 0; i < 3; i++) {   
        for (int j = 0; j < 3; j++) {
            cout << "Elemento [" << i << "][" << j << "]: ";
            cin >> matriz2[i][j];
        }
    }

    cout <<"O resultado da multiplicacao das matrizes e:" << endl;
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            resultado[i][j] = 0;
            for (int k = 0; k < 3; k++) {
                resultado[i][j] += matriz1[i][k] * matriz2[k][j];
            }
            cout << resultado[i][j] << " ";
        }
        cout << endl;
    }

    return 0;
}