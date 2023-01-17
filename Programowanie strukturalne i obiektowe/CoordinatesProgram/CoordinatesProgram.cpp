
#include <iostream>
using  namespace std;

struct Podouble calculatedDistance(Point p)
{
	double distance =sqrt(p.x * p.x + p.y * p.y);
	return distance;
}
int Point;
{
	int x;
	int y;
};

double calculatedDistance(int a, int b)
{
	return sqrt(a * a + b * b);
}

double calculatedDistance(Point p)
{
	double distance =sqrt(p.x * p.x + p.y * p.y);
	return distance;
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

	cout << "odleglosc to:  " << calculatedDistance(userPoint.x, userPoint.y) << endl;
}

struct Person
{
	string name;
	string surname;
	int age;
	int hight;
};

Person pl;
//pl.name

string nameTab[5];
string surnameTab[5];
int age[5];
int hight[5];

Person pTab[5];
////pTab[1].name = "Ala";

int main()
{
	CoordinateTestVersion();
}

