#include <iostream>
#include <cstring>

using namespace std;

int main() {
    char reg[50];         // Regular expression input
    int q[50][3];         // Transition table with max 50 states and 3 inputs (0, 1, ε)
    int currentState = 0; // State counter

    // Initialize the transition table
    memset(q, -1, sizeof(q)); // -1 indicates no transition

    // Input the regular expression
    cout << "Enter the regular expression: ";
    cin >> reg;
    cout << "Given regular expression: " << reg << endl;

    int len = strlen(reg);
    int stateStack[50], top = -1; // Stack for state tracking in nested expressions

    for (int i = 0; i < len; i++) {
        if (reg[i] == '0' || reg[i] == '1') {
            // Direct transitions for '0' or '1'
            q[currentState][reg[i] - '0'] = currentState + 1;
            currentState++;
        } else if (reg[i] == '|') {
            // OR operation: branching epsilon transitions
            int branchStart = currentState++;
            stateStack[++top] = branchStart; // Push branch start to stack
            q[branchStart][2] = currentState++; // Epsilon transition to branch
        } else if (reg[i] == '*') {
            // Kleene star: looping epsilon transitions
            int loopStart = currentState - 1;
            int loopEnd = currentState;
            q[loopStart][2] = loopEnd; // Epsilon to loop end
            q[loopEnd][2] = loopStart; // Loop back to loop start
        } else if (reg[i] == '(') {
            // Push the current state to stack
            stateStack[++top] = currentState;
        } else if (reg[i] == ')') {
            // Pop the state from the stack
            int groupStart = stateStack[top--];
            q[groupStart][2] = currentState; // Epsilon transition to the next state
        }
    }

    // Add final epsilon transition to indicate the final state
    q[currentState][2] = currentState + 1;
    currentState++;

    // Print the transition table
    cout << "\n\tTransition Table\n";
    cout << "____________________________________\n";
    cout << "Current State | Input | Next State\n";
    cout << "____________________________________\n";

    for (int i = 0; i <= currentState; i++) {
        if (q[i][0] != -1) {
            cout << "  q[" << i << "]\t      |   0   |  q[" << q[i][0] << "]\n";
        }
        if (q[i][1] != -1) {
            cout << "  q[" << i << "]\t      |   1   |  q[" << q[i][1] << "]\n";
        }
        if (q[i][2] != -1) {
            cout << "  q[" << i << "]\t      |   ε   |  q[" << q[i][2] << "]\n";
        }
    }

    cout << "____________________________________\n";

    return 0;
}
