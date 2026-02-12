using System;

namespace OOP.StringsProcessor
{
    public class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }

    class StringsProcessor
    {
        public virtual List<string> Process(List<string> words)
        {
            return words;
        }
    }

    class StringsUppercaseProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> words)
        {
            List<string> result = new List<string>;
            foreach (var word in words)
            {
                string upper = word.ToUpper();
                result.Add(upper);
            }
            return result;
        }
    }

    class StringsTrimmingProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> words)
        {
            List<string> result = new List<string>;
            foreach (var word in words)
            {
                int half = word.Length / 2;
                string left = word.Substring(0, half);
                result.Add(left);
            }
            return result;
        }
    }
}
