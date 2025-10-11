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
 string number;
do
{
    Console.Write("Podaj liczbę: ");
    int.TryParse(Console.ReadLine(), out number);
}
while (number >= 0);
Console.WriteLine("Prawidłowa liczba!");
*/

/* ZADANIE 3 
string[] cities = { "Poznań", "Warszawa", "Gniezno", "Gdańsk", "Kraków" };
foreach (var city in cities)
{
    Console.WriteLine(city);
}
*/

/* ZADANIE 4 */


/* ZADANIE 5 */


/* ZADANIE 6 */


/* ZADANIE 7 */
