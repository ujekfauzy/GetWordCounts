using GetWordCounts.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWordCounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Test.IMyInterface myInterface = new MyClass();
            myInterface.GetWordCount(new[] { "one", "two", "two", "three", "three", "three", "four" });
        }
    }
}
