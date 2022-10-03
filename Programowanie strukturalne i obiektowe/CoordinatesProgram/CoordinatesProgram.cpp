#include <iostream>
using  namespace std;

struct Point
{
	int x;
	int y;
}

double calculatedDistance(int a, int b)
{
	return sqrt(a * a + b * b);
}



void CoordinateTestVersion()
{
	int x, y;
	// stworzona zmienna typu Point
	Point point;

	cout << "Podaj x" << endl;
	cin >> x;
	cout << "Podaj y" << endl;
	cin >> y;

	double distance = sqrt(x * x + y * y);

	cout << "odleglosc to:  " << calculatedDistance(x, y) << endl;

}


void CoordinateTestVersion2()
{
	Point userPoint;
	// stworzona zmienna typu Point
	
	cout << "Podaj x" << endl;
	cin >> userPoint.x;
	cout << "Podaj y" << endl;
	cin >> userPoint.y;

	//double distance = sqrt(userPoint.x * userPoint.x + userPoint.y * userPoint.y);

	cout << "odleglosc to:  " << calculatedDistance(userPoint.x,userPoint.y) << endl;

}





int main()
{
	CoordinateTestVersion();
}

