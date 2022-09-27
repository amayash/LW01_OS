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
        string error = "";
        public Arg(string? Name, string? Type, int? Value)
        {
            this.Name = Name;
            this.Type = Type;
            this.Value = Value;
        }
        public Arg(params int[] f)
        {
            error += "Error. Not enough parameters";
        }
        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(error))
                return "\n\t\t\t\t\t" + error + "\n\t\t\t\t\tName: " + Name + "\tType: " + Type + "\tValue: " + Value + "\n";
            if (string.IsNullOrWhiteSpace(Name))
            {
                error+= "Error. Name is Empty";
                return "\n\t\t\t\t\t" + error + "\n\t\t\t\t\tName: " + Name + "\tType: " + Type + "\tValue: " + Value + "\n";
            }
            if (string.IsNullOrWhiteSpace(Type))
            {
                error += "Error. Type is Empty";
                return "\n\t\t\t\t\t" + error + "\n\t\t\t\t\tName: " + Name + "\tType: " + Type + "\tValue: " + Value + "\n";
            }
            if (Value==null)
            {
                error += "Error. Value is Empty";
                return "\n\t\t\t\t\t" + error + "\n\t\t\t\t\tName: " + Name + "\tType: " + Type + "\tValue: " + Value + "\n";
            }
            return "\tName: " + Name + "\tType: " + Type + "\tValue: " + Value + "\n";
        }
    }
}
