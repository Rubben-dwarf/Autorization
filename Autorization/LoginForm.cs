using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorization
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        DataBase DataBase = new DataBase();
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Log_button_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

                string login = Login.Text;
                string pass = Pass.Text;
                string Hashed = PasswordHasher.HashPassword(pass);
                Console.WriteLine(Hashed);

                string queryString = $"SELECT Id, Login, Password FROM users WHERE Login = '{login}' AND Password = '{Hashed}'";
                SqlCommand command = new SqlCommand(queryString, DataBase.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 1)
                {
                    Note.ForeColor = Color.Green;
                    Note.Text = "Вы Вошли!";
                    Login.Text = "";
                    Pass.Text = "";
                    login = "";
                    pass = "";
                    Hashed = "";
                    MainPage main = new MainPage();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    Note.ForeColor = Color.Red;
                    Note.Text = "Данного пользователя не существует.";
                    Login.Text = "";
                    Pass.Text = "";
                    login = "";
                    pass = "";
                    Hashed = "";
                }
            }
            
        

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
