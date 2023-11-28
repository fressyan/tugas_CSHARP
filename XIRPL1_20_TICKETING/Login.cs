using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIRPL1_20_TICKETING.MasterForm;

namespace XIRPL1_20_TICKETING
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }



        private void txtLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRegister register = new FrmRegister();
            register.Show();
            //this.Close();
        }
    }
}
