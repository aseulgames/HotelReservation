using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelReservation.Program;

namespace HotelReservation
{
    public partial class CreditFinalSummary : Form
    {
        public string connectionString = "Data Source=DESKTOP-R59F5FR\\SQLEXPRESS;Initial Catalog=HotelReservation;Integrated Security=True";
        public CreditFinalSummary()
        {
            InitializeComponent();
        }
        
        
        private void CreditFinalSummary_Load(object sender, EventArgs e)
        { 
            
            lblFullname.Text = InformationClass.SetFullname.ToString();
            lblRefid.Text = InformationClass.SetRefid.ToString();
            lblContact.Text = InformationClass.SetContact.ToString();
            lblEmail.Text = InformationClass.SetEmail.ToString();
            lblAddress.Text = InformationClass.SetAddress.ToString();
            lblDatein.Text = InformationClass.SetDatein.ToString();
            lblDateout.Text = InformationClass.SetDateout.ToString();
            lblNoofnights.Text = InformationClass.SetNoofnights.ToString();
            lblDiscount.Text = InformationClass.SetDiscount.ToString();
            lblTypeofroom.Text = InformationClass.SetTypeofroom.ToString();
            lblNoofadults.Text = InformationClass.SetNoofadults.ToString();
            lblNoofChildren.Text = InformationClass.SetNoofchildren.ToString();
            lblRoomrate.Text = InformationClass.SetRoomrate.ToString();
            lbltotal.Text = InformationClass.SetTotalamount.ToString();
            labelAccname.Text = creditNum.SetCardName.ToString();
            labelCellno.Text = creditNum.SetCardNumber.ToString().Replace('1', '*').Replace('3', '*').Replace('5', '*').Replace('7', '*').Replace('9', '*').Replace('0', '*');
            lblRoomNo.Text = InformationClass.SetRoomNo.ToString();
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
