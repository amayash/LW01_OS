using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW01
{
    public class MyList : List<Arg>
    {
        public override string ToString()
        {
            int count = 0;
            string result = "";
            for (int i = 0; i < Kernel.listSysCall.Count; i++)
            {
                if (Kernel.countSysCall == i)
                {
                    foreach (Arg arg in Kernel.listSysCall[i].Args)
                    {
                        count++;
                        result += "\t\t\t\t\tArg№" + count + arg.ToString();
                    }
                }
            }
            return result;
        }

    }
}
