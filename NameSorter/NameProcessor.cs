using System.Collections.Generic;
using System.Linq;

namespace namelistsort
{
    public class NameProcessor
    {
        protected List<string> Names { get; set; }
        public List<string> SortedNames { get; protected set; }

        public NameProcessor(List<string> list)
        {
            Names = list;
        }

        protected string GetLastName(string fullName)
        {
            return fullName.Split(' ').Last();
        }

        protected string GetGivenNames(string fullName)
        {
            var nameParts = fullName.Split(' ');
            return string.Join(" ", nameParts.Take(nameParts.Length - 1));
        }
    }

}
