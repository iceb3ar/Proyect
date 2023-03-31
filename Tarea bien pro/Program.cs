using System;
using Newtonsoft.Json;
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
        Console.WriteLine(" Nombre       Numero Atomico    Simbolo    Peso Atomico    Densidad    Año de descubrimiento    Persona que lo descubrio\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 1. Hidrógeno      [1]           [H]       [1.00784(7)]      [0.084]      [1766]      [Henry Cavendish]\n");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" 2. Helio          [2]           [He]      [4.002602(2)]     [0.17]       [1895]      [Pierre-Jules-César Janssen]\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" 3. Litio          [3]           [Li]      [6.941(2)]       [0.53]       [1817]      []\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 4. Berilio        [4]           [Be]      [9.012182(3)]    [1.85]       [1797]      []\n");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(" 5. Boro           [5]           [B]       [10.811(7)]      [2.46]       [1808]      []n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 6. Carbono        [6]           [C]       [12.0107(8)]     [3.51]       [Prehistoria]      []\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 7. Nitrógeno      [7]           [N]       [14.0067(2)]     [1.17 g/l]   [1772]      []\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 8. Oxígeno        [8]           [O]       [15.9994(3)]     [1.33 g/l]   [1774]      []\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 9. Flúor          [9]           [F]       [18.9984032(5)]  [1.58 g/l]   [1886]      []\n");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" 10. Neón          [10]          [Ne]      [20.1797(6)]     [0.84 g/l]   [1898]      []\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" 11. Sodio         [11]          [Na]      [22.98976928(2)] [0.97]       [1807]      []\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 12. Magnesio      [12]          [Mg]      [24.3050(6)]     [1.74]       [1755]      []\n");

        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(" 13. Aluminio      [13]          [Al]      [26.9815386(8)]  [2.70]       [1825]      []\n");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(" 14. Silicio       [14]          [Si]      [28.0855(3)]     [2.33]       [1824]      []\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 15. Fósforo       [15]          [P]       [30.973762(2)]   [1.82]       [1669]      []\n");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" 16. Azufre        [16]          [S]       [32.065(5)]      [2.06]       [Prehistoria]     []\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 17. Cloro         [17]          [Cl]      [35.453(2)]      [2.95 g/l]   [1774]      []\n");

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" 18. Argón         [18]          [Ar]      [39.948(1)]      [1.66 g/l]   [1894]      []\n");

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" 19. Potasio       [19]          [K]       [39.0983(1)]     [0.86]       [1807]      []\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(" 20. Calcio        [20]          [Ca]      [40.078(4)]      [1.54]       [1808]      []\n");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" 21. Escandio      [21]          [Ca]      [44.955912(6)]   [2.99]       [1879]      []\n");

        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" 22. Titanio       [22]          [Ti]      [47.867(1)]      [4.51]       [1791]      []\n");
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" 23. Vanadio       [23]          [V]       [50.9415(1)]     [6.09]       [1801]      []\n");
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" 23. Cromo       [24]          [Cr]       [50.9415(1)]     [6.09]        [1801]      []\n");



        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("\n\n------------------------------------------------------------------------------------------------------------------------------------------------------------------------\n\n");






        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" No. del Elemento -> ");
        
        switch (Console.ReadLine())
        {
            case "1": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento1.jpg");
                break;
            }
            case "2": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento2.jpg");
                break;
            }
            case "3": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento3.jpg");
                break;
            }
            case "4": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento4.jpg");
                break;
            }
            
            case "5": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento5.jpg");
                break;
            }
            case "6": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento6.jpg");
                break;
            }
            case "7": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento7.jpg");
                break;
            }
            case "8": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento8.jpg");
                break;
            }
            case "9": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento9.jpg");
                break;
            }
            case "10": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento10.jpg");
                break;
            }
            case "11": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento11.jpg");
                break;
            }
            case "12": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento12.jpg");
                break;
            }
            case "13": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento13.jpg");
                break;
            }
            case "14": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento14.jpg");
                break;
            }
            case "15": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento15.jpg");
                break;
            }
            case "16": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento16.jpg");
                break;
            }
            case "17": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento17.jpg");
                break;
            }
            case "18": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento18.jpg");
                break;
            }
            case "19": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento19.jpg");
                break;
            }
            case "20": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento20.jpg");
                break;
            }
            case "21": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento21.jpg");
                break;
            }
            case "22": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento22.jpg");
                break;
            }
            case "23": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento23.jpg");
                break;
            }
            case "24": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento24.jpg");
                break;
            }
            case "25": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento25.jpg");
                break;
            }
            case "26": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento26.jpg");
                break;
            }
            case "27": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento27.jpg");
                break;
            }
            case "28": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento28.jpg");
                break;
            }
            case "29": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento29.jpg");
                break;
            }
            case "30": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento30.jpg");
                break;
            }
            case "31": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento31.jpg");
                break;
            }
            case "32": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento32.jpg");
                break;
            }
            case "33": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento33.jpg");
                break;
            }
            case "34": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento34.jpg");
                break;
            }
            case "35": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento35.jpg");
                break;
            }
            case "36": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento36.jpg");
                break;
            }
            case "37": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento37.jpg");
                break;
            }
            case "38": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento38.jpg");
                break;
            }
            case "39": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento39.jpg");
                break;
            }
            case "40": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento40.jpg");
                break;
            }
            case "41": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento41.jpg");
                break;
            }
            case "42": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento42.jpg");
                break;
            }
            case "43": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento43.jpg");
                break;
            }
            case "44": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento44.jpg");
                break;
            }
            case "45": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento45.jpg");
                break;
            }
            case "46": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento46.jpg");
                break;
            }
            case "47": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento47.jpg");
                break;
            }
            case "48": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento48.jpg");
                break;
            }
            case "49": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento49.jpg");
                break;
            }
            case "50": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento50.jpg");
                break;
            }
             case "51": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento51.jpg");
                break;
            }
             case "52": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento52.jpg");
                break;
            }
             case "53": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento53.jpg");
                break;
            }
             case "54": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento54.jpg");
                break;
            }
             case "55": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento55.jpg");
                break;
            }
             case "56": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento56.jpg");
                break;
            }
             case "57": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento57.jpg");
                break;
            }
             case "58": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento58.jpg");
                break;
            }
             case "59": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento59.jpg");
                break;
            }
             case "60": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento60.jpg");
                break;
            }
            case "61": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento61.jpg");
                break;
            }
            case "62": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento62.jpg");
                break;
            }
            case "63": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento63.jpg");
                break;
            }
            case "64": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento64.jpg");
                break;
            }
            case "65": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elemento65.jpg");
                break;
            }
            case "66": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento66.jpg");
                break;
            }
            case "67": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento67.jpg");
                break;
            }
            case "68": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento68.jpg");
                break;
            }
            case "69": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento69.jpg");
                break;
            }
            case "70": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento70.jpg");
                break;
            }
            case "71": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento71.jpg");
                break;
            }
            case "72": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento72.jpg");
                break;
            }
            case "73": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento73.jpg");
                break;
            }
            case "74": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento74.jpg");
                break;
            }
            case "75": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento75.jpg");
                break;
            }
            case "76": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento76.jpg");
                break;
            }
            case "77": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento77.jpg");
                break;
            }
            case "78": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento78.jpg");
                break;
            }
            case "79": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento79.jpg");
                break;
            }
            case "80": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento80.jpg");
                break;
            }
            case "81": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento81.jpg");
                break;
            }
            case "82": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento82.jpg");
                break;
            }
            case "83": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento83.jpg");
                break;
            }
            case "84": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento84.jpg");
                break;
            }
            case "85": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento85.jpg");
                break;
            }
            case "86": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento86.jpg");
                break;
            }
            case "87": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento87.jpg");
                break;
            }
            case "88": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento88.jpg");
                break;
            }
            case "89": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento89.jpg");
                break;
            }
            case "90": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento90.jpg");
                break;
            }
            case "91": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento91.jpg");
                break;
            }
            case "92": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento92.jpg");
                break;
            }
            case "93": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento93.jpg");
                break;
            }
            case "94": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento94.jpg");
                break;
            }
            case "95": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento95.jpg");
                break;
            }
            case "96": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento96.jpg");
                break;
            }
            case "97": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento97.jpg");
                break;
            }
            case "98": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento98.jpg");
                break;
            }
            case "99": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento99.jpg");
                break;
            }
            case "100": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento100.jpg");
                break;
            }
            case "101": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento101.jpg");
                break;
            }
            case "102": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento102.jpg");
                break;
            }
            case "103": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento103.jpg");
                break;
            }
            case "104": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento104.jpg");
                break;
            }
            case "105": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento105.jpg");
                break;
            }
            case "106": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento106.jpg");
                break;
            }
            case "107": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento107.jpg");
                break;
            }
            case "108": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento108.jpg");
                break;
            }
            case "109": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento109.jpg");
                break;
            }
            case "110": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento110.jpg");
                break;
            }
            case "111": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento111.jpg");
                break;
            }
            case "112": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento112.jpg");
                break;
            }
            case "113": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento113.jpg");
                break;
            }
            case "114": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento114.jpg");
                break;
            }
            case "115": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento115.jpg");
                break;
            }
            case "116": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento116.jpg");
                break;
            }
            case "117": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento117.jpg");
                break;
            }
            case "118": {
                Process.Start("https://github.com/iceb3ar/Proyecto-Quimica/blob/main/elmento118.jpg");
                break;
            }
        }
    }
}