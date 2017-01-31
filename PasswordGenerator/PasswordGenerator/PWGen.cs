using System;
using ClassLibraryPWGen;

namespace PasswordGenerator
{
    class PWGen : ListSimbol
    {
        static void Main(string[] args)
        {
            ListSimbol ls = new ListSimbol();
            PWFanctions pwf = new PWFanctions();
            Print P = new Print();
            byte length;
            bool exit = true;
            while (exit)
            {
                P.PrintInstruction();
                var passnumber = (PassName.ListName)Convert.ToInt32(Console.ReadLine());
                if (passnumber!=PassName.ListName.exit)
                {
                    if (passnumber == PassName.ListName.pincode)
                    {
                        length = 4;
                    }
                    else
                    {
                        P.PrintLenght();
                        length = Convert.ToByte(Console.ReadLine());
                    }
                    P.Printcount();
                    int count = Convert.ToInt32(Console.ReadLine());
                    switch (passnumber)
                    {
                        case PassName.ListName.hexadecimal:
                            P.PassPrint(pwf.GetPassword(length, count, ls.ArrHexadecimal.Length, ls.ArrHexadecimal));
                            break;
                        case PassName.ListName.integer:
                            P.PassPrint(pwf.GetPassword(length, count, ls.ArrInteger.Length, ls.ArrInteger));
                            break;
                        case PassName.ListName.uppercase:
                            P.PassPrint(pwf.GetPassword(length, count, ls.ArrUppercase.Length, ls.ArrUppercase));
                            break;
                        case PassName.ListName.lowercase:
                            P.PassPrint(pwf.GetPassword(length, count, ls.ArrLowercase.Length, ls.ArrLowercase));
                            break;
                        case PassName.ListName.simbol:
                            P.PassPrint(pwf.GetPassword(length, count, ls.ArrSimbol.Length, ls.ArrSimbol));
                            break;
                        case PassName.ListName.allsimbols:
                            P.PassPrint(pwf.GetPassword(length, count, ls.ArrAllSimbols.Length, ls.ArrAllSimbols));
                            break;
                        case PassName.ListName.pincode:
                            P.PassPrint(pwf.GetPassword(length, count, ls.ArrInteger.Length, ls.ArrInteger));
                            break;
                        default:
                            Console.WriteLine("Incorrect data please follow the instructions");
                            break;
                    }
                }
                else
                {
                    exit = false;
                }
            }
        }
    }
}