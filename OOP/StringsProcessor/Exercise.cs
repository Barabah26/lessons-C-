using System;
using System.Collections.Generic;
using System.Globalization;

namespace OOP.StringsProcessor
{
    public class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            if (words == null)
                throw new ArgumentNullException(nameof(words));

            var stringsProcessors = new List<StringsProcessor>
            {
                new StringsTrimmingProcessor(),
                new StringsUppercaseProcessor()
            };

            var result = words;
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
            return words ?? new List<string>();
        }
    }

    class StringsUppercaseProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> words)
        {
            var result = new List<string>();
            if (words == null) return result;

            foreach (var word in words)
            {
                if (word == null)
                {
                    result.Add(null);
                    continue;
                }

                string upper = word.ToUpper(CultureInfo.InvariantCulture);
                result.Add(upper);
            }
            return result;
        }
    }

    class StringsTrimmingProcessor : StringsProcessor
    {
        public override List<string> Process(List<string> words)
        {
            var result = new List<string>();
            if (words == null) return result;

            foreach (var word in words)
            {
                if (string.IsNullOrEmpty(word))
                {
                    result.Add(word); 
                    continue;
                }

                int half = word.Length / 2;
                string left = word.Substring(0, half);
                result.Add(left);
            }
            return result;
        }
    }
}