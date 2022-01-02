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

namespace WishlyFurniture_App.MenuForms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        #region SQL CONECTION CLIENT VARIABEL

        private SqlConnection con;
        private string constr;
        private SqlDataAdapter da;
        private SqlCommand cmd;
        private string query;
        private DataSet dsc,dsk;

        #endregion SQL CONECTION CLIENT VARIABEL

        private void koneksi()
        {
            // Windows Authentication
            constr = "Data Source = localhost; Initial Catalog = Wishlydb; Integrated Security = True";
            con = new SqlConnection(constr);
            con.Open();
        }

        private void loadDataCustomer()
        {
            dsc = new DataSet();
            query = "SELECT * FROM Customer";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsc, "customerData");
        }

        private void loadDataKaryawan()
        {
            dsk = new DataSet();
            query = "SELECT * FROM dbo.Karyawan";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(dsk, "karyawanData");
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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            koneksi();
            loadDataCustomer();
            loadDataKaryawan();
            lblTotalCustomer.Text = dsc.Tables["customerData"].Rows.Count.ToString();
            lblTotalEmployee.Text = dsk.Tables["karyawanData"].Rows.Count.ToString();
        }
    }
}
