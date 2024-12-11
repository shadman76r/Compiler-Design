#include <iostream>
using namespace std;

int main() {
    int totalClasses;
    int attendedClasses;
    float attendancePercentage;

    cout<<"Enter the total number of classes held:";
    cin>>totalClasses;

    cout<<"Enter the number of classes attended: ";
    cin>>attendedClasses;

    attendancePercentage=(attendedClasses / (float)totalClasses)*100;
    cout<<"Attendance percentage: "<<attendancePercentage<<"%"<< endl;

    if(attendancePercentage>=80)
    {
        cout<<"The student is allowed to sit for the exam."<< endl;
    } else
    {
        cout<<"The student is not allowed to sit for the exam."<< endl;
    }
    return 0;
}

