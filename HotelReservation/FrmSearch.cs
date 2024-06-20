using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelReservation.Program;

namespace HotelReservation
{
    public partial class FrmSearch : Form
    {
        public string connectionString = "Data Source=DESKTOP-R59F5FR\\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True";

        public FrmSearch()
        {
            InitializeComponent();
        }

        private void searchStatus()
        {
            try
            {
                dataGridView3.Visible = true;
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM GuestStatus WHERE ReferenceID = '" + txtBoxSearch.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                DataTable dt = new DataTable();
                //to determine whether entered value exists in database
                if (command.ExecuteScalar()!=null)
                {
                    this.guestStatusTableAdapter5.Fill(this.hotelReservationDataSet7.GuestStatus);
                    dataAdapter.Fill(dt);
                    dataGridView3.DataSource = dt;
                    button1.Visible = true;
                    RefID.SetRefIDSearch = txtBoxSearch.Text;
                } else
                {
                    MessageBox.Show("Please enter valid Reference ID");
                    txtBoxSearch.Clear();
                }


                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelReservationDataSet7.GuestStatus' table. You can move, or remove it, as needed.
            dataGridView3.Visible = false;
            button1.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchStatus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchReceipt searchReceipt = new SearchReceipt();
            searchReceipt.ShowDialog(this);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
                if (Regex.IsMatch(txtBoxSearch.Text, "^[a-zA-Z]{1,20}$"))
                {
                    MessageBox.Show("You have entered invalid characters");
                    txtBoxSearch.Clear();
                }
        }
    }
    
}
