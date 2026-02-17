using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.first_part
{
    public class MainClass
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(StringsTransformator.TransformSeparators("this,is,some,string", ",", "+"));
        //}
    }
    public static class StringsTransformator
    {
        public static string TransformSeparators(
            string input,
            string originalSeparator,
            string targetSeparator)
        {
            string[] preResult = input.Split(originalSeparator);
            return string.Join(targetSeparator, preResult);
        }
    }
}
