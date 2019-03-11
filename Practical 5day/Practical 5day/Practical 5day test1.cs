using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_5day
{
    class Practical_5day_test1
    {
        static void Main(string[] args)
        {
            CellPhone cp = new CellPhone();
            FuncPhone(cp);
            FuncMailer(cp);
            FuncComputer(cp);
            Console.ReadLine();
        }
        public static void FuncPhone(IPhone phone)
        {
            phone.CallPhone();
            phone.RecievePhone();
        }
        public static void FuncMailer(IMailer mailer)
        {
            mailer.SendMail();
            mailer.RecieveMail();
        }
        public static void FuncComputer(IComputer computer)
        {
            computer.PlayGame();
            computer.BrowseWeb();
        }
    }
}
