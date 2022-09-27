using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW01
{
    public class SysCall
    {
        public int ID;
        public string Name;
        public MyList Args;
        public SysCall(int ID, string Name, MyList Args)
        {
            this.ID = ID;
            this.Name = Name;
            this.Args = Args;
        }
        
    }
}
