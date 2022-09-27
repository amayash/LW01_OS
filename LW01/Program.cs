using System;
using System.Collections.Generic;

namespace LW01
{
    class Program
    {
        static void Main(string[] args)
        {
            Kernel core = new();
            MyList args1 = new();
            MyList args2 = new();
            MyList args3 = new();
            
            args1.Add(new Arg("val", "int", 15));
            args1.Add(new Arg("count", "int", 2));
            args2.Add(new Arg(null, "int", 666));
            args2.Add(new Arg("amount", null, 666));
            args2.Add(new Arg("me", "string", null));
            args3.Add(new Arg());
            args3.Add(new Arg("qwerty", "int?", 109));

            Kernel.listSysCall.Add(new SysCall(5115, "widget", args1));
            Kernel.listSysCall.Add(new SysCall(1121, "console", args2));
            Kernel.listSysCall.Add(new SysCall(1668, "app", args3));

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