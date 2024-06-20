using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HotelReservation.Program;

namespace HotelReservation
{
    public partial class frmGcashFinalSummary : Form
    {
        public frmGcashFinalSummary()
        {
            InitializeComponent();
        }

        private void frmGcashFinalSummary_Load(object sender, EventArgs e)
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
            lblTotalamount.Text = InformationClass.SetTotalamount.ToString();
            labelAccname.Text = gcashPayment.SetAccountName.ToString();
            labelCellno.Text = gcashPayment.SetAccountNum.ToString().Replace('1', '*').Replace('3', '*').Replace('5', '*').Replace('7', '*').Replace('9', '*').Replace('0', '*');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
