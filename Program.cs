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
            var getwordcount1 = myInterface.GetWordCount(new[] { "one", "two", "two", "three", "three", "three", "four" });
            var getwordcount2 = myInterface.GetWordCount("one,two, two, three, three, three, three,Four,four");
            var bit0 = myInterface.IsBitSet(9, 0);
            var bit1 = myInterface.IsBitSet(9, 1);
            var bit2 = myInterface.IsBitSet(9, 2);
            var bit3 = myInterface.IsBitSet(9, 3);
            var bitSet = myInterface.GetBitsSet(9);
            var newValue = myInterface.SetBits(9, new[] { 2 });
            var newBitsSet = myInterface.GetBitsSet(newValue);

        }
    }
}
