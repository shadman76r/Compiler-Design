#include <iostream>
using namespace std;

int main() {
    string input;
    //cout << "Enter a string to identify components: ";
    //getline(cin, input);

    for (int i = 0; i < input.length(); i++) {
        char ch = input[i];

        // Check if the character is an alphabet
        if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z')) {
            cout << ch << " is an alphabet."<<endl;
        } 
        // Check if the character is a numeric value
        else if (ch >= '0' && ch <= '9') {
            cout << ch << " is a numeric value."<<endl;
        } 
        // Check if the character is an operator
        else if (ch == '+' || ch == '-' || ch == '*' || ch == '/' || ch == '=') {
            cout << ch << " is an operator."<<endl;
        } 
        // Check for spaces or unknown types
        else if (ch == ' ') {
            cout<<"There is a space"<<endl;
        } else {
            cout << ch << " is of unknown type."<<endl;
        }
    }

    return 0;
}
