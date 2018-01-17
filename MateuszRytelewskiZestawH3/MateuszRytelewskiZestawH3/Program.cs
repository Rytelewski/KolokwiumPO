using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MateuszRytelewskiZestawH3
{
    class Program
    {
        static void Main(string[] args)
        {
            char l=' ';
            
            Console.WriteLine("Co chcesz zrobic? Wybierz i naciśnij enter");
            Console.WriteLine("A - dodaj tv");
            Console.WriteLine("B - dodaj komputer");
            Console.WriteLine("C1 - polacz");
            Console.WriteLine("C2 - podziel");
            Console.WriteLine("D - napraw");
            Console.WriteLine("E - napraw po numerze seryjnym");
            Console.WriteLine("X - wyjście z aplikacji");

             try
                {
                    l = Convert.ToChar(Console.ReadLine());
                }
                catch
                { }
            
                switch (l)
                { 
                        /*/
                    case 'A':
                        DodajTelewizor();
                        break;
                    case 'B':
                        DodajKomputer();
                        break;
                    case 'C1':
                        Polacz();
                        break;
                    case 'C2':
                         Podziel()
                        break;
                    case 'D':
                        Napraw();
                        break;
                    case 'E':
                        Napraw(int);
                        break;/*/
                    case 'X':
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Błąd!");
                        break;
                }

            
                Console.WriteLine("Naciśnij dowolny przycisk...");
                Console.ReadKey();
                Console.Clear(); 
        }

        
    } 
}