#include<bits/stdc++.h>
using namespace std;
int main(){
    
ifstream file("C://Users//shadm//Desktop//Compiler_design//Compiler-Design//task-5.txt");
string line;
bool insidemultilinecomment = false;
int linenumber=0;
stack<char>brackets;
if(!file.is_open()){
    cerr<<"could not find or open the file"<<endl;
    return 1;
}
while(getline(file, line)){
    linenumber++;
    char lastChar = line[line.size()-1];
    if(lastChar !=';' && lastChar !='{' && lastChar !='}' && lastChar!='<'&& lastChar!='>'){
        cout<<"There is a missing ';' to finish the code line"<<linenumber<<": "<<line<<endl;

    }
}
}