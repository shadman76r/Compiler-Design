#include <iostream>
using namespace std;

int main()
{
    int nfa[10][2] = {0}; // NFA transition table
    int numStates, numTransitions;

    // Input the number of states and transitions for the NFA
    cout << "Enter the number of states in the NFA: ";
    cin >> numStates;
    cout << "Enter the number of transitions in the NFA: ";
    cin >> numTransitions;

    cout << "Enter the transitions in the format (state input next_state):\n";
    for (int i = 0; i < numTransitions; i++)
    {
        int state, input, nextState;
        cin >> state >> input >> nextState;
        nfa[state][input] = nextState; /// To Store the NFA transition table
    }

    int dfa[10][2] = {0}; // DFA transition table
    int dstate[10] = {0}; // To track DFA states
    int i = 1, n, k = 1;

    dstate[i++] = 1; // Initialize DFA with the starting state of the NFA
    n = i;

    // Initialize DFA transitions for the first state
    dfa[1][0] = nfa[1][0];
    dfa[1][1] = nfa[1][1];
    //dfa[1][2]= nfa[1][2];
    cout << "\nf(" << dstate[1] << ",a)=" << dfa[1][0];
    cout << "\nf(" << dstate[1] << ",b)=" << dfa[1][1];

    // Add new states for DFA
    for (int j = 1; j < n; j++)
    {
        if (dfa[1][0] != dstate[j])
            dstate[i++] = dfa[1][0];
        if (dfa[1][1] != dstate[j])
            dstate[i++] = dfa[1][1];
    }

    // Process DFA states
    while (dstate[k] != 0)
    {
        int m = dstate[k];
        int q = m / 10, r = m % 10; // Extract individual NFA states

        if (nfa[r][0] != 0)
            dfa[k][0] = nfa[q][0] * 10 + nfa[r][0];
        else
            dfa[k][0] = nfa[q][0];

        if (nfa[r][1] != 0)
            dfa[k][1] = nfa[q][1] * 10 + nfa[r][1];
        else
            dfa[k][1] = nfa[q][1];

        cout << "\nf(" << dstate[k] << ",a)=" << dfa[k][0];
        cout << "\nf(" << dstate[k] << ",b)=" << dfa[k][1];

        // Add new DFA states
        for (int j = 1; j < i; j++)
        {
            if (dfa[k][0] != dstate[j])
                dstate[i++] = dfa[k][0];
            if (dfa[k][1] != dstate[j])
                dstate[i++] = dfa[k][1];
        }
        k++;
    }

    return 0;
}

