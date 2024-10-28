/*sting validation of that the sting is valid or not */
#include<iostream>
using namespace std;
int main ()
{
    string input; /// To take the string
    bool isvalid=true; /// For validation
    cout<<"Please enter a string to check the validation:"<<endl; /// cout news for validation
    getline(cin,input); /// To Check all the lines with all of special one words like -_*&^%$#@!
    if(!((input[0]>='A'&&input[0]<='Z')||(input[0]>='a'&&input[0] <='z')||input[0]=='_')){
        isvalid = false; /// this one is main
    }
    for(int i=1;i<input.size();++i){
        if(!((input[i]>='A'&&input[i]<='Z')||(input[i]>='a'&&input[i] <='z')||(input[i]>='0'&&input[i]<='9')||input[i]=='_'))
        {
            isvalid=false; /// this one is for loop
            break;
        }
    }

    ///to print the full function
    if(isvalid){
        cout<<input <<" is a valid string "<<endl; /// to print the strings
    }
    else{
        cout<< input <<" is not a valid string "<<endl;
    }
    return 0;
}
