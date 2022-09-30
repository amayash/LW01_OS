using System;
using System.Collections.Generic;

namespace LW01
{
    class Program
    {
        static void Main(string[] args)
        {
            Kernel core = new();
            core.ShowAll();

            Stack stack = new Stack();
            stack.Push(new Arg("val", "int", 15));
            stack.Push(new Arg("count", "int", 2));
            core.Call(5115, stack);
            core.Call(5115, stack);
            core.Call(5222, stack);
            stack.Push(new Arg("count", "int", 2));
            stack.Push(new Arg("qwerty", "int?", 109));
            core.Call(1121, stack);
            stack.Push(new Arg("qwerty", "int?", 109));
            stack.Push(new Arg("", "int?", 109));
            core.Call(1668, stack);
            core.Call(1668, stack);

            Console.ReadKey();

        }
    }
}