#include <iostream>
using namespace std;

int main() {
    const int YEARS = 8;
    int years[YEARS];
    cout << "Enter the birth years of 8 historical figures with in 1000 to 2024:" << endl;
    for (int i = 0; i < YEARS; ++i) {
        cin >> years[i];
    }
    cout << "Years that are not leap years in the array are: ";
    for (int i = 0; i < YEARS; ++i) {
        if (years[i] >= 1000 && years[i] <= 2024)
            {
            if (!(years[i] % 4 == 0 && (years[i] % 100 != 0 || years[i] % 400 == 0)))
            {
                cout << years[i] << " ";
            }
        }
    }

    return 0;
}
