#include <iostream>
#include <vector>

using namespace std;

int main()
{
	int countOfTemperatures; // the number of temperatures to analyse
	cin >> countOfTemperatures; cin.ignore();

	if (countOfTemperatures == 0)
		cout << "0" << endl;
	else
	{
		vector<int> tempsVector;
		for (int i = 0; i < countOfTemperatures; i++)
		{
			int temp;
			cin >> temp;
			tempsVector.push_back(temp);
		}

		int nearestToZero = 5527;	
		for (int i = 0; i < countOfTemperatures; i++)
		{
			nearestToZero =
				abs(tempsVector[i]) < abs(nearestToZero) ? tempsVector[i] :
				abs(tempsVector[i]) > abs(nearestToZero) ? nearestToZero :
				tempsVector[i] > nearestToZero ? tempsVector[i] : nearestToZero;
		}
		cout << nearestToZero << endl;
	}
}