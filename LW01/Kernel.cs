using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW01
{
    public class Kernel
    {
        public Kernel()
        {
            List<Arg> args1 = new();
            List<Arg> args2 = new();
            List<Arg> args3 = new();

            args1.Add(new Arg("val", "int", 15));
            args1.Add(new Arg("count", "int", 2));
            args2.Add(new Arg(null, "int", 666));
            args2.Add(new Arg("amount", null, 666));
            args2.Add(new Arg("me", null, null));
            args3.Add(new Arg());
            args3.Add(new Arg("qwerty", "int?", 109));

            listSysCall.Add(new SysCall(5115, "widget", args1));
            listSysCall.Add(new SysCall(1121, "console", args2));
            listSysCall.Add(new SysCall(1668, "app", args3));
        }

        List<SysCall> listSysCall = new List<SysCall>();
        public void ShowAll()
        {
            string result = "System Calls:";
            foreach (SysCall call in listSysCall)
            {
                result += "\n" + call.ToString();
            }
            Console.WriteLine(result);
        }

        public void Call(int id, Stack stack)
        {
            bool result = false;

            Arg temp = stack.Pop();

            foreach (SysCall call in listSysCall)
            {
                if (call.ID == id)
                {
                    foreach (Arg argum in call.Args)
                    {
                        if (temp.Name == argum.Name &&
                        temp.Type == argum.Type &&
                        temp.Value == argum.Value)
                        {
                            result = true;
                            Console.WriteLine("Found SysCall ID: " + id + "\t" + argum.ToString());
                        }
                    }
                }
            }

            if (!result)
                Console.WriteLine("Not found SysCall ID: " + id);
        }

    }
}