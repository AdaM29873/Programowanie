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

    return selectedOption;

    

}
 
void pole3kata()
{
    int a, h;
    cout << "podaj podstawe" << endl;
    cin >> a;
    cout << "podaj wysokosc" << endl;
    cin >> h;

    int wynik = a * h / 2;
    cout << "wynik: " << wynik;


}

void poleKwadratu()
{
    int a, b;
    cout << "podaj bok" << endl;
    cin >> a;
    
    int area = a * a;
    cout << "wynik: " << area;


}

void doSelectedTask(int selectedOption)
{
    if (selectedOption == 1)
    {
        poleKwadratu();
    }
    if (selectedOption == 2)
    {
        pole3kata();
    }
}






void mainProgram()
{
    //1. wyswietlenie menu
    showMenu();
    //2. wybranie opcji przez uzytkownika
    int selected = chooseOption();
    //3. wykonanie wybranego zadania
    doSelectedTask(selected);
}

void main()
{
    mainProgram();
    

    

    
}






