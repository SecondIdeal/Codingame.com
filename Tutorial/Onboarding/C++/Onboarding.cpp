#include <iostream>

using namespace std;

int main()
{
	while (1) {
		string enemy1Name; 
		cin >> enemy1Name; cin.ignore();
		int enemy1Distance; 
		cin >> enemy1Distance; cin.ignore();
		string enemy2Name; 
		cin >> enemy2Name; cin.ignore();
		int enemy2Distance; 
		cin >> enemy2Distance; cin.ignore();

		cout << ((enemy1Distance < enemy2Distance) ? enemy1Name : enemy2Name) << endl;
	}
}