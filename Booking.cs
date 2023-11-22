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
using System.Xml.Linq;

namespace HotelOpgaven0211
{
    public partial class BookingLbl : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public BookingLbl()
        {
            InitializeComponent();
        }

        private void BookingLbl_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDatabase;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void InsertBookingBtn_Click(object sender, EventArgs e)
        {
            string query = $"insert into Booking values('{txtBookingId.Text.ToString()}','{txtHotelNo.Text}','{txtGuestNo.Text}','{txtRoomNo.Text.ToString()}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }
        private void cleardata()
        {
            txtBookingId.Clear();
            txtHotelNo.Clear();
            txtGuestNo.Clear();
            txtRoomNo.Clear();
        }

        private void UpdateBookingBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Booking set Hotel_No='" + txtHotelNo.Text + "',Guest_No='" + txtGuestNo.Text + "',Room_No='" + txtRoomNo.Text.ToString() + "' where Booking_id='" + txtBookingId.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void ShowAllBookingBtn_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Booking";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewBooking.DataSource = dt;
            conn.Close();
        }

        private void DeleteBookingBtn_Click(object sender, EventArgs e)
        {
            string query = $"delete Booking where Booking_id='{txtBookingId.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridViewBooking.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void FindBookingBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Booking where Booking_id='" + FindBar.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtHotelNo.Text = dt.ToString();
            txtGuestNo.Text = dt.ToString();
            txtRoomNo.Text = dt.ToString();
            dataGridViewBooking.DataSource = dt;
            conn.Close();
        }

        private void ExitBookingBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBookingId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
