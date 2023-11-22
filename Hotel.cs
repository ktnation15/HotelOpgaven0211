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

namespace HotelOpgaven0211
{
    public partial class Hotel : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Hotel()
        {
            InitializeComponent();
        }

        private void Hotel_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDatabase;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void InsertHotelBtn_Click_1(object sender, EventArgs e)
        {
            string query = $"insert into Hotel values('{txtHotelNo.Text.ToString()}','{txtName.Text}','{txtAddress.Text}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }
        private void cleardata()
        {
            txtHotelNo.Clear();
            txtName.Clear();
            txtAddress.Clear();
        }

        private void UpdateHotelBtn_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Hotel set Name='" + txtName.Text + "',Address='" + txtAddress.Text + "' where Hotel_No='" + txtHotelNo.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void ShowAllHotelBtn_Click_1(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Hotel";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewHotel.DataSource = dt;
            conn.Close();
        }

        private void DeleteHotelBtn_Click(object sender, EventArgs e)
        {
            string query = $"delete Hotel where Hotel_No='{txtHotelNo.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridViewHotel.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void FindHotelBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Hotel where Hotel_No='" + FindBarHotel.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtName.Text = dt.ToString();
            txtAddress.Text = dt.ToString();
            dataGridViewHotel.DataSource = dt;
            conn.Close();
        }

        private void ExitHotelBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuHotelBtn_Click(object sender, EventArgs e)
        {
            new MainMenu();
        }

        private void dataGridViewHotel_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
