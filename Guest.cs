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
    public partial class Guest : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        public Guest()
        {
            InitializeComponent();
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HotelDatabase;Integrated Security=True");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void InsertGuestBtn_Click(object sender, EventArgs e)
        {
            string query = $"insert into Guest values('{txtGuestNo.Text.ToString()}','{txtName.Text}','{txtAddress.Text}')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            cleardata();
            conn.Close();
            displaydata();
        }
        private void cleardata()
        {
            txtGuestNo.Clear();
            txtName.Clear();
            txtAddress.Clear();
        }

        private void UpdateGuestBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Guest set Name='" + txtName.Text + "',Address='" + txtAddress.Text + "' where Guest_No='" + txtGuestNo.Text.ToString() + "' ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displaydata();
            cleardata();
        }

        private void ShowAllGuestBtn_Click(object sender, EventArgs e)
        {
            displaydata();
        }
        private void displaydata()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Guest";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewGuest.DataSource = dt;
            conn.Close();
        }

        private void DeleleGuestBtn_Click(object sender, EventArgs e)
        {
            string query = $"delete Guest where Guest_No='{txtGuestNo.Text.ToString()}'";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            dataGridViewGuest.DataSource = query;
            cleardata();
            conn.Close();
            displaydata();
        }

        private void FindGuestBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Guest where Guest_No='" + FindBarGuest.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            txtName.Text = dt.ToString();
            txtAddress.Text = dt.ToString();
            dataGridViewGuest.DataSource = dt;
            conn.Close();
        }

        private void ExitGuestBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuGuestBtn_Click(object sender, EventArgs e)
        {
            new MainMenu();
        }

        private void dataGridViewGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
