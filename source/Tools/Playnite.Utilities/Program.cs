using System;

namespace Playnite.Utilities
{
    class Program
    {
        static void Main(string[] args)
        {
            DatParser.ProcessLibretroDb(@"e:\Devel\libretro-database", @"d:\Downloads\dats", true, true);
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

