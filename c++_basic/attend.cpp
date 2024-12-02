#include <iostream>
using namespace std;

int main() {
    int totalClasses, attendedClasses;
    cout << "Enter the total number of classes held: ";
    cin >> totalClasses;

    cout << "Enter the number of classes attended by the student: ";
    cin >> attendedClasses;

    float attendancePercentage = (float(attendedClasses) / totalClasses) * 100;

    cout << "Attendance Percentage: " << attendancePercentage << "%" << endl;

    if (attendancePercentage < 80.0) {
        cout << "Not Allowed" << endl;
    } else {
        cout << "Allowed" << endl;

        if (attendancePercentage == 100.0) {
            cout << "Bonus: You get 2 extra marks!" << endl;
        }
    }

    return 0;
}