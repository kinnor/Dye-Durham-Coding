using System;
using System.Collections.Generic;
using System.Linq;

namespace namelistsort
{
    public class NameSorter : NameProcessor, INameProcessor
    {
        public NameSorter(List<string> list) : base(list)
        {
        }
        public void SortList()
        {
            SortedNames = Names
                .OrderBy(name => GetLastName(name))
                .ThenBy(name => GetGivenNames(name))
                .ToList();
        }
        public void DisplaySortedNames()
        {
            foreach (var name in SortedNames)
            {
                Console.WriteLine(name);
            }
        }
    }

}
