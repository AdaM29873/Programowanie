#include <iostream>
using namespace std;

void showMenu()
{
    system("cls");
    cout << "Menu" << endl;
    cout << "1. oblicz pole kwadratu" << endl;
    cout << "2. pole trojkata" << endl;

}

int  chooseOption()
{
    int selectedOption;
    
    cout << " Wybierz opcje " << endl;
    cin >> selectedOption;

    

}
 
void doSelectedTask()
{
    if (selectedOption == 1)
    {
        poleKwadratu();
    }
    if (slectedOption == 2)
    {
        pole3kata();
    }
}


void pole3kata()
{
    int a, b;
    cout << "podaj podstawe" << endl;
    cin >> a;
    cout << "podaj wysokosc" << endl;
    cin >> b;

    cout << "wynik" << a * b / 2;


}

void poleKwadratu()
{
    int a, b;
    cout << "podaj pierwszy bok" << endl;
    cin >> a;
    cout << "podaj drugi bok" << endl;
    cin >> b;

    cout << "wynik" << a * b;


}



void mainProgram()
{
    //1. wyswietlenie menu
    showMenu();
    //2. wybranie opcji przez uzytkownika
    chooseOption();
    //3. wykonanie wybranego zadania
    doSelectedTask();
}

void main()
{
    mainProgram();
    

    

    
}






