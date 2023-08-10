using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    public class List1
    {
        static void Main(string[] args)
        {


            List<string> list = new List<string>
            {
                "red","green","red","orange","red","green","yellow"
            };

            List<string> list2 = new List<string>();
            List<int> counts = new List<int>();

            foreach (string s in list)
            {
                bool found= false;

                for (int i = 0; i < list2.Count; i++) 
                {
                    if (list2[i] == s)
                    {
                        counts[i]++;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    list2.Add(s);
                    counts.Add(1);
                }
            }

            for(int i=0;i<list2.Count;i++) 
            {
                Console.WriteLine($"Element:{list2[i]},Count:{counts[i]}");
            }

        }
    }
}
