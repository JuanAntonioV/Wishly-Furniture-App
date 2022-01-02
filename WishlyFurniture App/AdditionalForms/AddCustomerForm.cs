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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        #region SQL CONECTION CLIENT VARIABEL

        private SqlConnection con;
        private string constr;
        private string query;
        private DataSet ds;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        #endregion SQL CONECTION CLIENT VARIABEL

        private void koneksi()
        {
            // Windows Authentication
            constr = "Data Source = localhost; Initial Catalog = Wishlydb; Integrated Security = True";
            con = new SqlConnection(constr);
            con.Open();
        }

        private void loadDataCB()
        {
            try
            {
                ds = new DataSet();
                query = "SELECT ProductName, ProductID FROM Product";
                da = new SqlDataAdapter(query, con);
                da.Fill(ds, "Product");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {
            koneksi();
            loadDataCB();

            btnSave.Visible = false;
            btnNext.Visible = true;
            btnNext.BringToFront();
            btnBack.Visible = false;
            tcCustomerForm.SelectedTab = RegistrationPage;

            cbProduct.DisplayMember = "ProductID";
            cbProduct.ValueMember = "ProductID";
            cbProduct.DataSource = ds.Tables["Product"];

            con.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer Registration Form Cleared!", "Customer Registration", MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtCustomerID.Clear();
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtAddress.Clear();
            txtQTY.Clear();
            dgProduct.Rows.Clear();
            TotalPrice.Text = "Rp 0";
            cbProduct.Text = "";
            txtCustomerID.Focus();
        }

        private void InputCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }

        }

        private void InputPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void addingData()
        {
            try
            {
                cmd = new SqlCommand("INSERT INTO Customer VALUES (@CustomerId, @Name, @PhoneNumber, @ProductID, @QTY, @Address, @Status)", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text);

                foreach (DataGridViewRow row in dgProduct.Rows)
                {
                    cmd.Parameters.AddWithValue("@ProductID", row.Cells["ProductID"].Value);
                    cmd.Parameters.AddWithValue("@QTY", row.Cells["QTY"].Value);
                }

                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Status", "Not Paid");
                cmd.ExecuteNonQuery();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void updatingDataStock()
        {
            try
            {
                cmd = new SqlCommand("UPDATE Product SET Stock = @stock WHERE ProductID = @ID", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@stock", Convert.ToInt32(viewStock.Text) - Convert.ToInt32(txtQTY.Text));
                cmd.Parameters.AddWithValue("@ID", cbProduct.Text);
                cmd.ExecuteNonQuery();                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please input the Customer ID!","Customer Registration",MessageBoxButtons.OK,MessageBoxIcon.Information);
                tcCustomerForm.SelectedTab = RegistrationPage;
                txtCustomerID.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Please input the Fullname!", "Customer Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tcCustomerForm.SelectedTab = RegistrationPage;
                txtName.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please input the Phone Number!", "Customer Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tcCustomerForm.SelectedTab = RegistrationPage;
                txtPhoneNumber.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Please input the Address!", "Customer Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tcCustomerForm.SelectedTab = RegistrationPage;
                txtAddress.Focus();
            }
            else if (dgProduct.RowCount <= 0)
            {
                MessageBox.Show("Please Add Your Product Order!", "Customer Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                koneksi();
                addingData();
                updatingDataStock();
                MessageBox.Show("Data Saved!","Customer Registration Form",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                con.Close();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tcCustomerForm.SelectedTab = PurchaseOrderPage;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcCustomerForm.SelectedTab = RegistrationPage;
        }

        private void tcCustomerForm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcCustomerForm.SelectedTab == PurchaseOrderPage)
            {
                btnSave.BringToFront();
                btnNext.Visible = false;
                btnBack.Visible = true;
                btnSave.Visible = true;
            }
            else
            {
                btnSave.Visible = false;
                btnBack.Visible = false;
                btnNext.Visible = true;
                btnNext.BringToFront();
            }
        }

        private void loadDataChangeCB()
        {
            cmd = new SqlCommand("SELECT ProductName FROM Product WHERE ProductID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", cbProduct.Text);
            viewProductName.Text = cmd.ExecuteScalar().ToString();            
            viewProductID.Text = cbProduct.Text;
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            koneksi();
            loadDataChangeCB();
            cmd = new SqlCommand("SELECT Stock FROM Product WHERE ProductID = @ID", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", cbProduct.Text);
            viewStock.Text = cmd.ExecuteScalar().ToString();
        }

        private void InputMaxQTY_KeyPress(object sender, KeyPressEventArgs e)
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

        private int pcsPrice = 0;

        private void loadDataPrice()
        {
            cmd = new SqlCommand("SELECT Price FROM Product WHERE ProductID = @ID",con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@ID", cbProduct.Text);
            pcsPrice = Convert.ToInt32(cmd.ExecuteScalar().ToString());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            koneksi();
            loadDataPrice();

            if (Convert.ToInt32(txtQTY.Text) > Convert.ToInt32(viewStock.Text))
            {
                MessageBox.Show("Quantity Tidak Mencukupi!","Purchase Order",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                for(int i = 0; i <= dgProduct.Rows.Count; i++)
                {
                    dgProduct.Rows.Add(viewProductID.Text, viewProductName.Text, txtQTY.Text, pcsPrice);
                    break;
                }
                int total = Convert.ToInt32(txtQTY.Text) * pcsPrice;
                TotalPrice.Text = total.ToString("Rp #,##0");
            }
            con.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            pcsPrice = 0;
            TotalPrice.Text = "Rp 0";
            if(dgProduct.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgProduct.SelectedRows)
                {
                    dgProduct.Rows.RemoveAt(row.Index);
                }
            }
            else
            {
                MessageBox.Show("Please select the Data to Remove it!");
            }
        }

        private void InputCName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void InputCAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Space) && e.KeyChar != (char)'.')
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
