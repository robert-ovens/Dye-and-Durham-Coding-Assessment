using System;
using System.IO;
using System.Linq;
//Reads .txt file and converts to array
public class ReadFile
    {
        public string[] PullText(string fileName)
        {
            string[] fullNames = File.ReadAllLines(fileName.ToString());

            return fullNames;

        }

    }