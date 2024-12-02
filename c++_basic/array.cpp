#include <iostream>
using namespace std;

int main() {
    // Predefined array with a fixed size
    int arr[6] = {10, 15, 20, 25, 30, 35};
    int sum = 0;

    cout << "Numbers at odd positions: ";
    for (int i = 1; i < 6; i += 2) {
        cout << arr[i] << " ";
        sum += arr[i];
    }
    cout << endl;

    // Display the sum of odd-positioned numbers
    cout << "Sum of elements at odd positions: " << sum << endl;

    // Check if the summation is odd or even
    if (sum % 2 == 0) {
        cout << "The summation is EVEN" << endl;
    } else {
        cout << "The summation is ODD" << endl;
    }

    return 0;
}
/*
#include <iostream>
using namespace std;

int main() {
    int n;
    cout << "Enter the size of the array: ";
    cin >> n;

    int arr[n];
    cout << "Enter the elements of the array: ";
    for (int i = 0; i < n; i++) {
        cin >> arr[i];
    }

    int sum = 0;
    cout << "Numbers at odd positions: ";
    
    // Loop through odd positions (index 1, 3, 5, ...)
    for (int i = 1; i < n; i += 2) {
        cout << arr[i] << " "; // Print the element
        sum += arr[i];         // Add to the sum
    }
    cout << endl;

    // Display the sum of odd-positioned numbers
    cout << "Sum of elements at odd positions: " << sum << endl;

    // Check if the summation is odd or even
    if (sum % 2 == 0) {
        cout << "The summation is EVEN" << endl;
    } else {
        cout << "The summation is ODD" << endl;
    }

    return 0;
}


*/