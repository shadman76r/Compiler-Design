#include <iostream>
using namespace std;

int main() {
    int n;
    double factorial = 1;
    cout << "Enter a valid integer number: ";
    cin >> n;

    if (n < 0) {
        cout << "please do not give negagtive number ." << endl;
    } else {
        int i = 1;
        while (i <= n) {
            factorial *= i; 
            i++;           
        }
        cout << "The factorial of " << n << " is: " << factorial << endl;
    }

    return 0;
}
