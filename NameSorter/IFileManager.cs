using System.Collections.Generic;

namespace namelistsort
{
   internal interface IFileManager
    {
        bool StringListToFile(List<string> list, string filePath);
        List<string> TextFileToList(string filePath);
    }
}
