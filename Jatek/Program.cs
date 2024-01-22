//Alap leegyszerűsített program----------------------------------------------------------

//int kitalalando, tipp;

//var veletlen = new Random();
//kitalalando = veletlen.Next(1, 100);

//do {
//    Console.Write("Írd be a tipped: ");
//    tipp = Convert.ToInt32(Console.ReadLine());
//    if (tipp > kitalalando) Console.WriteLine("Kisebb számot adj meg! ");
//    if (tipp < kitalalando) Console.WriteLine("Nagyobb számot adj meg! ");
//}
//while (tipp != kitalalando);

//if (tipp == kitalalando) Console.WriteLine("Gratulálok, kitaláltad!");

//Console.ReadKey();



//Maximum 6-szor próbálkozhatsz----------------------------------------------------------
//int kitalalando, tipp;
//int maxTipp = 6;
//int tippSzamlalo = 0;

//var veletlen = new Random();
//kitalalando = veletlen.Next(1, 100);

//do
//{
//    Console.Write("Írd be a tipped: ");
//    tipp = Convert.ToInt32(Console.ReadLine());
//    tippSzamlalo++;
//    if (tipp > kitalalando) Console.WriteLine("Kisebb számot adj meg! ");
//    if (tipp < kitalalando) Console.WriteLine("Nagyobb számot adj meg! ");
//}
//while ((tipp != kitalalando) && (tippSzamlalo < maxTipp));
//// && = és

//if (tipp == kitalalando) Console.WriteLine("Gratulálok, kitaláltad!");
//else Console.WriteLine("Béna vagy :(, a szám: " + kitalalando + " volt");

//Console.ReadKey();

//Továbbfejlesztett verzió--------------------------------------------------------------

static void PoziciobaKiir(int x, int y, string szoveg)
{
    Console.SetCursorPosition(x, y);
    Console.WriteLine(szoveg);
}


int kitalalando, tipp;

Console.SetWindowSize(110, 25);
PoziciobaKiir(46, 0, "Számkitaláló játék");

ConsoleKeyInfo cki;
do
{
    Console.Clear();
    int tippSzamlalo = 0;
    int maxTipp = 6;
    var veletlen = new Random();
    kitalalando = veletlen.Next(1, 100);

    do
    {
        PoziciobaKiir(4, 4, "Írd be a tipped:    ");
        Console.SetCursorPosition(21, 4);
        tipp = Convert.ToInt32(Console.ReadLine());
        tippSzamlalo++;
        if (tipp > kitalalando) PoziciobaKiir(4, 2, "Kisebb számot adj meg!  ");
        if (tipp < kitalalando) PoziciobaKiir(4, 2, "Nagyobb számot adj meg! ");
    }
    while ((tipp != kitalalando) && (tippSzamlalo < maxTipp));
    // && = és

    if (tipp == kitalalando) PoziciobaKiir(10, 10, "Gratulálok, kitaláltad!");
    else PoziciobaKiir(10, 10, "Béna vagy :(, a szám: " + kitalalando + " volt");
   
    

    PoziciobaKiir(43, 8, "Játszol még egyet? (i/n)");
    Console.CursorVisible = false;
    cki = Console.ReadKey();
    Console.CursorVisible = true;
}
while (cki.Key == ConsoleKey.I) ;