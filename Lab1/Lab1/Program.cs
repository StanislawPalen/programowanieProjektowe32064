using System;
/* ZADANKO ze sklepem
 const int requiredAge = 16;
const int beerRequiredAge = 18;

const string accessDeniedMessage = "You must be at least 16 years old.";
const string accessAllowedMessage = "Welcome to my shop.";
const string beerRestrictionMessage = "You must be 18 years old to buy a beer.";

int age = 14;

if (age < requiredAge)
{
    if (age >= 14)
    {
        Console.WriteLine($"{accessAllowedMessage} {beerRestrictionMessage}");
    }
    else
    {
        Console.WriteLine(accessDeniedMessage);
    }
}
else if (age < beerRequiredAge)
{
    Console.WriteLine(accessAllowedMessage);
}
else
{
    Console.WriteLine($"{accessAllowedMessage} {beerRestrictionMessage}");
}
*/

/* ZADANIE 1
 string password;
do
{
    Console.Write("Podaj hasło: ");
    password = Console.ReadLine();
}
while (password != "admin123");
Console.WriteLine("Zalogowano pomyślnie!");
*/

/* ZADANIE 2 
int number;
do
{
    Console.Write("Podaj liczbę: ");
    int.TryParse(Console.ReadLine(), out number);
}
while (number <= 0);
Console.WriteLine("Prawidłowa liczba!");
*/

/* ZADANIE 3 
string[] cities = { "Poznań", "Warszawa", "Gniezno", "Gdańsk", "Kraków" };
foreach (var city in cities)
{
    Console.WriteLine(city);
}
*/

/* ZADANIE 4 

class Osoba{
    public string Imie;
    public int Wiek;
    public void PrzedstawSie(){
        Console.WriteLine($"Jestem {Imie} i mam {Wiek} lat!");
    }
}
class Program {
    static void Main() {
        Osoba osoba1 = new Osoba();
        osoba1.Imie = "Jan";
        osoba1.Wiek = 25;
        osoba1.PrzedstawSie();
    }
}
*/

/* ZADANIE 5 */
class KontoBankowe{
    private double saldo;
    public void Wplata(double kwota) { saldo += kwota; }
    public double PobierzSaldo() { return saldo; }
    public void Wyplata(double kwota) {
        if(kwota <= saldo){
            saldo -= kwota;
        } else {
            Console.WriteLine("Niewystarczające środki na koncie.");
        }
    }
}

class Program {
    static void Main() {
        KontoBankowe mojeKonto = new KontoBankowe();
        mojeKonto.Wplata(1000);
        Console.WriteLine($"Saldo po wpłacie: {mojeKonto.PobierzSaldo()}");
        mojeKonto.Wyplata(500);
        Console.WriteLine($"Saldo po wypłacie: {mojeKonto.PobierzSaldo()}");
        mojeKonto.Wyplata(600); // Próba wypłaty większej kwoty niż saldo
    }
}

/* ZADANIE 6 */


/* ZADANIE 7 */

/* ZADANIE 8 */
