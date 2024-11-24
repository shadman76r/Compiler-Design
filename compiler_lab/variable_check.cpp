/*#include <iostream>
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
}*/

#include <iostream>
#include <string>
using namespace std;

int main() {
    string variable="name";
    //cout << "Enter a variable name: ";
    //cin >> variable;

    bool isValid = true;

    // Check if the variable is empty
    if (variable.empty()) {
        cout << "Invalid variable name: Variable name cannot be empty.\n";
        isValid = false;
    } 
    // Check if the first character is a letter or an underscore
    else if (!((variable[0] >= 'A' && variable[0] <= 'Z') || 
               (variable[0] >= 'a' && variable[0] <= 'z') || 
               variable[0] == '_')) {
        cout << "Invalid variable name: Variable name must start with a letter or an underscore (_).\n";
        isValid = false;
    } 
    // Check the rest of the characters
    else {
        for (int i = 1; i < variable.length(); i++) {
            char ch = variable[i];
            bool isLetter = (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
            bool isDigit = (ch >= '0' && ch <= '9');
            bool isUnderscore = (ch == '_');

            if (!(isLetter || isDigit || isUnderscore)) {
                cout << "Invalid variable name: Character '" << ch << "' is not allowed in a variable name.\n";
                isValid = false;
                break;
            }
        }
    }

    // If the variable passes all checks
    if (isValid) {
        cout << "Valid variable name.\n";
    } else {
        cout << "The format of the variable name is incorrect.\n";
    }

    return 0;
}

