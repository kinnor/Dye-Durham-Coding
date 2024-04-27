using NUnit.Framework;
using System.Collections.Generic;
using namelistsort;

namespace NameSorterTest
{
    internal class FileManagerTest
    {
        FileManager fileManager { get; set; }
        string testFileName = "./unsorted-names-list.txt";

        [Test]
        public void LoadFileTest()
        {
            fileManager = new FileManager();
            List<string> list= fileManager.TextFileToList(testFileName);

            Assert.IsNotNull(list);
            Assert.GreaterOrEqual(list.Count, 1);
            Assert.Pass();
        }
    }
}
