using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OccupationСhoice.View.User
{
    public partial class WindowAddUser : Form
    {
        private MainControl control;

        public WindowAddUser(MainControl inControl)
        {
            InitializeComponent();
            this.control = inControl;
        }

        private void b_AddUser_Click(object sender, EventArgs e)
        {
            string login = tB_Login.Text;
            string password = tB_Password.Text;
            string type = cB_Type.SelectedItem.ToString();
            this.control.AddUser(login, password, type);
            this.Close();
        }

        private void b_Close_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
