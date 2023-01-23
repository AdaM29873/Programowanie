
#include <iostream>
using namespace std;
#include <ctime>

/*
Napisz klasę opisującą osobę oraz kod testujący, wyświetli czy osoba jest pełnoletnia
- dodaj 5 pól opisujących osobę( wiek, imie, nazwisko, nr. pesel, miasto 
*/

class Osoba
{
public:

    Osoba(string nAme, string sUrname, string cIty, string pEselNumber, int bIrthYear)
    {
        this->name = nAme; 
        this->surName = sUrname;
        this->city = cIty; 
        this->peselNumber = pEselNumber;
        this->birthYear = bIrthYear;


    }
    void pelnoLetni()
    {

        bool wynik = year() - this->birthYear;

        if (year() - this->birthYear < 18)
            wynik = false;
        else
            wynik = true;
        if (wynik = 0)
            cout << "Is the person adult: " << "yes " << endl;
        else
            cout << "Is the person adult: " << "no " << endl;
    }

    Osoba(string nAme, string sUrname, string cIty)
    {
        this->name = nAme;
        this->surName = sUrname;
        this->city = cIty;
        this->peselNumber = 123456789;
        this->birthYear = year();
    }

    void showInfo()
    {
        time_t now = time(0);
        tm* ltm = new tm;
        localtime_s(ltm, &now);
        cout << "//////////////////////////////////////////////////" << endl;
        cout << "Imie i nazwisko: " << this->name << " " << this->surName << "   /   ";
        cout << "Miasto: " << this->city << endl;
        cout << "Numer pesel: "<< this->peselNumber << endl;
        cout << "Twoj wiek: " << year() - this->birthYear << endl;
    }
private:
    string  name, surName,city;
    string peselNumber;
    int birthYear;
   
    int year()
    {
        time_t now = time(0);
        tm* ltm = new tm;
        localtime_s(ltm, &now);
        return  1900 + ltm->tm_year;
    }

protected:
};







int main()
{

    string nAme, sUrname, cIty, pEselNumber;
    int bIrthYear;
    cout << " podaj imie:" << endl;
    cin >> nAme;
    cout << " podaj nazwisko :" << endl;
    cin >> sUrname;
    cout << " podaj date urodzenia :" << endl;
    cin >> bIrthYear;
    cout << " podaj nr pesel :" << endl;
    cin >> pEselNumber;
    cout << " podaj miasto :" << endl;
    cin >> cIty;

   // Osoba firstPerson(nAme, sUrname, cIty, pEselNumber, bIrthYear);
    Osoba firstPerson9(nAme, sUrname, cIty);
   // firstPerson.showInfo();
    firstPerson9.showInfo();
    firstPerson9.pelnoLetni();
}

