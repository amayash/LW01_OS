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
        public List<Arg> Args;
        public SysCall(int ID, string Name, List<Arg> Args)
        {
            this.ID = ID;
            this.Name = Name;
            this.Args = Args;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Args: \n{String.Join("", Args)}";
        }
    }
}