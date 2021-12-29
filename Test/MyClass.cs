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
        private int[] GetArayOfBit(int value)
        {
            int bit = 0;
            List<int> arrBit = new List<int>();
            while (value > 0)
            {
                bit = value % 2;
                arrBit.Add(bit);
                value = value / 2;
            }
            return arrBit.ToArray();
        }
        public IEnumerable<int> GetBitsSet(int value)
        {
            List<int> res = new List<int>();
            var arrBit = GetArayOfBit(value);
            if (arrBit != null)
            {
                for (int i = 0; i < arrBit.Length; i++)
                {
                    if (arrBit[i] == 1)
                    {
                        res.Add(i);
                    }
                }
            }
          
            return res;
        }
        public bool IsBitSet(int value, int bit)
        {
            var bitArray = GetArayOfBit(value);
            return bitArray[bit] == 0 ? false : true;
        }

        public int SetBits(int value, int[] bitsToSet)
        {
            var bitArray = GetArayOfBit(value);
            foreach (var item in bitsToSet)
            {
                bitArray[item] = 1;
            }

            int res = 0;
            for (int i = 0; i < bitArray.Length; i++)
            {
                if (bitArray[i] == 1)
                {
                    if (i == 0 )
                    {
                        res = +1;
                    }
                    else
                    {
                        res += (int)Math.Pow(2, i);
                    }
                }
                
                
            }
            return res;
        }
    }
}
