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
/*
#include <bits/stdc++.h>
using namespace std;

int main() {
    string variable="name";
   // cout<<"Enter a valid variable name"<<endl;
    //cin>>variable;

    bool isValid = true;

    // Check if the first character is a letter or an underscore
    if (!((variable[0] >= 'A' && variable[0] <= 'Z') || 
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
        cout << "Valid variable name."<<endl;
    } else {
        cout << "The format of the variable name is incorrect."<<endl;
    }

    return 0;
}*/


#include <bits/stdc++.h>
using namespace std;

int main() {
    string declaration;
    cout << "Enter a valid variable: ";
    getline(cin, declaration);

    // Manually specify the size of the array
    string validDataTypes[] = {"int", "float", "char", "string", "double", "bool"};
    int numDataTypes = 6; // Manually set the size of the array

    // Variables to hold the data type and variable name
    string dataType = "", variable = "";
    int i = 0;

    // Extract data type
    for (i; i < declaration.length() && declaration[i] != ' '; i++) {
        dataType += declaration[i];
    }

    // Skip spaces between data type and variable name
    for (i; i < declaration.length() && declaration[i] == ' '; i++) {
        // Do nothing; just move the index forward
    }

    // Extract variable name
    for (i; i < declaration.length(); i++) {
        variable += declaration[i];
    }

    // Check if the data type is valid
    bool isValidDataType = false;
    for (int j = 0; j < numDataTypes; j++) {
        if (dataType == validDataTypes[j]) {
            isValidDataType = true;
            break;
        }
    }

    // Validate the variable name
    bool isValidVariable = true;
    if (variable.empty()) {
        isValidVariable = false;
        cout << "Invalid declaration: No variable name provided.\n";
    } else {
        // Check the first character of the variable name
        if (!((variable[0] >= 'A' && variable[0] <= 'Z') ||
              (variable[0] >= 'a' && variable[0] <= 'z') ||
              variable[0] == '_')) {
            cout << "Invalid variable name: Must start with a letter or an underscore (_).\n";
            isValidVariable = false;
        }

        // Check the remaining characters of the variable name
        for (int k = 1; k < variable.length(); k++) {
            char ch = variable[k];
            bool isLetter = (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
            bool isDigit = (ch >= '0' && ch <= '9');
            bool isUnderscore = (ch == '_');
            if (!(isLetter || isDigit || isUnderscore)) {
                cout << "Invalid variable name: Character '" << ch << "' is not allowed.\n";
                isValidVariable = false;
                break;
            }
        }
    }

    if (!isValidDataType) {
        cout << "Invalid data type: " << dataType << endl;
    }
    if (isValidDataType && isValidVariable) {
        cout << "Valid declaration: Data type is '" << dataType << "', and variable name is '" << variable << "'.\n";
    } else {
        cout << "The declaration is incorrect.\n";
    }

    return 0;
}
