using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader wordsReader = new StreamReader("../../../words.txt"))
            {
                using (StreamWriter writer = new StreamWriter("../../../result.txt"))
                {
                    Dictionary<string, int> words = new Dictionary<string, int>();
                    string line = wordsReader.ReadLine();
                    while (line != null)
                    {
                        using (StreamReader textReader = new StreamReader("../../../text.txt"))
                        {
                            string textLine = textReader.ReadLine();
                            int count = 0;
                            while (textLine != null)
                            {
                                string[] split = textLine.Split(new char[] {' ', '.', ',', '?', '!', '-', '\t'},
                                    StringSplitOptions.RemoveEmptyEntries);
                                foreach (string word in split)
                                {
                                    if (word.ToLower() == line) count++;
                                }
                                textLine = textReader.ReadLine();
                            }
                            if (count != 0) words.Add(line, count);
                        }
                        line = wordsReader.ReadLine();
                    }
                    foreach (KeyValuePair<string, int> pair in words.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{pair.Key} - {pair.Value}");
                    }
                }
            }
        }
    }
}
