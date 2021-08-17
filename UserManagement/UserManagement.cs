using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Text;
using System.Windows.Forms;

namespace UserManagement
{
    public class UserManagement
    {
        public static void MakeUser(string UserName, string PassWord)
        {
            try
            {
                var ad = new DirectoryEntry("WinNT://" +
                                                       Environment.MachineName + ",computer");
                var NewUser = ad.Children.Add(UserName, "user");
                NewUser.Invoke("SetPassword", new object[] { PassWord });
                NewUser.Invoke("Put", new object[] { "Description", "Test User from .NET" });
                NewUser.CommitChanges();
                DirectoryEntry grp;

                grp = ad.Children.Find("Guests", "group");
                if (grp != null)
                {
                    grp.Invoke("Add", new object[] { NewUser.Path.ToString() });
                }
                MessageBox.Show("Account Created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateUser(string UserName, string NewPassWord)
        {
            var AD = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry grp;
            grp = AD.Children.Find(UserName, "user");
            if (grp != null)
            {
                grp.Invoke("SetPassword", new object[] { NewPassWord });
            }
            grp.CommitChanges();
            MessageBox.Show("Account Change password Successfully");
        }
    }
}