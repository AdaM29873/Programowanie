

#include <iostream>
using namespace std;


/*
Zadania:
* Napisz funkcję, która dla kolekcji danych liczbowych obliczy średnią arytmetyczną.
* Napisz funkcję, która dla kolekcji danych liczbowych policzy ile jest liczb większych od średniej arytmetycznej.
* Napisz funkcje, która dla kolekcji danych liczbowych przeniesie te liczby do innej kolekcji w odwrotnej kolejności.
* Napisz funkcje, która dla kolekcji danych liczbowych obliczy częstotliwość występowania danej liczby.
* Napisz funkcję, która dla kolekcji danych liczbowych znajdzie najdłuższy rosnący podciąg.
* Napisz funkcję, która dla kolekcji danych liczbowych przeniesie te liczby do osobnych kolekcji liczb parzystych i nieparzystych.
*
*/


int zad_1(int size,int tab[])
{	
	
	
	int sum = 0;

	//średnia

	for (int i = 0; i < size; i++)
	{
		sum = sum + tab[i];
	}
	std::cout << "suma: " << sum <<endl;
	int average = sum / size;
	cout << "srednia: " << average;
	std::cout << "\n";
	int main(average);
}

//Napisz funkcję, która dla kolekcji danych liczbowych policzy ile jest liczb większych od średniej arytmetycznej.
void zad_2(int size, int tab[])
{
	
}

int main()
{ 
	const int  lengh_of_table = 10;
	int numbers[lengh_of_table];
	int min = 4;
	int max = 30;

	srand(time(NULL));

	for (int i = 0; i < lengh_of_table; i++)
	{
		//zakres <zakresDolny; zakresGorny>
		numbers[i] = rand() % (max - min + 1) + min;
	}

	for (int i = 0; i < lengh_of_table; i++)
	{
		std::cout << numbers[i] << ", ";
	}

	std::cout << "\n";
	zad_1(lengh_of_table,numbers);
	zad_2(lengh_of_table,numbers);
}
