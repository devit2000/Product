using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;




namespace Product
{
    internal class LoginClass
    {
        public static void Login(string username, string password)
        {
            string uName = "admin", uPwd = "admin";
            if (uName == username)
            {
                if (uPwd == password)
                {
                    MessageBox.Show("Login Successful!", "Congreat", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("You enter the worng Password! Please try again.", "Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You enter the worng Username! Please try again.", "Login Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
