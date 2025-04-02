using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Autorization
{
    public partial class MainPage : Form
    {
        public MainPage()
        {            
            InitializeComponent();

        }

 

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Create_Workout_Click(object sender, EventArgs e)
        {
            this.Hide();
            WorkoutForm workoutForm = new WorkoutForm();
            workoutForm.Show();
            this.UserName.Text = workoutForm.UserName.Text;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MainPage_FormClosing(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            int userId;
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                DataBase db = new DataBase();
                string queryString1 = $"SELECT Id FROM users WHERE Login = {UserName.Text}";
                SqlCommand command1 = new SqlCommand(queryString1, db.getConnection());
                db.OpenConnection();
                
                SqlDataReader reader = command1.ExecuteReader();
                reader.Read();
                userId = reader.GetInt32(0);
                reader.Close();
                string queryString2 = $"SELECT * FROM Workouts WHERE userId = '{userId}'";
                SqlCommand command2 = new SqlCommand(queryString1, db.getConnection());
                reader = command2.ExecuteReader();
                string info = reader.ToString();
                reader.Close();
                ListViewItem listViewItem = new ListViewItem(info);
                WorkoutsList.Items.Add(listViewItem);
            }
            catch(Exception ex)  
            {
                userId = 3;
            }
        }
    }
}
