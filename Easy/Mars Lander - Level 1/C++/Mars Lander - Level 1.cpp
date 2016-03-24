#include <iostream>

using namespace std;

int main()
{
	int numberOfSurfacePoints; // used to draw the surface of Mars
	cin >> numberOfSurfacePoints; cin.ignore();
	for (int i = 0; i < numberOfSurfacePoints; i++) {
		int surfaceCoordinateX; // 0 to 6999
		int surfaceCoordinateY; // 0 to 2999
		cin >> surfaceCoordinateX >> surfaceCoordinateY; cin.ignore();
	}

	while (1) {
		int landerCoordinateX; // in meters
		int landerCoordinateY; // in meters
		int horizontalSpeed; /// in m/s, can be negative
		int verticalSpeed; // in m/s, can be negative
		int fuelRemainig; // in liters
		int rotationAngle; // in degrees (-90 to 90)
		int thrustPower; // 0 to 4
		cin >> landerCoordinateX >> landerCoordinateY >> horizontalSpeed >> verticalSpeed >> fuelRemainig >> rotationAngle >> thrustPower; cin.ignore();

		cout << "0 " << ((abs(verticalSpeed) > 39) ? "4" : "0") << endl;
	}
}