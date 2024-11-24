#include <iostream>
#include <cctype>
#include <string>
using namespace std;

int main() {
    string variable;
    cout << "Enter a variable name: ";
    cin >> variable;

    bool isValid = true;

    // Check if the variable starts with a valid character
    if (variable.empty() || (!isalpha(variable[0]) && variable[0] != '_')) {
        isValid = false;
    } else {
        // Check the rest of the variable
        for (int i = 0; i < variable.length(); i++) {
            if (!isalnum(variable[i]) && variable[i] != '_') {
                isValid = false;
                break;
            }
        }
    }

    if (isValid) {
        std::cout << "Valid variable name.\n";
    } else {
        std::cout << "Invalid variable name.\n";
    }

    return 0;
}
