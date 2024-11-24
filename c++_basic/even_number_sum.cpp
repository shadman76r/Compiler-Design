#include <iostream>
using namespace std;
int main() {
    int n, sum = 0;

    cout << "Enter a valid integer value: "<<endl;
    cin >> n;

    for (int i = 2; i <= n; i += 2) {
        sum += i;
    }

    cout << "The sum of even numbers from 1 to " << n << " is: " << sum << endl;

    return 0;
}
