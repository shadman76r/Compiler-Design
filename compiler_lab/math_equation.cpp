#include <iostream>
using namespace std;

int main() {
    string equation="28 + 26 =25";
    //cout << "Enter a mathematical equation: ";
    //getline(cin, equation);

    bool isValid = true;
    bool hasEqualSign = false;
    bool hasOperator = false;
    bool hasNumber = false;

    // Check each character in the equation
    for (int i = 0; i < equation.length(); i++) {
        char ch = equation[i];

        // Check if the character is a digit
        if (ch >= '0' && ch <= '9') {
            hasNumber = true;
        } 
        // Check if the character is a valid operator
        else if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '=') {
            if (ch == '=') {
                if (hasEqualSign) {
                    // Multiple '=' signs are invalid
                    isValid = false;
                    break;
                }
                hasEqualSign = true;
            } else {
                hasOperator = true;
            }
        } 
        // Ignore spaces
        else if (ch != ' ') {
            isValid = false;
            break;
        }
    }

    // Additional checks for proper equation structure
    if (!hasEqualSign || !hasOperator || !hasNumber) {
        isValid = false;
    }

    if (isValid) {
        cout << "Valid mathematical equation."<<endl;
    } else {
        cout << "Invalid mathematical equation."<<endl;
    }

    return 0;
}
