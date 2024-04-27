using System;

namespace namelistsort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProgramHelpers.SortNameListFile(args);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
