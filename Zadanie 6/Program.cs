namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadeklaruj tablicę zawierającą nazwy dni tygodnia. Wypisz elementy tablicy za pomocą pętli
            //foreach

            string[] tab = new string[7]; // ustalam tablice o 7 elementach typu string
            tab[0] = "Poniedziałek"; // przypisuje wartosci do elementów tablicy
            tab[1] = "Wtorek";
            tab[2] = "Środa";
            tab[3] = "Czwartek";
            tab[4] = "Piątek";
            tab[5] = "Sobota";
            tab[6] = "Niedziela";
            foreach (string dzien in tab) // petla foreach, ktora wypisuje elementy tablicy
            {
                Console.WriteLine(dzien);
            }
            Console.ReadKey(true);

        }
    }
}
