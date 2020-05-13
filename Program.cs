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
            string[] note = new string[12];
            note[0] = "C";
            note[1] = "Cis";
            note[2] = "D";
            note[3] = "Dis";
            note[4] = "E";
            note[5] = "F";
            note[6] = "Fis";
            note[7] = "G";
            note[8] = "Gis";
            note[9] = "A";
            note[10] = "Ais";
            note[11] = "B";
            int i, failed = 1; string read;
            Console.WriteLine("Please type the chord below:\n\n** C - Cis - D - Dis - E - F - Fis - G - Gis - A - Ais -B **\n\nNote: Add '-is' for sharp/flat replacement\n\nex: Type 'Cis' instead of C# or Db\n\nSelect the Chord: ");
            read = Console.ReadLine();
            if (read.Length == 0)
            {
                System.Console.WriteLine("Empty String");
                Console.ReadLine();
            }
            else
            {
                read = char.ToUpper(read[0]) + read.Substring(1);
            }


            for (i = 0; i < 11; i++)
            {
                if (note[i] == read)
                {
                    failed = 0;
                    Console.WriteLine("\n" + note[i] + " Major triad consists of " + note[i] + ", " + note[(i + 4) % 12] + " and " + note[(i + 7) % 12]);
                    Console.WriteLine(note[i] + " Minor triad consists of " + note[i] + ", " + note[(i + 3) % 12] + " and " + note[(i + 7) % 12]);
                    Console.WriteLine(note[i] + " Augmented triad consists of " + note[i] + ", " + note[(i + 4) % 12] + " and " + note[(i + 8) % 12]);
                    Console.WriteLine(note[i] + " Diminished triad consists of " + note[i] + ", " + note[(i + 3) % 12] + " and " + note[(i + 6) % 12]);
                    Console.ReadLine();
                }
            }
            if (failed == 1)
            {
                Console.WriteLine("\n" + read + " is an unknown input");
                Console.ReadLine();
            }
        }
    }
}
