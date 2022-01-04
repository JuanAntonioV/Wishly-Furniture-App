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

namespace WishlyFurniture_App.AdditionalForms
{
    public partial class EditCustomerForm : Form
    {
        public EditCustomerForm()
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
        private SqlCommandBuilder cb = new SqlCommandBuilder();

        #endregion SQL CONECTION CLIENT VARIABEL

        private int total = 0;

        private void koneksi()
        {
            // Windows Authentication
            constr = "Data Source = localhost; Initial Catalog = Wishlydb; Integrated Security = True";
            con = new SqlConnection(constr);
            con.Open();
        }

        private void loadDataCustomer()
        {
            ds = new DataSet();
            query = "SELECT * FROM Customer";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Customer");
            dc[0] = ds.Tables["Customer"].Columns[0];
            ds.Tables["Customer"].PrimaryKey = dc;
        }

        private void loadDataProduct()
        {
            ds = new DataSet();
            query = "SELECT * FROM Product";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "Product");
            dc[0] = ds.Tables["Product"].Columns[0];
            ds.Tables["Product"].PrimaryKey = dc;
        }

        private void updateDataProduct()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Product"]);
        }

        private void updateDataCustomer()
        {
            cb = new SqlCommandBuilder(da);
            da = cb.DataAdapter;
            da.Update(ds.Tables["Customer"]);
        }

        private void EditCustomerForm_Load(object sender, EventArgs e)
        {
            koneksi();
            loadDataProduct();

            btnSave.Visible = false;
            btnNext.Visible = true;
            btnNext.BringToFront();
            btnBack.Visible = false;
            tcCustomerForm.SelectedTab = RegistrationPage;

            cbProduct.DisplayMember = "ProductID";
            cbProduct.ValueMember = "ProductID";
            cbProduct.DataSource = ds.Tables["Product"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InputC_KeyPress(object sender, KeyPressEventArgs e)
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

        private void InputPN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}