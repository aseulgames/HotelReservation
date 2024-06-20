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
    public partial class frmHotelReservation : Form
    {
        //string that contains information about the data source
        public string connectionString = "Data Source=DESKTOP-R59F5FR\\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True";
        public static System.Data.DataRow Row { get; set; }
        double val = 0;
        string idDefault = "2000";
        string roomNoDefault = "5";

        bool fullname = true;
        bool boolemail = true;
        bool booladdress = true;
        bool boolroomtype = true;
        bool boolphoneNo = true;


        public frmHotelReservation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Supposedly, after clicking proceed to payment button is mag reregister na lahat ng input, but caused a lot of error so nilipat nalang
        //which explains this long *** comment code 
        //private void register()
        //{
        //    try
        //    {
        //        SqlConnection connection = new SqlConnection(connectionString);
        //        connection.Open();

        //        if (connection.State == System.Data.ConnectionState.Open)
        //        {
        //            string register = "INSERT INTO GuestInfo(ReferenceID, FirstName, LastName, Contact, Email, Address) VALUES('" + txtBoxRefID.Text.ToString() + "','" + txtBoxFN.Text + "','" + txtBoxLN.Text + "','" + txtBoxContact.Text + "','" + txtBoxEmail.Text + "','" + txtBoxAddress.Text + "')";
        //            SqlCommand command = new SqlCommand(register, connection);
        //            command.ExecuteNonQuery();

        //            //txtBoxFN.Clear(); txtBoxLN.Clear(); txtBoxContact.Clear(); txtBoxEmail.Clear(); txtBoxAddress.Clear();
        //        }
        //        connection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }

        //    try
        //    {
        //        SqlConnection connection = new SqlConnection(connectionString);
        //        connection.Open();

        //        if (connection.State == System.Data.ConnectionState.Open)
        //        {
        //            SqlCommand cmd = connection.CreateCommand();
        //            cmd.CommandType = CommandType.Text;

        //            cmd.CommandText = "INSERT INTO RateInfo(ReferenceID, CheckIn, CheckOut, NoOfNights, RoomType, RoomRate, Adults, Children, Total, DiscountCode, RoomNo) VALUES(@ReferenceID, @CheckIn, @CheckOut, @NoofNights, @RoomType, @RoomRate, @Adults, @Children, @Total, @DiscountCode, @RoomNo)";

        //            cmd.Parameters.AddWithValue("@ReferenceID", txtBoxRefID.Text);
        //            cmd.Parameters.AddWithValue("@CheckIn", StartDateTimePicker.Value.Date.ToString("yyyy-MM-dd"));
        //            cmd.Parameters.AddWithValue("@CheckOut", EndDateTimePicker.Value.Date.ToString("yyyy-MM-dd"));
        //            cmd.Parameters.AddWithValue("@NoOfNights", txtBoxNights.Text);
        //            cmd.Parameters.AddWithValue("@RoomType", cbRooms.Text);
        //            cmd.Parameters.AddWithValue("@RoomRate", txtBoxRate.Text);
        //            cmd.Parameters.AddWithValue("@Adults", numericAdult.Text);
        //            cmd.Parameters.AddWithValue("@Children", numericChildren.Text);
        //            cmd.Parameters.AddWithValue("@Total", txtBoxSubTotal.Text);
        //            cmd.Parameters.AddWithValue("@DiscountCode", cbDiscount.Text);
        //            cmd.Parameters.AddWithValue("@RoomNo", txtBoxRoomNo.Text);
        //            cmd.ExecuteNonQuery();
        //            //txtBoxNights.Clear(); txtBoxRate.Clear(); txtBoxSubTotal.Clear();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //delegates - setting values
            InformationClass.SetFullname = FullName(txtBoxFN.Text, txtBoxLN.Text);
            InformationClass.SetRefid = txtBoxRefID.Text;
            InformationClass.SetContact = PhoneNumber(txtBoxContact.Text);
            InformationClass.SetEmail = Email(txtBoxEmail.Text);
            InformationClass.SetAddress = txtBoxAddress.Text;
            InformationClass.SetDatein = StartDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            InformationClass.SetDateout = EndDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            InformationClass.SetNoofnights = txtBoxNights.Text;
            InformationClass.SetDiscount = cbDiscount.Text;
            InformationClass.SetTypeofroom = cbRooms.Text;
            InformationClass.SetNoofadults = numericAdult.Text;
            InformationClass.SetNoofchildren = numericChildren.Text;
            InformationClass.SetRoomrate = txtBoxRate.Text;
            InformationClass.SetTotalamount = txtBoxSubTotal.Text;
            InformationClass.SetRoomNo = txtBoxRoomNo.Text;

            //if else statement to validate textboxes
            if (numericAdult.Value >=1 && txtBoxFN.Text != "" && txtBoxLN.Text != "" && txtBoxContact.Text != "91234567891" && txtBoxAddress.Text != "" && txtBoxEmail.Text != "" && cbRooms.Text != "" && txtBoxSubTotal.Text != "" && txtBoxAddress.Text != "" && EndDateTimePicker.Text != "" && txtBoxNights.Text != "" && fullname == false && boolemail == false && boolphoneNo == false)
            {
                FrmPayment frmPayment = new FrmPayment();
                frmPayment.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill up form correctly");
            }
        }

        private void autoRefID()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(ReferenceID) FROM [GuestInfo]", connection);
                long n = Convert.ToInt64(command.ExecuteScalar());
                connection.Close();
                n++;
                Random random = new Random();
                long num = random.Next(100000, 900000);
                txtBoxRefID.Text = idDefault + num + n.ToString();
                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        //method that generates room number that is still not claimed in the database
        private void autoRoomNo()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(RoomNo) FROM [RateInfo]", connection);
                int n = Convert.ToInt32(command.ExecuteScalar());
                connection.Close();
                n++;
                txtBoxRoomNo.Text = roomNoDefault + val + n.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        

        private void frmHotelReservation_Load(object sender, EventArgs e)
        {
            autoRefID();
            fillcbRooms();
            fillcbDiscount();
            
           
            if (cbDiscount.Items.Count == '0')
            {
                
                cbDiscount.Items.Add("No Available Promo");
            }
           

            //contact number guide text
            txtBoxContact.Text = "91234567891";
            txtBoxContact.ForeColor = Color.Gray;
            txtBoxContact.GotFocus += new EventHandler(this.ContactHasFocus);
            txtBoxContact.LostFocus += new EventHandler(this.ContactNoFocus);
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            txtBoxDiscAmount.Clear();
            txtBoxDiscPercent.Clear();
            cbDiscount.Items.Clear();
            cbDiscount.ResetText();
            EndDateTimePicker.MinDate = StartDateTimePicker.Value.AddDays(1);
            //System.DateTime start = StartDateTimePicker.Value;

            string start = StartDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM DiscountCode WHERE StartDate = '" + start + "'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            for(int i = 0; i<dataTable.Rows.Count; i++)
            {
                cbDiscount.Items.Add(dataTable.Rows[i]["DiscountCode"]);
            }

            connection.Close();
        }

        //method for automated counting of number of nights

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            System.DateTime start = StartDateTimePicker.Value;
            System.DateTime end = EndDateTimePicker.Value;
            System.TimeSpan numofDays = end - start;
            int totalDays = numofDays.Days;


            if (totalDays >= 1)
            {
                txtBoxNights.Text = totalDays.ToString();
            } else
            {
                MessageBox.Show("Please choose valid date");
            }
        }

        //method that puts all room types in combobox IF "Available" from database
        private void fillcbRooms()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            //Roomtype's availability should be "available" otherwise it won't be included in the cbbox
            string query = "SELECT * FROM Rooms WHERE RoomAvailability = 'Available'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cbRooms.Items.Add(dataTable.Rows[i]["RoomType"]);
            }
            connection.Close();
        }

        //user chose room type from combobox
        private void cbRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //takes combobox text to identify row from database
            string query = "SELECT * FROM Rooms WHERE RoomType = '"+cbRooms.Text+"'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                //getting and printing cost of chosen room
                string price = (string)dr["Cost"].ToString();
                txtBoxRate.Text = price;
            }

            try
            {
                //all float necessary for subtotal + fees
                float i, n, j, subtotal, finaltotal;
                float.TryParse(txtBoxNights.Text, out i);
                float.TryParse(txtBoxDiscAmount.Text, out j);
                float.TryParse(txtBoxRate.Text, out n);
                subtotal = (i * n) + 1019;
                finaltotal = subtotal - (j * subtotal);

                txtBoxSubTotal.Text = finaltotal.ToString("c").Remove(0, 1);
                
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            autoRoomNo();
        }

        private void fillcbDiscount()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string start = StartDateTimePicker.Value.Date.ToString("yyyy-MM-dd");
            string query = "SELECT * FROM DiscountCode WHERE StartDate = '" +start+"'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();


            DataTable dataTable = new DataTable();

            dataAdapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                cbDiscount.Items.Add(dataTable.Rows[i]["DiscountCode"]);
            }
            connection.Close();
        }

        private void cbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM DiscountCode WHERE DiscountCode = '" + cbDiscount.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string price = (string)dr["Percentage"].ToString();
                    txtBoxDiscPercent.Text = price;
                }
                connection.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM DiscountCode WHERE DiscountCode = '" + cbDiscount.Text + "'";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    string price = (string)dr["PriceDiscount"].ToString();
                    txtBoxDiscAmount.Text = price;
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ContactHasFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "91234567891")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }

        }

        private void ContactNoFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "91234567891";
            }

        }

        private static string _FullName, _Email, _Address, _Roomtype, _PhoneNo;

        /////return methods 
        public string FullName(string LastName, string FirstName)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(LastName, "^[a-zA-Z\\s]{1,20}$") && Regex.IsMatch(FirstName, "^[a-zA-Z\\s]{1,20}$"))
                    {
                        fullname = false;
                        _FullName = LastName + ", " + FirstName;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid FullName");
                }
                return _FullName;

            } while (fullname !=false); 
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            cbDiscount.SelectedItem = null;
            cbDiscount.SelectedText = String.Empty;
            cbDiscount.Items.Clear();
            txtBoxDiscAmount.Clear();
            txtBoxDiscPercent.Clear();
        }

        private void txtBoxContact_TextChanged(object sender, EventArgs e)
        {

        }

        public string PhoneNumber(string PhonNum)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(PhonNum, "^[0-9]{10}$"))
                    {
                        boolphoneNo = false;
                        _PhoneNo = PhonNum;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid Phone Number");
                }
                return _PhoneNo;

            } while (boolphoneNo != false);

        }

        public string Email(string email)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(email, "^[a-zA-Z0-9]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$"))
                    {
                        boolemail = false;
                        _Email = email;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid Email");
                }
                return _Email;

            } while (boolemail != false);
            
        }

        public string Address(string address)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(address, "^[a-zA-Z0-9]{1,30}$"))
                    {
                        booladdress = false;
                        _Address = address;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid Adress");
                }
                return _Address;
            } while (booladdress != false);
            
        }

        public string Roomtype(string roomtype)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(roomtype, "^{1}$"))
                    {
                        boolroomtype = false;
                        _Roomtype = roomtype;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Inalid Room Type");
                }
                return _Roomtype;

            } while (boolroomtype != false);
            
        }
    }
}
