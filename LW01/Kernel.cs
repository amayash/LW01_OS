using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW01
{
    public class Kernel
    {
        public static List<SysCall> listSysCall = new List<SysCall>();
        public static int countSysCall = 0;
        public void ShowAll()
        {
            string result = "System Calls:";
            foreach (SysCall call in listSysCall)
            {
                result+="\nID: " + call.ID + "\tName: " + call.Name
                    + "\tArgs: \n" + call.Args.ToString();
                countSysCall++;
            }
            countSysCall = 0;
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
