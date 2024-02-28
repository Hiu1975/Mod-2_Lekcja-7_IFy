// Zadanie 1

Console.WriteLine("Algorytm porównujący dwie liczby a i b");
Console.WriteLine("Podaj liczbę a");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj liczbę b");
int numberB = int.Parse(Console.ReadLine());
string result = (numberA == numberB) ? $"{numberA} i {numberB} są równe" : $"{numberA} i {numberB} nie są równe";
Console.WriteLine(result);

// Zadanie 2

Console.WriteLine("Algorytm spr. czy liczba jest parzysta lub nieparzysta");
Console.WriteLine("Podaj liczbę");
int number = int.Parse(Console.ReadLine());
string oddEven;
oddEven = (number % 2 == 0 ? "jest parzysta" : "jest nieparzysta");
Console.WriteLine($"liczba {number} {oddEven}");

// Zadanie 3

Console.WriteLine("Algorytm spr. czy liczba jest dodatnia czy ujemna");
Console.WriteLine("podaj liczbę");
double positiveNegative = double.Parse(Console.ReadLine());
if (positiveNegative == 0)

    Console.WriteLine("Podałeś 0, zero nie jest ani dodatnią, ani ujemną liczbą");

else if (positiveNegative > 0)
{
    Console.WriteLine($"Liczba {positiveNegative} jest dodatnia");
}
else
{
    Console.WriteLine($"Liczba {positiveNegative} jest ujemna");
}

// Zadanie 4

Console.WriteLine("Algorytm spr. czy podany rok jest przestępny");
Console.WriteLine("podaj rok");
int leapYearYesNo = int.Parse(Console.ReadLine());
if ((leapYearYesNo % 4 == 0 && leapYearYesNo % 100 != 0) || leapYearYesNo % 400 == 0)
{
    Console.WriteLine($"Rok {leapYearYesNo} jest rokiem przestępnym");
}
else
{
    Console.WriteLine($"Rok {leapYearYesNo} nie jest rokiem przestępnym");
}

// Zadanie 5

Console.WriteLine("Algorytm spr. czy podany wiek uprawnia do kandydowania na prominetne stołki państwowe");
Console.WriteLine("Podaj swój wiek");
int userAge = int.Parse(Console.ReadLine());
string status;
status = userAge switch
{
    >= 18 and < 21 => "premiera",
    >= 21 and < 30 => "posła",
    >= 31 and < 35 => "senatora",
    >= 35 => "prezydenta",
    _ => "przewodniczącego klasowego conajwyżej"
};
Console.WriteLine($"Możesz kandydować na {status}.");

// Zadanie 6

Console.WriteLine("Program przypisuje Ci kategorie w zależności od wzrostu");
Console.WriteLine("Podaj swój wzrost w cm");
int height = int.Parse(Console.ReadLine());
string category = "";
kategoria = height switch
{
    < 110 => "kurduplem",
    >= 110 and <= 140 => "karłem",
    >= 141 and <= 175 => "średniego wzrostu",
    >= 176 and <= 199 => "wysoki",
    _ => "mutantem, normalni ludzie tacy nie rosną"
};
Console.WriteLine($"Jesteś {category}.");


// Zadanie 7

Console.WriteLine("Algorytm spr., która z 3 podanych liczb jest największa");
Console.WriteLine("Podaj 3 liczby x,y,z");
int x, y, z;
x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());
z = int.Parse(Console.ReadLine());

int maksimum = x;
if (y >= maksimum)
{
    maksimum = y;
}
else if (z >= maksimum)
{
    maksimum = z;
}
Console.WriteLine($"Największą liczbą spośród [{x}, {y}, {z}] jest liczba {maksimum}");

// Zadanie 8

Console.WriteLine("Algorytm spr., czy kandydat może ubiegać się o miejsce na studiach ");
Console.WriteLine("Podaj swój wynik z Matury z przedmiotów: ");
Console.WriteLine("Matematyki = ");
int mathematics = int.Parse(Console.ReadLine());
Console.WriteLine("Fizyki =");
int physics = int.Parse(Console.ReadLine());
Console.WriteLine("Chemii =");
int chemistry = int.Parse(Console.ReadLine());

