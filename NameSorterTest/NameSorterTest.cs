using NUnit.Framework;
using System.Collections.Generic;
using namelistsort;
using Microsoft.VisualBasic;
using System;

namespace NameSorterTest
{
    public class NameSorterTests
    {
        private readonly List<string> RandomNames = new List<string>
            {
                "John Smith",
                "Alice Johnson",
                "Robert Lee Brown",
                "Mary Ann White",
                "David Lee Johnson",
                "Emily Rose",
                "Michael James",
                "Sarah Lee",
                // Add more names as needed
            };

        private readonly List<string> ProvidedNamesSample = new List<string>
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritter",
            };

        private readonly List<string> ProvidedNamesDataQuality = new List<string>
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "AAA",
                "Frankie Conner Ritter",
            };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SortedNamesTest()
        {
            NameSorter nSorter = new NameSorter(RandomNames);
            nSorter.SortList();
            nSorter.DisplaySortedNames();
            Assert.Pass();
        }

        [Test]
        public void SortedNamesTest2()
        {
            NameSorter nSorter = new NameSorter(ProvidedNamesSample);
            nSorter.SortList();
            nSorter.DisplaySortedNames();

            Assert.AreEqual(11, nSorter.SortedNames.Count);
            Assert.AreEqual("Marin Alvarez", nSorter.SortedNames[0]);
            Assert.AreEqual("Shelby Nathan Yoder", nSorter.SortedNames[nSorter.SortedNames.Count - 1]);
            
        }

        [Test]
        public void SortedNamesDataQualityTest()
        {
            NameSorter nSorter = new NameSorter(ProvidedNamesDataQuality);
            nSorter.SortList();
            nSorter.DisplaySortedNames();
            Assert.Pass();
        }
              
    }
}