#include<bits/stdc++.h>
using namespace std;
int main() {
    ifstream file("C://Users//shadm//Desktop//Compiler_design//Compiler-Design//lab_task_compiler_file.cpp");
    string line;
    int lineNumber = 0;
    set<string> validDataTypes = {"void", "int", "float", "double", "char", "bool", "string","long", "short", "unsigned", "signed", "std::string"};
    if (!file.is_open()) {
        cerr << "Error: Could not open file." << endl;
        return 1;
    }
    cout << "Function Analysis:\n";
    while (getline(file, line)) {
        lineNumber++;
        size_t openParen = line.find('(');
        size_t closeParen = line.find(')');
        size_t openBrace = line.find('{');
        if (openParen != string::npos) {
            if (closeParen == string::npos || closeParen<openParen) {
                cout << "Error on line " << lineNumber << ": Missing or misplaced ')' in function definition.\n";
                continue;
            }

            string beforeParen = line.substr(0, openParen);
            size_t lastSpace = beforeParen.find_last_of(" \t");
            if (lastSpace == string::npos) {
                cout << "Error on line " << lineNumber << ": Missing return type or function name.\n";
                continue;
            }
            string returnType = beforeParen.substr(0, lastSpace);
            string functionName = beforeParen.substr(lastSpace + 1);

            if (validDataTypes.find(returnType) == validDataTypes.end()) {
                cout << "Error on line " << lineNumber << ": Invalid or missing return type '" << returnType << "'.\n";
                continue;
            }
            if (functionName.empty()) {
                cout << "Error on line " << lineNumber << ": Missing function name after return type '" << returnType << "'.\n";
                continue;
            }

            if (openBrace == string::npos) {
                cout << "Error on line " << lineNumber << ": Missing '{'for function '" << functionName << "'.\n";
                continue;
            }

            cout << "Line " << lineNumber << ": Valid function '" << functionName << "' with return type '" << returnType << "'.\n";
        }
    }
    file.close();
    return 0;
    }

    // && line.find(';') == string::npos
