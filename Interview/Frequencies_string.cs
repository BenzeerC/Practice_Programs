using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    internal class Frequencies_string
    {
        static void Main(string[] args)
        {
            string str = "Happy Life long live";
            Dictionary<char, int> duplicate = GetCharacterFrequency(str);

            foreach(var c in duplicate)
            {
                Console.WriteLine($"Character:{c.Key},Frequency:{c.Value}");
            }

            Dictionary<string,int> WordFrequency = GetWordFrequency(str);
            Console.WriteLine("Word Frequency");

            foreach( var word in WordFrequency)
            {
                Console.WriteLine($"Word:{word.Key},Frequency:{word.Value}");
            }
        }

        static Dictionary<char,int> GetCharacterFrequency(string str)
        {
            Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();

            foreach(char ch in str)
            {
                if (keyValuePairs.ContainsKey(ch))
                {
                    keyValuePairs[ch]++;
                }
                else
                {
                    keyValuePairs[ch] = 1;
                }
            }
            return keyValuePairs;
            
        }

        static Dictionary<string,int> GetWordFrequency(string str)
        {
            string[] words = str.Split(new[] { ' ', '\t', '\n', '.', ',', '!', '?' });

            Dictionary<string,int> WordFrequency = new Dictionary<string,int>(StringComparer.OrdinalIgnoreCase);

            foreach (string item in words)
            {
                if (WordFrequency.ContainsKey(item))
                {
                    WordFrequency[item]++;
                }
                else
                {
                    WordFrequency[item] = 1;
                }
            
            }
            return WordFrequency;



        }
    }
}
