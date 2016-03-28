#include <iostream>

using namespace std;

int main()
{
	int buldingWidth;
	int buldingHeight;
	cin >> buldingWidth >> buldingHeight; cin.ignore();
	int maxTurnsBeforeGameOver;
	cin >> maxTurnsBeforeGameOver; cin.ignore();
	int batmanPositionX;
	int batmanPositionY;
	cin >> batmanPositionX >> batmanPositionY; cin.ignore();

	// Coordinates of new window from min to max
	int minX = 0, maxX = buldingWidth - 1, minY = 0, maxY = buldingHeight - 1;

	while (1) {
		string bombDirectionFromCurrentLocation; // U, UR, R, DR, D, DL, L or UL
		cin >> bombDirectionFromCurrentLocation; cin.ignore();

		if (bombDirectionFromCurrentLocation.find('L') != std::string::npos)
			maxX = batmanPositionX - 1;
		else if (bombDirectionFromCurrentLocation.find('R') != std::string::npos)
			minX = batmanPositionX + 1;

		if (bombDirectionFromCurrentLocation[0] == 'U')
			maxY = batmanPositionY - 1;
		else if (bombDirectionFromCurrentLocation[0] == 'D')
			minY = batmanPositionY + 1;

		batmanPositionX = (minX + maxX) / 2;
		batmanPositionY = (minY + maxY) / 2;

		cout << batmanPositionX << " " << batmanPositionY << endl;
	}
}