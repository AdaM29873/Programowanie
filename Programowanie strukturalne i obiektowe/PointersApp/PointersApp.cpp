using namespace std;
#include <iostream>

int globalvariable = 7;

void anotherFunction(int parameter)
{
	parameter = 12;
	int anotherLocalVariableInFunction = 6;
}

void testFunction()
{
int localVariableInFunction = 5;
anotherFunction(localVariableInFunction);
}



int main()
{
	/*int localVariableInFunction = 8;
	testFunction();*/

	/*Stos - obszar pamieci Ram przydzielony naszemu programowi.
	Obszar ten jest ograniczony i nie da sie go zwiekszyc w 
	czasie działania programu.Lądują tam zmienne lokalne.
	*/


	int number;
	number = 77;
	cout << number;


	//sterta - pozostały wolny obaszar pamieci RAM

	// deklaracja zmiennej lokalnej
	int* wsk;

	wsk = new int;
	*wsk = 7;
	//wyswietlanie adresu pod jakim znajduje sie obszar na stercie
	cout << wsk << endl;
	cout << *wsk << endl;


}