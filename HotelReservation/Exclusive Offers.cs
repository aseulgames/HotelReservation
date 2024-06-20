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
    public partial class frmExclusiveOffers : Form
    {
        public frmExclusiveOffers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoomOffers2 roomOffers2 = new RoomOffers2();
            roomOffers2.ShowDialog();
        }

        private void frmExclusiveOffers_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
