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
    public partial class frmCashPayment : Form
    {

        public string connectionString = "Data Source=DESKTOP-R59F5FR\\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True";
        bool boolaccname = true;
        bool boolaccnum = true;
        bool boolmpin = true;

        public frmCashPayment()
        {
            InitializeComponent();
        }

        private void cellNumHasFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "91234567891")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }

        }

        private void cellNumNoFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "91234567891";
            }

        }

        private void pinHasFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "****")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }

        }

        private void pinNoFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "****";
            }

        }

        private void register()
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string register = "INSERT INTO GuestInfo(ReferenceID, Fullname, Contact, Email, Address) VALUES('" + lblRefID.Text + "','" + lblFullName.Text + "','" + lblContact.Text + "','" + lblEmail.Text + "','" + lblAddress.Text + "')";
                    SqlCommand command = new SqlCommand(register, connection);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string register = "INSERT INTO RateInfo(ReferenceID, CheckIn, CheckOut, NoOfNights, RoomType, RoomRate, Adults, Children, Total, DiscountCode, RoomNo) VALUES(@ReferenceID, @CheckIn, @CheckOut, @NoOfNights, @RoomType, @RoomRate, @Adults, @Children, @Total, @DiscountCode, @RoomNo)";
                    SqlCommand cmd = new SqlCommand(register, connection);
                    cmd.Parameters.AddWithValue("@ReferenceID", lblRefID.Text); 
                    cmd.Parameters.AddWithValue("@CheckIn", lblDatein.Text);
                    cmd.Parameters.AddWithValue("@CheckOut", lblDateout.Text);
                    cmd.Parameters.AddWithValue("@NoOfNights", lblNoofnights.Text);
                    cmd.Parameters.AddWithValue("@RoomType", lblTypeofroom.Text);
                    cmd.Parameters.AddWithValue("@RoomRate", lblRoomrate.Text);
                    cmd.Parameters.AddWithValue("@Adults", lblNoofadults.Text);
                    cmd.Parameters.AddWithValue("@Children", lblNoofchildren.Text);
                    cmd.Parameters.AddWithValue("@Total", lblTotalamount.Text);
                    cmd.Parameters.AddWithValue("@DiscountCode", lblDiscount.Text);
                    cmd.Parameters.AddWithValue("@RoomNo", lblRoomNo.Text);
                    cmd.ExecuteNonQuery();
                    //txtBoxNights.Clear(); txtBoxRate.Clear(); txtBoxSubTotal.Clear();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string credit = "GCash";
                string paid = "PAID";

                if (connection.State == System.Data.ConnectionState.Open)
                {
                    string register = "INSERT INTO GuestStatus(ReferenceID, FullName, PaymentAmount, PaymentMethod, Status, CheckIn, CheckOut) VALUES('" + lblRefID.Text + "','" + lblFullName.Text + "','" + lblTotalamount.Text + "','" + credit + "','" + paid + "','" + lblDatein.Text + "','" + lblDateout.Text + "')";
                    SqlCommand command = new SqlCommand(register, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Successfully Paid");
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void btnGcashpay_Click(object sender, EventArgs e)
        {
            gcashPayment.SetAccountName = AccName(txtboxAccname.Text);
            gcashPayment.SetAccountNum = AccNum(txtboxCellno.Text);

            //boolaccname == false && boolaccnum == false && boolmpin == false
            if (txtboxAccname.Text != "" && txtboxMpin.Text != "****" && txtboxMpin.Text.Length == 4 && txtboxCellno.Text.Length == 10 && boolaccname == false)
            {
                if (MessageBox.Show("You can't cancel a reservation. Do you want to confirm payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    register();
                    frmGcashFinalSummary gcashfinal = new frmGcashFinalSummary();
                    gcashfinal.ShowDialog();
                    
                    this.Close();
                } 
            }
            else
            {
                MessageBox.Show("Please fill up form correctly");
            }

        }

        private void frmCashPayment_Load(object sender, EventArgs e)
        {
            txtboxCellno.Text = "91234567891";
            txtboxCellno.ForeColor = Color.Gray;
            txtboxCellno.GotFocus += new EventHandler(this.cellNumHasFocus);
            txtboxCellno.LostFocus += new EventHandler(this.cellNumNoFocus);

            txtboxMpin.Text = "****";
            txtboxMpin.ForeColor = Color.Gray;
            txtboxMpin.GotFocus += new EventHandler(this.pinHasFocus);
            txtboxMpin.LostFocus += new EventHandler(this.pinNoFocus);

            lblFullName.Text = InformationClass.SetFullname.ToString();
            lblRefID.Text = InformationClass.SetRefid.ToString();
            lblContact.Text = InformationClass.SetContact.ToString();
            lblEmail.Text = InformationClass.SetEmail.ToString();
            lblAddress.Text = InformationClass.SetAddress.ToString();
            lblDatein.Text = InformationClass.SetDatein.ToString();
            lblDateout.Text = InformationClass.SetDateout.ToString();
            lblNoofnights.Text = InformationClass.SetNoofnights.ToString();
            lblDiscount.Text = InformationClass.SetDiscount.ToString();
            lblTypeofroom.Text = InformationClass.SetTypeofroom.ToString();
            lblNoofadults.Text = InformationClass.SetNoofadults.ToString();
            lblNoofchildren.Text = InformationClass.SetNoofchildren.ToString();
            lblRoomrate.Text = InformationClass.SetRoomrate.ToString();
            lblTotalamount.Text = InformationClass.SetTotalamount.ToString();
            txtBoxAmount.Text = InformationClass.SetTotalamount.ToString();
            lblRoomNo.Text = InformationClass.SetRoomNo.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the reservation? All data will be disregarded", "Registration Cancelled", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtboxAccname_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtboxAccname.Text, "^[0-9]{1}$"))
            {
                MessageBox.Show("You have entered invalid characters");
                txtboxAccname.Clear();
            }
        }

        private void txtboxCellno_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtboxCellno.Text, "^[a-zA-Z]{1}$"))
            {
                MessageBox.Show("You have entered invalid characters");
                txtboxCellno.Clear();
            }
        }

        private void txtboxMpin_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtboxMpin.Text, "^[a-zA-Z]{1}$"))
            {
                MessageBox.Show("You have entered invalid characters");
                txtboxMpin.Clear();
            }
        }

        private void txtBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private static string _AccName;
        private static string _AccNum;
        private static string _MPIN;

        public string AccName(string accname)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(accname, "^[a-zA-Z\\s ]{1,20}$"))
                    {
                        boolaccname = false;
                        _AccName = accname;
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
                return _AccName;
            } while (boolaccname != false);

        }

        public string AccNum(string accnum)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(accnum, "^[0-9]{10}$"))
                    {
                        boolaccnum = false;
                        _AccNum = accnum;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid Account Number");
                }
                return _AccNum;

            } while (boolaccnum != false);
        }

        public string MPIN(string mpin)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(mpin, "^[0-9]{4}$"))
                    {
                        boolmpin = false;
                        _MPIN = mpin;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid MPIN");
                }
                return _MPIN;

            } while (boolmpin != false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
