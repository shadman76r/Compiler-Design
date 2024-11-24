#include<bits/stdc++.h>
using namespace std;
int main() {
    // Define keywords and operators in arrays
    const char* keywords[] = {"int", "float", "char", "if", "else", "for", "while", "return", "void", "cout"};
    const char* operators[] = {"+", "-", "*", "/", "%", "=", "==", "!=", "<", ">", "<=", "<<", "&&", "||"};
    const char punctuation[] = {';', ',', '(', ')', '{', '}', '[', ']'};
    char input[100]; // Array to hold the input string
    ifstream inputFile("C://Users//shadm//Desktop//Compiler_design//Compiler-Design//variable_check.cpp"); // Open the input file
    if (!inputFile) {
        cout << "Error opening file!" << endl;
        return 1;
    }
    // Initialize arrays to store categorized tokens
    char identifiers[100][100]; // Array of identifiers
    char ops[100][10]; // Array of operators
    char keys[100][10]; // Array of keywords
    char puncts[100][2]; // Array of punctuation
    int idCount = 0, opCount = 0, keyCount = 0, puncCount = 0; // Counters for each category
    // Read the file line by line
    while (inputFile.getline(input, 100)) {
        char token[100]; // Array to hold individual tokens
        int tokenIndex = 0; // Index for the token array
        // Loop through the input string to tokenize
        for (int i = 0; i <= strlen(input); i++) {
            // If we hit a space or the end of the string, process the token
            if (input[i] == ' ' || input[i] == '\0') {
                token[tokenIndex] = '\0'; // Null-terminate the token
                tokenIndex = 0; // Reset token index
                if (strlen(token) > 0) { // Ensure token is not empty
                    // Check if the token is a keyword
                    bool isKeyword = false;
                    for (int j = 0; j < 10; j++) { ///for keywords
                        if (strcmp(token, keywords[j]) == 0) {
                            bool duplicate = false;
                            for (int k = 0; k < keyCount; k++) {
                                if (strcmp(keys[k], token) == 0) {
                                    duplicate = true;
                                    break;
                                }
                            }
                            if (!duplicate) {
                                strcpy(keys[keyCount++], token);
                            }
                            isKeyword = true;
                            break;
                        }
                    }
                    // Check if the token is an operator
                    bool isOperator = false;
                    for (int j = 0; j < 14; j++) {
                        if (strcmp(token, operators[j]) == 0) {
                            bool duplicate = false;
                            for (int k = 0; k < opCount; k++) {
                                if (strcmp(ops[k], token) == 0) {
                                    duplicate = true;
                                    break;
                                }
                            }
                            if (!duplicate) {
                                strcpy(ops[opCount++], token);
                            }
                            isOperator = true;
                            break;
                        }
                    }
                    // Check if the token is punctuation
                    bool isPunctuation = false;
                    for (int j = 0; j < 8; j++) {
                        if (token[0] == punctuation[j] && token[1] == '\0') {
                            bool duplicate = false;
                            for (int k = 0; k < puncCount; k++) {
                                if (strcmp(puncts[k], token) == 0) {
                                    duplicate = true;
                                    break;
                                }
                            }
                            if (!duplicate) {
                                strcpy(puncts[puncCount++], token);
                            }
                            isPunctuation = true;
                            break;
                        }
                    }
                    // If not recognized as keyword, operator, or punctuation, check if it's an identifier
                    if (!isKeyword && !isOperator && !isPunctuation) {
                        if (isalpha(token[0]) || token[0] == '_') { // Must start with a letter or underscore
                            bool isIdentifier = true;
                            for (int k = 0; k < strlen(token); k++) {
                                if (!isalnum(token[k]) && token[k] != '_') {
                                    isIdentifier = false;
                                    break;
                                }
                            }
                            if (isIdentifier) {
                                bool duplicate = false;
                                for (int k = 0; k < idCount; k++) {
                                    if (strcmp(identifiers[k], token) == 0) {
                                        duplicate = true;
                                        break;
                                    }
                                }
                                if (!duplicate) {
                                    strcpy(identifiers[idCount++], token);
                                }
                            }
                        }
                    }
                }
            } else {
                token[tokenIndex++] = input[i]; // Build the current token
            }
        }
    }
    inputFile.close(); // Close the file
    // Display results in the specified format
    cout << "Identifiers: ";
    for (int i = 0; i < idCount; i++) cout << identifiers[i] << " ";
    cout << endl;
    cout << "Operators: ";
    for (int i = 0; i < opCount; i++) cout << ops[i] << " ";
    cout << endl;
    cout << "Keywords: ";
    for (int i = 0; i < keyCount; i++) cout << keys[i] << " ";
    cout << endl;
    cout << "Punctuation: ";
    for (int i = 0; i < puncCount; i++) cout << puncts[i] << " ";
    cout << endl;
    return 0;
}
