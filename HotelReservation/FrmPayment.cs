using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class FrmPayment : Form
    {
        public FrmPayment()
        {
            InitializeComponent();
        }

        private void btnCreditcard_Click(object sender, EventArgs e)
        {
            CreditCard frmCreditCard = new CreditCard();
            frmCreditCard.ShowDialog();
            this.Close();
        }

        private void btnGcash_Click_1(object sender, EventArgs e)
        {

            frmCashPayment cash = new frmCashPayment();
            cash.ShowDialog();
            this.Close();
        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
