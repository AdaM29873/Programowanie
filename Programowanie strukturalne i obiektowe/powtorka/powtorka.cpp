
#include <iostream>
#include <math.h>
using namespace std;


void showMenu()
{
	system("cls");

	
	cout << "Menu" << endl;
	cout << "1. oblicz pole kwadratu" << endl;
	cout << "2. pole trojkata" << endl;
	cout << "3. nieparzyste liczby od tej liczby" << endl;
	cout << "4. wszystkie dzielniki podanej liczby liczby" << endl;
	cout << "5.czyta liczbe podana przez ciebie" << endl;
	cout << "6.ciag liczb fibbonachiego w ilosci podanej liczby  " << endl;
	cout << "7.przelicza na binarne" << endl;
	cout << "8.przelicza na jakie nomina³y mozesz wydac dane pieniadze w z³" << endl;
}

int  chooseOption()
{
	int selectedOption;

	cout << " Wybierz opcje " << endl;
	cin >> selectedOption;

	return selectedOption;


	

}

void nominaly()
{
	int pieniadz;
	
	int nominal[9]{5,2,1,0.5,0.2,0.1,0.05,0.02,0.01};
	int ilosc[9];
	cout << "Podaj liczbe" << endl;
	cin >> pieniadz;

	for(int i = 0; pieniadz != 0 ;i++)
	{
		
		
		 ilosc[i] = floor(pieniadz / nominal[i]); 
		 pieniadz = pieniadz % nominal[i];
		 cout << nominal[i]<< "  *  " << ilosc[i] << endl;
		 

	}

	


}



void fibbonachi()
{
	int currentNumber=0, prevOneNumber=0, prevTwoNumber=1;
	int number;

	cout << "Podaj liczbe" << endl;
	cin >> number;
	 
	for (int i = 0; i < number; i++)
	{
		currentNumber = prevOneNumber + prevTwoNumber;
		cout << currentNumber << ", ";

		prevTwoNumber = prevOneNumber;
		prevOneNumber = currentNumber;
	}

	
	 


}



void liczbaCzytana()
{
	string liczbaDoPrzeczytania;
	cout << "podaj liczbe" << endl;
	cin >> liczbaDoPrzeczytania;

	for (int i = 0; i < liczbaDoPrzeczytania.length(); i++)
	{
		if (liczbaDoPrzeczytania[i] == '0')
			cout << "zero  ";

		if (liczbaDoPrzeczytania[i] == '1')
			cout << "jeden  ";

		if (liczbaDoPrzeczytania[i] == '2')
			cout << "dwa  ";

		if (liczbaDoPrzeczytania[i] == '3')
			cout << "trzy  ";

		if (liczbaDoPrzeczytania[i] == '4')
			cout << "cztery  ";


		if (liczbaDoPrzeczytania[i] == '5')
			cout << "piec ";


		if (liczbaDoPrzeczytania[i] == '6')
			cout << "szesc  ";

		if (liczbaDoPrzeczytania[i] == '7')
			cout << "siedem  ";

		if (liczbaDoPrzeczytania[i] == '8')
			cout << "osiem  ";

		if (liczbaDoPrzeczytania[i] == '9')
			cout << "dziewiêæ";
	}
}
void dzielniki()
{
	int podanaLiczba;
	cout << "podaj liczbe" << endl;
	cin >> podanaLiczba;
	int i = 1;
	int dzielnik = podanaLiczba;
	while (dzielnik >= i)
	{
		if (podanaLiczba % dzielnik == 0) //reszta = 0
		{
			cout << dzielnik << ",";
		}
		dzielnik--;
	}


}

void binarnie()
{
	 int table[32], number, i;

	cout << "Podaj liczbe ktora mam przeliczyc ma binarn¹" << endl;
	cin >> number;

	for (i = 0; number != 0; i++)
	{
		table[i] = number % 2;
		number = number / 2;

	}

	do
	{
		i--;
		cout << table[i];
		
	} while(i != 0);
	cout << endl;
			
	

	
	
	
	
	
	
	
	
	
	/*do
	{
		if (number % 2 != 0)
		{
			cout << "1";
		}
		else 
		{
			cout << "0";
		}
		number=number/2;

	} while (number != 0); 

	cout << endl;
	*/
	

}

void nieparzysteLiczby()
{
	int liczbaPodana;
	int i = 0;
	cout << "Podaj liczbe od ktorej mam wyswietlic liczby nieparzyste do 1" << endl;
	cin >> liczbaPodana;

	int nieParzysta = liczbaPodana;


	while (nieParzysta != i)
	{
		if (nieParzysta % 2 != 0)
		{
			cout << nieParzysta << ",";
		}
		nieParzysta--;
	}







}

void pole3kata()
{
	int a, h;
	cout << "podaj podstawe" << endl;
	cin >> a;
	cout << "podaj wysokosc" << endl;
	cin >> h;

	int wynik = a * h / 2;
	cout << "wynik: " << wynik << "            ";


}

void poleKwadratu()
{
	int a;
	cout << "podaj bok" << endl;
	cin >> a;

	int area = a * a;
	cout << "wynik: " << area << "             ";


}

void doSelectedTask(int selectedOption)
{
	switch (selectedOption)
	{
	case 1:
		poleKwadratu();
		break;
	case 2:
		pole3kata();
		break;
	case 3:
		nieparzysteLiczby();
		break;
	case 4:
		dzielniki();
		break;
	case 5:
		liczbaCzytana();
		break;
	case 6:
		fibbonachi();
		break;
	case 7:
		binarnie();
		break;
	case 8:
		nominaly();
		break;
	case 0:
		return;

	default:
		cout << "brak opcji w menu" << endl;
		break;
	}


	system("pause");

}






void mainProgram()
{
	int selected;
	system("COLOR 0F");

	do
	{
		//1. wyswietlenie menu
		showMenu();

		//2. wybranie opcji przez uzytkownika
		selected = chooseOption();
		system("cls");
		//3. wykonanie wybranego zadania
		doSelectedTask(selected);

	} while (selected != 0);
}

void main()
{

		mainProgram();







}






