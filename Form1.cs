using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelOpgaven0211
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Run(new Hotel());
        }

        private void MmBookingBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            BookingLbl bookingForm = new BookingLbl();
            bookingForm.ShowDialog();
        }

        private void MmFacilitiesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            FacilitiesFacilityIDLbl facilitiesFacilityIDLbl = new FacilitiesFacilityIDLbl();
            facilitiesFacilityIDLbl.ShowDialog();
        }
    }
}
