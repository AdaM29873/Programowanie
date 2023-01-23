
using namespace std;
#include <iostream>
#pragma region auto
struct Direction
{
	int x,y;
};

struct Coordinates
{
	int x, y;
};

class Car
{
public:

	//konstruktor zawsze nazywa sie tak jak klasa ->, jest to specjalna metoda bez typu zwracanego,
	//wywolywana podczas tworzenia obiektu
#pragma region auta 
	Car(string name)
	{
		this->name = name;
		gps.x = 0;
		gps.y = 0;
		direction.x = 1;
		direction.y = 0;
	}

	Car(string name, int x, int y)
	{
		this->name = name;
		gps.x = x;
		gps.y = x;
		direction.x = 1;
		direction.y = 0;
	}
#pragma endregion
	void showInfo()
	{
		cout << "***************************" << endl;
		cout << "samochod o nazwie  " << name << endl;
		cout << "pozycja (" << gps.x << ";" << gps.y << ")" << endl;
		cout << "******************************" << endl;

	}
#pragma region turnMethod
	void MoveForward()
	{
		gps.x += direction.x;
			gps.y += direction.y;
	}
	void TurnRight()
	{
		/*if (direction.x == 1 && direction.y == 0)
		{
			direction.x = 0;
			direction.y = 1;
		}
		else if (direction.x == 0 && direction.y == 1)
		{
			direction.x = -1;
			direction.y = 0;
		}
		else if (direction.x == -1 && direction.y == 0)
		{
			direction.x = 0;
			direction.y = -1;
		}
		else if (direction.x == 0 && direction.y == -1)
		{
			direction.x = 1;
			direction.y = 0;
		}
		*/
		int tmpX = direction.x;
		direction.x = -direction.y;
		direction.y = tmpX;
	}
	void TurnLeft()
	{
		if (direction.x == 1 && direction.y == 0)
		{
			direction.x = 0;
			direction.y = -1;
		}
		else if (direction.x == 0 && direction.y == 1)
		{
			direction.x = 1;
			direction.y = 0;
		}
		else if (direction.x == -1 && direction.y == 0)
		{
			direction.x = 0;
			direction.y = 1;
		}
		else if (direction.x == 0 && direction.y == -1)
		{
			direction.x = -1;
			direction.y = 0;
		}
	}
	void MoveBack()
	{
		TurnLeft();
		TurnRight();
	}
#pragma endregion
protected:

private:
	string name;

	Coordinates gps;

	Direction direction;
};


int main()
{
	setlocale( LC_CTYPE, "polish");
	Car car("SusBus");
	Car carSecond("BigC", 10, 10);

	car.showInfo();
	carSecond.showInfo();

	car.MoveForward();
	
}

#pragma endregion

