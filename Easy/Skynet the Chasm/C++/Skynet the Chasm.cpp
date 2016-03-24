#include <iostream>

using namespace std;

int main()
{
	int lenghtOfRoad;
	cin >> lenghtOfRoad; cin.ignore();
	int lenghtOfGap;
	cin >> lenghtOfGap; cin.ignore();
	int lenghtOfPlatform;
	cin >> lenghtOfPlatform; cin.ignore();

	while (1) {
		int motorbikeSpeed;
		cin >> motorbikeSpeed; cin.ignore();
		int motorbikePosition;
		cin >> motorbikePosition; cin.ignore();

		cout <<
			(motorbikePosition > lenghtOfRoad || motorbikeSpeed > lenghtOfGap + 1 ? "SLOW" :
			motorbikeSpeed < lenghtOfGap + 1 ? "SPEED" :
			motorbikePosition == lenghtOfRoad - 1 ? "JUMP" : "WAIT")
			<< endl;
	}
}