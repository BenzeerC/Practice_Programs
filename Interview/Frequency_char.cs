using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    internal class Frequency_char
    {
        static void Main(string[] args)
        {

            string s = "I Love India";
            char[] ch = s.ToCharArray();
            int i, j, k;
            for (i = 0; i < ch.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (k = i - 1; k >= 0; k--)
                {
                    if (ch[k] == ch[i])
                    {
                        isVisited = true;
                        break;
                    }
                }
                if (isVisited == false)
                {
                    for (j = i + 1; j < ch.Length; j++)
                    {
                        if (ch[j] == ch[i])
                        {
                            count++;
                        }
                    }
                    if (ch[i] != ' ')
                    {

                        Console.WriteLine(ch[i] + " " + count);
                    }
                }
            }

        }
    }
}
