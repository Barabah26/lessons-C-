using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringsTransformator.TransformSeparators("this,is,some,string", ",", "+"));
        }
    }
    public static class StringsTransformator
    {
        public static string TransformSeparators(2606
            string input,
            string originalSeparator,
            string targetSeparator)
        {
            string[] preResult = input.Split(originalSeparator);
            return string.Join(targetSeparator, preResult);
        }
    }
}
