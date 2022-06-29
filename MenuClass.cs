using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    internal class MenuClass
    {
        public static void OpenListBox()
        {
            new frmListBox().Show();
        }
        public static void OpenListView()
        {
            new frmListView().Show();
        }
        public static void OpenDGV()
        {
            new frmDGV().Show();
        }
    }
}
