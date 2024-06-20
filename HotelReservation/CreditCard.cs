using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelReservation.Program;

namespace HotelReservation
{
    public partial class CreditCard : Form
    {
        public string connectionString = "Data Source=DESKTOP-R59F5FR\\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True";
        bool boolcardname = true;
        bool boolcardnum = true;

        public CreditCard()
        {
            InitializeComponent();
        }
        
            private void cardNumHasFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "**** **** **** ****")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }

        }

        private void cardNumNoFocus(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                tb.Text = "**** **** **** ****";
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
                string credit = "Credit Card";
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

        private void btncardPay_Click(object sender, EventArgs e)
        {
            InformationClass.SetFullname = lblFullName.Text;
            InformationClass.SetRefid = lblRefID.Text;
            creditNum.SetCardName = CardName(txtboxCardNameHolder.Text);
            creditNum.SetCardNumber = CardNumber(txtboxCardNumber.Text);

            //InformationClass.setCardNumber = txtboxCardNumber.Text.ToString();
            

                if (txtboxCardNumber.Text.Length == 16 && txtboxCardNumber.Text != "**** **** **** ****" && txtboxMMYY.Text.Length == 4 && txtboxMMYY.Text != "****" && boolcardname == false && boolcardnum == false)
                {
                    if (MessageBox.Show("You can't cancel a reservation. Do you want to confirm payment?", "Payment Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        register();
                        CreditFinalSummary creditFinal = new CreditFinalSummary();
                        creditFinal.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill up form correctly");
                }

            
        }

        private void CreditCard_Load(object sender, EventArgs e)
        {
            txtboxCardNumber.Text = "**** **** **** ****";
            txtboxCardNumber.ForeColor = Color.Gray;
            txtboxCardNumber.GotFocus += new EventHandler(this.cardNumHasFocus);
            txtboxCardNumber.LostFocus += new EventHandler(this.cardNumNoFocus);

            txtboxMMYY.Text = "****";
            txtboxMMYY.ForeColor = Color.Gray;
            txtboxMMYY.GotFocus += new EventHandler(this.pinHasFocus);
            txtboxMMYY.LostFocus += new EventHandler(this.pinNoFocus);
            
            lblDatein.Text = InformationClass.SetDatein.ToString();
            lblDateout.Text = InformationClass.SetDateout.ToString();
            lblNoofnights.Text = InformationClass.SetNoofnights.ToString();
            lblDiscount.Text = InformationClass.SetDiscount.ToString();
            lblTypeofroom.Text = InformationClass.SetTypeofroom.ToString();
            lblNoofadults.Text = InformationClass.SetNoofadults.ToString();
            lblNoofchildren.Text = InformationClass.SetNoofchildren.ToString();
            lblRoomrate.Text = InformationClass.SetRoomrate.ToString();
            lblTotalamount.Text = InformationClass.SetTotalamount.ToString();
            txtboxAmount.Text = InformationClass.SetTotalamount.ToString();
            lblRefID.Text = InformationClass.SetRefid.ToString();
            lblFullName.Text = InformationClass.SetFullname.ToString();
            lblContact.Text = InformationClass.SetContact.ToString();
            lblEmail.Text = InformationClass.SetEmail.ToString();
            lblAddress.Text = InformationClass.SetAddress.ToString();
            lblRoomNo.Text = InformationClass.SetRoomNo.ToString();
            
        }
        
        private static string _CardName;
        private static string _CardNumber;
        
        public string CardName (string cardname)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(cardname, "^[a-zA-Z\\s]{1,20}$"))
                    {
                        boolcardname = false;
                        _CardName = cardname;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid Card Name");
                }
                return _CardName;

            } while (boolcardname != false);
            
        }

        public string CardNumber(string cardnumber)
        {
            do
            {
                try
                {
                    if (Regex.IsMatch(cardnumber, "^[0-9]{16}$"))
                    {
                        boolcardnum = false;
                        _CardNumber = cardnumber;
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Invalid Card Number");
                }
                return _CardNumber;

            } while (boolcardnum != false);
        }

        private void txtboxCardNameHolder_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtboxCardNameHolder.Text, "^[0-9]{1}$"))
            {
                MessageBox.Show("You have entered invalid characters");
                txtboxCardNameHolder.Clear();
            }
        }

        private void txtboxCardNumber_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtboxCardNumber.Text, "^[a-zA-Z]{1}$"))
            {
                MessageBox.Show("You have entered invalid characters");
                txtboxCardNumber.Clear();
            }
        }

        private void txtboxMMYY_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtboxMMYY.Text, "^[a-zA-Z]{1}$"))
            {
                MessageBox.Show("You have entered invalid characters");
                txtboxMMYY.Clear();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to cancel the reservation? All data will be disregarded", "Registration Cancelled", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }    
}