if (((mathematics > 70 && physics > 55 && chemistry > 45) && (mathematics + physics + chemistry > 180)) 
    || (mathematics + physics > 150 || mathematics + chemistry > 150))
{
    Console.WriteLine("Kandytat dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine("NIE zostałeś dopuszczony");
}


// Zadanie 9


Console.WriteLine("Program komentuje wprowadzoną temperaturę powietrza.");
Console.WriteLine("Podaj temperature u Ciebie (w °C)");
int temperatura = int.Parse(Console.ReadLine());
string komentarz = "";
komentarz = temperatura switch
{
    < 0 => "ale piździ",
    >= 0 and < 10 => "jest zimno",
    >= 10 and <= 20 => "chłodno",
    > 20 and <= 30 => "w sam raz",
    > 30 and <= 40 => "ciepełko",
    > 40 => "straszny upał, ale to lepiej niż mrozik, bo lepiej jak się jaja pocą niż marzną"
};
Console.WriteLine($"Temperatura u Ciebie wynosi {temperatura}°C, {komentarz}.");



// Zadanie 10

Console.WriteLine("Program spr., czy z 3 podanych długości, da się utworzyć trójkąt");
Console.WriteLine("Podaj długości boków trójkąta: ");
double sideA = 0, sideB = 0, sideC = 0;

while (sideA == 0)
{
    sideA = readAndValid('A');
}
while (sideB == 0)
{
    sideB = readAndValid('B');
}
while (sideC == 0)
{
    sideC = readAndValid('C');
}

if ((sideA < sideB + sideC) && (sideB < sideA + sideC) && (sideC < sideA + sideB))
{
    Console.WriteLine($"Z podanych boków [{sideA}, {sideB}, {sideC}] można utworzyć trójkąt.");
}
else
{
    Console.WriteLine($"Z podanych boków [{sideA}, {sideB}, {sideC}] NIE można utworzyć trójkąta.");
}

double readAndValid(char side)
{
    Console.Write($"Długość boku {side} = ");
    if (double.TryParse(Console.ReadLine(), out double parsed) == false)
    {
        Console.WriteLine("Podałeś nie liczbową wartość");
    }
    if (parsed < 0)
    {
        Console.WriteLine("Długość boku musi być > 0");
    }
    return parsed;
}

// Zadanie 11

Console.WriteLine("Program zmienia oceny ze skali 1-6 na ich wersje opisową.");
Console.Write("Podaj ocenę w skali 1-6: ");
char.TryParse(Console.ReadLine(), out char ocenaUcznia);
string ocenaUczniaOpisowa = "";

switch (ocenaUcznia)
{
    case '1':
        ocenaUczniaOpisowa = "Niedostateczny";
        break;
    case '2':
        ocenaUczniaOpisowa = "Dopuszczający";
        break;
    case '3':
        ocenaUczniaOpisowa = "Dostateczny";
        break;
    case '4':
        ocenaUczniaOpisowa = "Dobry";
        break;
    case '5':
        ocenaUczniaOpisowa = "Bardzo dobry";
        break;
    case '6':
        ocenaUczniaOpisowa = "Celujący";
        break;
    default:
        Console.WriteLine("Podałeś złą ocenę ucznia (spoza skali 1-6)");
        break;
}

Console.WriteLine(ocenaUczniaOpisowa);

// Zadanie 12

Console.WriteLine("Program pobiera numer dnia tygodnia i wyświetla jego nazwę.");
Console.Write("Podaj numer dnia tygodnia");
byte.TryParse(Console.ReadLine(), out byte numberOfDay);
string dayOfWeek = "";


switch (numberOfDay)
{
    case 1:
        dayOfWeek = "Poniedziałek";
        break;
    case 2:
        dayOfWeek = "Wtorek";
        break;
    case 3:
        dayOfWeek = "Środa";
        break;
    case 4:
        dzienTygodnia = "Czwartek";
        break;
    case 5:
        dayOfWeek = "Piątek";
        break;
    case 6:
        dayOfWeek = "Sobota";
        break;
    case 7:
        dayOfWeek = "Niedziela";
        break;
    default:
        Console.WriteLine("Podałeś złą ocenę ucznia (spoza skali 1-6)");
        break;
}

Console.WriteLine(dayOfWeek);

// Zadanie 13

Console.WriteLine("Prosta wersja kalkulatora.");
Console.Write("Podaj pierwszą liczbę: ");
double.TryParse(Console.ReadLine(), out double pierwszaLiczba);
Console.Write("Podaj drugą liczbę: ");
double.TryParse(Console.ReadLine(), out double drugaLiczba);
Console.WriteLine("Podaj numer operacji do wykonania: ");
Console.WriteLine("1.Dodawanie");
Console.WriteLine("2.Odejmowanie");
Console.WriteLine("3.Mnożenie");
Console.WriteLine("4.Dzielenie");
byte.TryParse(Console.ReadLine(), out byte operacja);

double wynikOperacji = 0;

switch (operacja)
{
    case 1:
        wynikOperacji = pierwszaLiczba + drugaLiczba;
        break;
    case 2:
        wynikOperacji = pierwszaLiczba - drugaLiczba;
        break;
    case 3:
        wynikOperacji = pierwszaLiczba * drugaLiczba;
        break;
    case 4:
        if (drugaLiczba == 0)
        {
            Console.WriteLine("Nie można dzielić przez 0");
            break;
        }
        else
        {
            wynikOperacji = pierwszaLiczba / drugaLiczba;
            break;
        }
}

if (drugaLiczba == 0 && operacja == 4)
{
    Console.WriteLine($"Twój wynik to: NaN");
}
else
{
    Console.WriteLine($"Twój wynik to: {wynikOperacji}");
}
