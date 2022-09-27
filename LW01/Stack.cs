using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW01
{
    public class Stack
    {
        public Arg[] _args = new Arg[20];
        public int _count = 0;
        public void Push(Arg argue)
        {
            _args[_count] = argue;
            _count++;
        }
        public Arg Pop()
        {      
            Arg temp = new();
            if (_count > 0)
            {
                _count--;
                temp = _args[_count];
                _args[_count] = new Arg();
            }
            return temp;
        }
        public bool IsEmpty()
        {
            return _count == 0;
        }

    }
}
