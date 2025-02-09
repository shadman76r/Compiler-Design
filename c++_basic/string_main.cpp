
#include <iostream>
using namespace std;

int main()
{

	char s1[] = { 's', 'c', 'h', '\0' };
	char s2[4] = { 's', 'c', 'h', '\0' };
	char s3[4] = "sch";
	char s4[] = "sch";

	cout << "s1 = " << s1 << endl;
	cout << "s2 = " << s2 << endl;
	cout << "s3 = " << s3 << endl;
	cout << "s4 = " << s4 << endl;

	return 0;
}
 