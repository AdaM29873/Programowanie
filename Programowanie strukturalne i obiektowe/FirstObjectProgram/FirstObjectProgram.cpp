#include <iostream>
using  namespace std;

struct gps
{
	int x, y;
};
struct Direction
{
	int x, y;
};
class Point
{
public:
	Point()
	{
		
		x = 0;
		y = 0;
	}
	Point(int x,int y)
	{
		//konstruktor - metod, ktora jest wywoływana podczas tworzenia obiektu
		this->x = 0;
		this->y = 0;
	}
	double	CalculatedDistance(Point p)
	{
		double distance = sqrt(p.x * p.x + p.y * p.y);
		return distance;
	}
	void setX(int x)
	{
		//zakładamy ze jestesmy tylko w 1/4 układu współrzędnych
		if (x >= 0)
		{
			this->x = x;
		}
	}
	void setX(int y)
	{
		//zakładamy ze jestesmy tylko w 1/4 układu współrzędnych
		if (y >= 0)
		{
			this->y = y;
		}//poprzez this-> bierzemy "y" oraz "x"  z prywatnej class'y
	}

private:
	int x;
	int y;
};

int main()
{
	Point point;
	point.x(10);
	point.y(15);
	double distance = point.CalculatedDistance(point);
	cout << "Dystans  od punktu (0;0) = " << distance << "\n";
}