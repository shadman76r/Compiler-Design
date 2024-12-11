#include <iostream>
using namespace std;
int main() {
    int NUM_ATHLETES = 10;
    int scores[NUM_ATHLETES];
    int sum = 0;
    int aboveAverageCount = 0;
    cout << "Enter scores of 10 athletes to check the average:" << endl;
    for (int i = 0; i < NUM_ATHLETES; ++i)
    {
        cin >> scores[i];
        sum += scores[i];
    }

    float average = sum / (float)NUM_ATHLETES;
    if (average > 85)
    {
        cout << "Overall Outstanding Performance" << endl;
    }
    else if (average >= 70 && average <=84)
    {
        cout << "Overall Good Performance" << endl;
    }
    else
    {
        cout << "Overall Improvement Needed" << endl;
    }
    for (int i = 0; i < NUM_ATHLETES; ++i)
    {
        if (scores[i] > average)
            aboveAverageCount++;
    }

    cout << "Number of athletes scoring above average: " << aboveAverageCount << endl;
    if (aboveAverageCount > NUM_ATHLETES / 2)
        cout << "Individual Performance is Good" << endl;
    else
        cout << "Individual Improvement Needed" << endl;

    return 0;
}

