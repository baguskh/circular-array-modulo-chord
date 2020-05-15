using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circular_mod___chord
{
    class Program
    {
        static void Main(string[] args)
        {
            int exit = 0;
            while (exit == 0)
            {
                string[] note = new string[12];
                note[0] = "C"; note[1] = "Cis"; note[2] = "D"; note[3] = "Dis"; note[4] = "E"; note[5] = "F"; note[6] = "Fis"; note[7] = "G"; note[8] = "Gis"; note[9] = "A"; note[10] = "Ais"; note[11] = "B";
                int i, failed = 1; string read;

                Console.Clear();
                Console.WriteLine("\n ** Please type the chord below: **\n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" C - Cis - D - Dis - E - F - Fis - G - Gis - A - Ais - B");
                Console.ResetColor();
                Console.WriteLine("\n Note: Add '-is' for sharp/flat replacement\n\n ex: Type 'Cis' instead of C# or Db\n\n Select the Chord: \n");
                Console.ForegroundColor = ConsoleColor.Green;
                read = Console.ReadLine();
                Console.ResetColor();
                read = Capital(read);

                for (i = 0; i < 11; i++)
                {
                    if (note[i] == read)
                    {
                        failed = 0;
                        Console.WriteLine("\n " + note[i] + " Major triad consists of " + note[i] + ", " + note[(i + 4) % 12] + " and " + note[(i + 7) % 12]);
                        Console.WriteLine(" " + note[i] + " Major sixth chord consists of " + note[i] + ", " + note[(i + 4) % 12] + ", " + note[(i + 7) % 12] + " and " + note[(i + 9) % 12]);
                        Console.WriteLine(" " + note[i] + " Dominant seventh chord consists of " + note[i] + ", " + note[(i + 4) % 12] + ", " + note[(i + 7) % 12] + " and " + note[(i + 10) % 12]);
                        Console.WriteLine(" " + note[i] + " Major seventh chord consists of " + note[i] + ", " + note[(i + 4) % 12] + ", " + note[(i + 7) % 12] + " and " + note[(i + 11) % 12]);
                        Console.WriteLine("\n " + note[i] + " Minor triad consists of " + note[i] + ", " + note[(i + 3) % 12] + " and " + note[(i + 7) % 12]);
                        Console.WriteLine(" " + note[i] + " Minor sixth chord consists of " + note[i] + ", " + note[(i + 3) % 12] + ", " + note[(i + 7) % 12] + " and " + note[(i + 9) % 12]);
                        Console.WriteLine(" " + note[i] + " Minor seventh chord consists of " + note[i] + ", " + note[(i + 3) % 12] + ", " + note[(i + 7) % 12] + " and " + note[(i + 10) % 12]);
                        Console.WriteLine(" " + note[i] + " Minor-major seventh chord consists of " + note[i] + ", " + note[(i + 3) % 12] + ", " + note[(i + 7) % 12] + " and " + note[(i + 11) % 12]);
                        Console.WriteLine("\n " + note[i] + " Augmented triad consists of " + note[i] + ", " + note[(i + 4) % 12] + " and " + note[(i + 8) % 12]);
                        Console.WriteLine(" " + note[i] + " Augmented seventh chord consists of " + note[i] + ", " + note[(i + 4) % 12] + ", " + note[(i + 8) % 12] + " and " + note[(i + 10) % 12]);
                        Console.WriteLine("\n " + note[i] + " Diminished triad consists of " + note[i] + ", " + note[(i + 3) % 12] + " and " + note[(i + 6) % 12]);
                        Console.WriteLine(" " + note[i] + " Diminished seventh chord consists of " + note[i] + ", " + note[(i + 3) % 12] + ", " + note[(i + 6) % 12] + " and " + note[(i + 9) % 12]);
                        Console.WriteLine(" " + note[i] + " Half-diminished seventh chordconsists of " + note[i] + ", " + note[(i + 3) % 12] + ", " + note[(i + 6) % 12] + " and " + note[(i + 10) % 12]);
                    }
                }
                if (failed == 1)
                {
                    Console.WriteLine("\n" + read + " is an unknown input");
                }
                Console.WriteLine("\n\n  Try again?(type 'y' to continue)");
                read = Console.ReadLine();
                read = Capital(read);
                exit = int.Parse(ExitMode(read));
            }
        }

        static string Capital(string s)
        {
            if (s.Length == 0)
            {
                System.Console.WriteLine("Empty String");
                Console.ReadLine();
                return s;
            }
            else
            {
                s = char.ToUpper(s[0]) + s.Substring(1);
                return s;
            }
        }

        static string ExitMode(string s)
        {
            if (s=="Y")
            {
                s = "0";
                return s;
            }
            else
            {
                s = "1";
                return s;
            }
        }
    }
}
