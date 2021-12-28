using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetWordCounts.Test
{
    class MyClass : IMyInterface
    {
        public Dictionary<string, int> GetWordCount(string[] words)
        {

            Dictionary<string, int> result = new Dictionary<string, int>();
            if (words != null)
            {

                bool[] check = new bool[words.Length];
                for (int i = 0; i < words.Length; i++)
                {
                    if (check[i])
                        continue;
                    int count = 1;
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            check[j] = true;
                            count++;
                        }
                    }

                    result.Add(words[i], count);


                }
            }
            return result;

        }
    }
}
