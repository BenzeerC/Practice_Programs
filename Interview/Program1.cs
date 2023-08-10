using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    
        public class InheritanceProgram
        {
            public virtual int GetValue()
            {
                return 200;
            }
        }
        public class child : InheritanceProgram
        {
            public override int GetValue()
            {
                return 100;
            }

            static void Main(string[] args)
            {
                child child = new child();
                Console.WriteLine(child.GetValue());
                InheritanceProgram i = new child();
                i.GetValue();
                Console.WriteLine(i.GetValue());
            }
        }
}
