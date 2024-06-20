using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            frmHotelReservation reserve = new frmHotelReservation();
            reserve.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLblPrivacy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPrivacyPolicy privacy = new frmPrivacyPolicy();
            privacy.ShowDialog();
        }

        private void btnRoomavail_Click(object sender, EventArgs e)
        {
            frmHotelRooms rooms = new frmHotelRooms();
            rooms.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSearch frmSearch = new FrmSearch();
            frmSearch.ShowDialog();
        }
    }
}
