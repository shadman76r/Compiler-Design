#include <iostream>
using namespace std;

int main() {
    int number=8;

    //cout << "Enter an integer to generate its multiplication table thay you want to generate: ";
    //cin >> number;

    cout << "Multiplication Table for " << number <<endl;
    for (int i = 1; i <= 10; i++) 
    {
        cout << number << " orion " << i << " = " << (number * i) << endl;
    }
    return 0;
}
