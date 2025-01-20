#include <iostream>
#include <string>
#include <cctype>
using namespace std;

int main() {
    string expression;
    char tempChar = 'A';

    auto extractOperand = [&](int& pos, int direction) {
        string operand;
        while (pos >= 0 && pos < expression.size() && !ispunct(expression[pos]) && expression[pos] != '$') {
            if (direction == -1)
                operand = expression[pos--] + operand;
            else
                operand += expression[pos++];
        }
        return operand;
    };

    //cout << "INTERMEDIATE CODE GENERATION\n\n";
    cout << " Please Enter the Expression: ";
    cin >> expression;
    cout << "The intermediate code is :\n";

    for (size_t i = 0; i < expression.size(); i++) {
        if (expression[i] == '*' || expression[i] == '/') {
            int leftPos = i - 1, rightPos = i + 1;
            string left = extractOperand(leftPos, -1);
            string right = extractOperand(rightPos, 1);

            cout << tempChar << " := " << left << " " << expression[i] << " " << right << "\n";

            expression[i] = tempChar++;
            expression.erase(leftPos + 1, i - leftPos - 1);
            expression.erase(i, rightPos - i - 1);
            i = leftPos + 1;
        }
    }

    for (size_t i = 0; i < expression.size(); i++) {
        if (expression[i] == '+' || expression[i] == '-') {
            int leftPos = i - 1, rightPos = i + 1;
            string left = extractOperand(leftPos, -1);
            string right = extractOperand(rightPos, 1);

            cout << tempChar << " := " << left << " " << expression[i] << " " << right << "\n";

            expression[i] = tempChar++;
            expression.erase(leftPos + 1, i - leftPos - 1);
            expression.erase(i, rightPos - i - 1);
            i = leftPos + 1;
        }
    }

    cout << tempChar << " := " << expression << "\n";



    return 0;
}
