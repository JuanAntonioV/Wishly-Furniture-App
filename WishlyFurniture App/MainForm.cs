using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WishlyFurniture_App
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;
        private void openSubForm(Form subForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(subForm);
            pnlMain.Tag = subForm;
            subForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            openSubForm(new MenuForms.Dashboard());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var LoginForm = new LoginForm();
            LoginForm.Closed += (s, args) => this.Close();
            LoginForm.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pcMenu.Image = WishlyFurniture_App.Properties.Resources.Dashboard;
            lblMenu.Text = btnDashboard.Text;
            openSubForm(new MenuForms.Dashboard());
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            pcMenu.Image = WishlyFurniture_App.Properties.Resources.Purchase;
            lblMenu.Text = btnPurchase.Text;
            openSubForm(new MenuForms.Purchase());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pcMenu.Image = WishlyFurniture_App.Properties.Resources.Employee;
            lblMenu.Text = btnEmployee.Text;
            openSubForm(new MenuForms.Employee());
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            pcMenu.Image = WishlyFurniture_App.Properties.Resources.Warehouse;
            lblMenu.Text = btnWarehouse.Text;
            openSubForm(new MenuForms.Warehouse());
        }


    }
}