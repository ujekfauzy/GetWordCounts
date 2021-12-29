using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWordCounts.Test
{
    interface IMyInterface
    {
        IEnumerable<Tuple<string, int>> GetWordCount(string [] words);
        IEnumerable<Tuple<string, int>> GetWordCount(string comaDelimitedWords);
    }
}
