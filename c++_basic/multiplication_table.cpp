#include <iostream>
using namespace std;

int main() {
    int number;

    cout << "Enter an integer to generate its multiplication table thay you want to generate: ";
    cin >> number;

    cout << "Multiplication Table for " << number <<endl;
    for (int i = 1; i <= 10; i++) 
    {
        cout << number << " x " << i << " = " << (number * i) << endl;
    }
    return 0;
}
