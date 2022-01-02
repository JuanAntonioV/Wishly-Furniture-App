using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WishlyFurniture_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        #region SQL CONECTION CLIENT VARIABEL

        private SqlConnection con;
        private string constr;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        private string query;
        private DataSet ds;
        private DataRow dr;
        private DataColumn[] dc = new DataColumn[1];

        #endregion SQL CONECTION CLIENT VARIABEL

        private void koneksi()
        {
            // Windows Authentication
            constr = "Data Source = localhost; Initial Catalog = Wishlydb; Integrated Security = True";
            con = new SqlConnection(constr);
            con.Open();
        }

        private void loadData()
        {
            ds = new DataSet();
            query = "SELECT * FROM Karyawan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Karyawan");
            dc[0] = ds.Tables["Karyawan"].Columns[9];
            ds.Tables["Karyawan"].PrimaryKey = dc;
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            dr = ds.Tables["Karyawan"].Rows.Find(txtUsername.Text);
            if (dr != null)
            {
                if (dr[9].ToString() == txtPassword.Text)
                {
                    // NEXT FORM -->> #MainForm
                    var MainForm = new MainForm();
                    MainForm.Closed += (s, args) => this.Close();
                    MainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or Password is incorect !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUsername.Focus();
                }
            }
            else if (txtUsername.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your Username & Password !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtUsername.Focus();
            }
            else
            {
                MessageBox.Show(txtUsername.Text + " username is not registered !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUsername.Focus();
            }
        }
    }
}