#include<iostream>
using namespace std;
int main()
{
    int arr[10]={1,2,3,5,4,6,9,7,8,9};
    int evenCount=0;
    int oddCount=0;
    for(int i=0; i<10; i++)
    {
        if(arr[i]%2==0)
        {
            evenCount++;
        }
        else
        {
            oddCount++;
        }
    }
    cout<<"Even number"<<evenCount<<endl;
    cout<<"Odd number"<<oddCount<<endl;
    return 0;
    
}