using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UserMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What do you want to do ? 1:ADD USER 2:Update User PassWord : ");

            try
            {
                int WhichPart = Convert.ToInt32(Console.ReadLine());
                if (WhichPart == 1)
                {
                    Console.Write("User Name : ");
                    string UserName = Console.ReadLine();

                    Console.Write("User Password: ");
                    string Password = Console.ReadLine();

                    UserManagement.UserManagement.MakeUser(UserName, Password);


                }

                else if (WhichPart == 2)
                {
                    Console.Write("User Name : ");
                    string UserName = Console.ReadLine();

                    Console.Write("User Old Password: ");
                    string OldPassword = Console.ReadLine();

                    Console.Write("User New Password: ");
                    string NewPassword = Console.ReadLine();
                    UserManagement.UserManagement.UpdateUser(UserName, OldPassword, NewPassword);

                    Console.ReadKey();

                }

                else
                {
                    Main(null);
                }
            }
            catch
            {
                Console.WriteLine("Put valid Number  ");
                Main(null);
            }
        }
    }
}
