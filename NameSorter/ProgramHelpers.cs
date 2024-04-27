using System.Configuration;

namespace namelistsort
{
    internal static class ProgramHelpers
    {
        private static NameSorter NSorter { get; set; }
        private static string SortedNamesFileName { get; set; }
        private static FileManager fileManager { get; set; }

        static ProgramHelpers()
        {
            SortedNamesFileName = ConfigurationManager.AppSettings["OutputFilePath"];
            fileManager = new FileManager();
        }

        public static void SortNameListFile(string[] args)
        {
            NSorter = new NameSorter(fileManager.TextFileToList(args[0]));
            NSorter.SortList();
            fileManager.StringListToFile(NSorter.SortedNames, SortedNamesFileName);
            NSorter.DisplaySortedNames();
        }
    }
}
