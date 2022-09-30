using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW01
{
    public class Arg
    {
        public string? Name;
        public string? Type;
        public int? Value;
        public Arg(string? Name, string? Type, int? Value)
        {
            this.Name = Name;
            this.Type = Type;
            this.Value = Value;
        }
        public Arg(params int[] f)
        {

        }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();

            if (string.IsNullOrWhiteSpace(Name))
            {
                s.Append("Error. Name is Empty\n");
            }
            if (string.IsNullOrWhiteSpace(Type))
            {
                s.Append("Error. Type is Empty\n");
            }
            if (Value == null)
            {
                s.Append("Error. Value is Empty\n");
            }

            return s.ToString() + "\nName: " + Name + "\tType: " + Type + "\tValue: " + Value + "\n";
        }
    }
}