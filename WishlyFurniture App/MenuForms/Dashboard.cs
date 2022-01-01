using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WishlyFurniture_App.MenuForms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            (this.ParentForm as MainForm).Hide();
            var LoginForm = new LoginForm();
            LoginForm.Closed += (s, args) => this.Close();
            LoginForm.Show();
        }


        private bool _exit;
        private void btnExit_Click(object sender, EventArgs e)
        {
           if(!_exit && MessageBox.Show("Are you sure want to exit?","Wishly Furniture",MessageBoxButtons.OKCancel,MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exit = true;
                Environment.Exit(1);
            }
        }
    }
}
