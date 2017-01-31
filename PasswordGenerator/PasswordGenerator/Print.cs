using System;
using System.Collections.Generic;

namespace PasswordGenerator
{
    class Print
    {
        public void PassPrint(List<string> velue)
        {
            foreach (var item in velue)
            {
                Console.WriteLine(item);
            }
            velue.Clear();
        }
        public void PrintInstruction()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Instruction");
            Console.WriteLine("0 = Hexadecimal \t1 = Integer \t2 = Uppercase \t3 = Lowercase \t4 =  Simbol \t5 = AllSimbols \t6 = Pincode \t7 = Exit");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void PrintLenght()
        {
            Console.WriteLine("Password Lenght 0-255");
        }
        public void Printcount()
        {
            Console.WriteLine("Password Count");
        }
    }

}
