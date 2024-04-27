using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace namelistsort
{
    public class FileManager : IFileManager
    {
        public bool StringListToFile(List<string> list, string filePath)
        {
            try
            {
                File.WriteAllLines(filePath, list);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public List<string> TextFileToList(string filePath)
        {
            try
            {
                return File.ReadAllLines(filePath).ToList();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found. Please provide a valid file path.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return null;
        }
    }
 }
