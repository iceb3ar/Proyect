using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n\n                                           --------------------| Elementos químicos de la tabla periódica |--------------------\n\n");

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n");
        Console.WriteLine(
            "                                           Los elementos químicos son un tipo de materia formada por átomos de la misma clase.\n" +
            "  Los átomos que lo constituyen, poseen un número determinado de protones en su núcleo haciéndolo pertenecer a una categoría única clasificada por su número atómico,\n" +
            "                                                       Aun cuando este pueda desplegar distintas masas atómicas."
        );
        Console.WriteLine("\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");

        //Write Info//
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(" Nombre       Numero Atomico    Simbolo    Peso Atomico    Densidad    Punto de fusion    Punto de ebullicion    Año de descubrimiento    Persona que lo descubrio\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 1. Hidrógeno      [1]           [H]       [1.00784(7)]     [0.084]      [-259.1 *C]         [-252.69 *C]               [1766]            [T.Von Hohenheim (Paracelso)]\n");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" 2. Helio          [2]           [He]      [4.002602(2)]    [0.17]       [-272.2 *C]         [-268.9 *C]                [1895]            [Ramsay y Cleve]\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" 3. Litio          [3]           [Li]      [6.941(2)]       [0.53]       [180.5 *C]          [1317 *C]                  [1817]            [Arfwedson]\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 4. Berilio        [4]           [Be]      [9.012182(3)]    [1.85]       [1278 *C]           [2970 *C]                  [1797]            [Vauquelin]\n");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(" 5. Boro           [5]           [B]       [10.811(7)]      [2.46]       [2300 *C]           [2550 *C]                  [1808]            [Davy y Gay-Lussac]\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 6. Carbono        [6]           [C]       [12.0107(8)]     [3.51]       [3550 *C]           [4827 *C]                  [Prehistoria]     [Desconocido]\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 7. Nitrógeno      [7]           [N]       [14.0067(2)]     [1.17 g/l]   [-209.9 *C]         [-195.8 *C]                [1772]            [Rutherford]\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 8. Oxígeno        [8]           [O]       [15.9994(3)]     [1.33 g/l]   [-218.4 *C]         [-182.9 *C]                [1774]            [Priestly y Scheele]\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 9. Flúor          [9]           [F]       [18.9984032(5)]  [1.58 g/l]   [-219.6 *C]         [-188.1 *C]                [1886]            [Moissan]\n");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" 10. Neón          [10]          [Ne]      [20.1797(6)]     [0.84 g/l]   [-248.7 *C]         [-246.1 *C]                [1898]            [Ramsay y Travers]\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" 11. Sodio         [11]          [Na]      [22.98976928(2)] [0.97]       [97.8 *C]           [892 *C]                   [1807]            [Davy]\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 12. Magnesio      [12]          [Mg]      [24.3050(6)]     [1.74]       [648.8 *C]          [1107 *C]                  [1755]            [Black]\n");

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" 13. Aluminio      [13]          [Al]      [26.9815386(8)]  [2.70]       [660.5 *C]          [2467 *C]                  [1825]            [Oersted]\n");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(" 14. Silicio       [14]          [Si]      [28.0855(3)]     [2.33]       [1410 *C]           [2355 *C]                  [1824]            [Berzelius]\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 15. Fósforo       [15]          [P]       [30.973762(2)]   [1.82]       [44 (P4) *C]        [280 (P4) *C]              [1669]            [Brand]\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 16. Azufre        [16]          [S]       [32.065(5)]      [2.06]       [113 *C]            [444.7 *C]                 [Prehistoria]     [Desconocido]\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 17. Cloro         [17]          [Cl]      [35.453(2)]      [2.95 g/l]   [-34.6 *C]          [-101 *C]                  [1774]            [Scheele]\n");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" 18. Argón         [18]          [Ar]      [39.948(1)]      [1.66 g/l]   [-189.4 *C]         [-185.9 *C]                [1894]            [Ramsay y Rayleigh]\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" 19. Potasio       [19]          [K]       [39.0983(1)]     [0.86]       [63.7 *C]           [774 *C]                   [1807]            [Davy]\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 20. Calcio        [20]          [Ca]      [40.078(4)]      [1.54]       [839 *C]            [1487 *C]                  [1808]            [Davy]\n");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" 21. Escandio      [21]          [Ca]      [44.955912(6)]   [2.99]       [1539 *C]           [2832 *C]                  [1879]            [Nilson]\n");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" 22. Titanio       [22]          [Ti]      [47.867(1)]      [4.51]       [1660 *C]           [3260 *C]                  [1791]            [Gregor y Klaproth]\n");
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" 23. Vanadio       [23]          [V]       [50.9415(1)]     [6.09]       [1890 *C]           [3380 *C]                  [1801]            [Andrés Manuel del Río]\n");

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" No. del Elemento -> ");
        Console.ReadLine();
    }
}