using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stringFundamental
{
    public class StringUtility
    {
       public static string SummarizeText(string text, int maxLength = 20){
            if(text.Length < maxLength)
            return text;

            var words = text.Split(' ');
            var totalCharacters = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                // add each words to the summary words list
                summaryWords.Add(word);

                // increase the total character counts
                totalCharacters += word.Length + 1;

                // check if it exceed the total characters
                if(totalCharacters > maxLength)
                    break;

            }

            return String.Join(' ', summaryWords) + "...";

        }
    }
}