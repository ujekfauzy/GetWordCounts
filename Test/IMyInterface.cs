using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWordCounts.Test
{
    interface IMyInterface
    {
        Dictionary<string, int> GetWordCount(string [] words);
    }
}
