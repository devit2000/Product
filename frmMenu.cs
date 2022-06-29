using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        private void btnListBox_Click(object sender, EventArgs e)
        {
            MenuClass.OpenListBox();
            this.Hide();
        }

        private void btnListView_Click(object sender, EventArgs e)
        {
            MenuClass.OpenListView();
            this.Hide();
        }

        private void btnDGV_Click(object sender, EventArgs e)
        {
            MenuClass.OpenDGV();
            this.Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
