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

namespace HotelReservation
{
    public partial class frmHotelRooms : Form
    {
        public string connectionString = "Data Source=DESKTOP-R59F5FR\\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True";
        public frmHotelRooms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillSuite()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Rooms WHERE RoomType = 'Suite'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                string availability = (string)dr["RoomAvailability"].ToString();
                if (availability == "Available")
                {
                    txtBoxSuite.Text = availability;
                    txtBoxSuite.BackColor = Color.PaleGreen;
                }
                else
                {
                    txtBoxSuite.Text = availability;
                    txtBoxSuite.BackColor = Color.LightCoral;
                }
            }
            connection.Close();
        }

        

        private void fillDeluxe()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM Rooms WHERE RoomType = 'Deluxe Room'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                string availability = (string)dr["RoomAvailability"].ToString();
                if (availability == "Available")
                {
                    txtBoxDeluxe.Text = availability;
                    txtBoxDeluxe.BackColor = Color.PaleGreen;
                }
                else
                {
                    txtBoxDeluxe.Text = availability;
                    txtBoxDeluxe.BackColor = Color.LightCoral;
                }
            }
        }

        

        private void frmHotelRooms_Load(object sender, EventArgs e)
        {
            fillSuite();
            fillDeluxe();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmExclusiveOffers exclusive = new frmExclusiveOffers();
            exclusive.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoomPage2 roomPage2 = new RoomPage2();
            roomPage2.ShowDialog();
        }
    }
}
