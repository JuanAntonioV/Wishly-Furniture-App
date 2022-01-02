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
    public partial class Purchase : Form
    {
        public Purchase()
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
            query = "SELECT * FROM dbo.Customer";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "customerData");
        }

        private void tampilData()
        {
            lblTotalCustomer.Text = ds.Tables["customerData"].Rows.Count.ToString();
            dgCustomer.DataSource = ds.Tables["customerData"];
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            koneksi();
            loadData();
            tampilData();
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            koneksi();
            cmd.CommandText = "UPDATE Customer SET Status = 'Paid' WHERE CustomerID = '" + dgCustomer.SelectedRows[0].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Changes!");
            loadData();
            tampilData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            koneksi();
            cmd.CommandText = "DELETE FROM Customer WHERE CustomerID = '" + dgCustomer.SelectedRows[0].Cells[0].Value.ToString() + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted!");
            loadData();
            tampilData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var AddCustomer = new AdditionalForms.AddCustomerForm();
            AddCustomer.Closed += (s, args) => this.Close();
            AddCustomer.Show();
        }
    }
}
