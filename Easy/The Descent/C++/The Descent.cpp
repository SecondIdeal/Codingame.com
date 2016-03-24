#include <iostream>

using namespace std;

int main()
{
	while (1) {
		int maxMountainHeight = 0;
		int indexOfHighestMountain = 0;

		for (int i = 0; i < 8; i++) {
			int mountainHeight;
			cin >> mountainHeight; cin.ignore();

			if (mountainHeight > maxMountainHeight)
			{
				maxMountainHeight = mountainHeight;
				indexOfHighestMountain = i;
			}
		}
		cout << indexOfHighestMountain << endl;
	}
}