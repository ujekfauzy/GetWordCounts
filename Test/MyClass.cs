using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetWordCounts.Test
{
    class MyClass : IMyInterface
    {
        public IEnumerable<Tuple<string, int>> GetWordCount(string[] words)
        {

            List<Tuple<string, int>> res = new List<Tuple<string, int>>(); 
            if (words != null)
            {

                bool[] alreadyCheck = new bool[words.Length];
                for (int i = 0; i < words.Length; i++)
                {
                    if (alreadyCheck[i])
                        continue;
                    int count = 1;
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            alreadyCheck[j] = true;
                            count++;
                        }
                    }

                    res.Add(new Tuple<string, int>(words[i], count));

                }
            }
            return res;

        }

        public IEnumerable<Tuple<string, int>> GetWordCount(string comaDelimitedWords)
        {
            string[] words = comaDelimitedWords.Split(new[] {',',' ' }, StringSplitOptions.RemoveEmptyEntries);
            return GetWordCount(words);
        }
    }
}
