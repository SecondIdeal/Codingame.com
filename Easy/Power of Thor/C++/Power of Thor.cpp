#include <iostream>

using namespace std;

int main()
{
	int lightX;
	int lightY;
	int thorX;
	int thorY;
	cin >> lightX >> lightY >> thorX >> thorY; cin.ignore();

	while (1) {
		string directionX = "";
		string directionY = "";

		if (thorX < lightX)
		{
			directionX = "E";
			thorX++;
		}
		else if (thorX > lightX)
		{
			directionX = "W";
			thorX--;
		}

		if (thorY < lightY)
		{
			directionY = "S";
			thorY++;
		}
		else if (thorY > lightY)
		{
			directionY = "N";
			thorY--;
		}

		cout << directionY << directionX << endl;
	}
}