#include<iostream>
using namespace std;
int main()
{
    cout<<"Please enter something to check if the given charater is vowel or consonenet or and digit"<<endl;
    char inp;
    cin>>inp;
    if('a'<=inp && 'z'>=inp)
    {
        if(inp=='a'||inp=='e'||inp=='i'||inp=='o'||inp=='u')
        {
            cout<<"Lowercase Vowels"<<endl;
        }
        else{
            cout<<"Lowercase consonent"<<endl;
        }
    }
    else if ('A'<=inp && 'Z'>=inp)
    {
        if(inp=='A'||inp=='E'||inp=='I'||inp=='O'||inp=='U')
        {
            cout<<"Uppercase Vowels"<<endl;
        }
        else{
            cout<<"Uppercase consonent"<<endl;
        }
    }
    else if('0'<=inp && '9'>=inp)
    {
        cout<<"This is the digit"<<endl;
    }
    else{
        cout<<"Special Characters"<<endl;
    }
    return 0;
}