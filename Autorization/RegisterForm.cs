using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Security.Policy;

namespace Autorization
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        DataBase DataBase = new DataBase();
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void ValidPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            if (check())
            {
                return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string LoginValue = Login.Text;
            string Password = Pass.Text;
            string Validation = ValidPass.Text;
            string HashedPass = "";
            string HashedValidation = ".";
            while (HashedPass != HashedValidation)
            {
                if (Regex.IsMatch(LoginValue, @"\p{IsCyrillic}"))
                {
                    Note.ForeColor = Color.Red;
                    Note.Text = "Логин должен содержать латиницу";
                    Pass.Clear();
                    ValidPass.Clear();
                    Login.Clear();
                    break;
                }
                if (Regex.IsMatch(Password, @"\p{IsCyrillic}"))
                {
                    Note.ForeColor = Color.Red;
                    Note.Text = "Пароль должен содержать латиницу";
                    Pass.Clear();
                    ValidPass.Clear();
                    Login.Clear();
                    break;
                }
                if (LoginValue.Length < 3 || LoginValue.Length > 25)
                {
                    Note.ForeColor = Color.Red;
                    Note.Text = "Логин должен быть от 2-х до 25-и символов";
                    Pass.Clear();
                    ValidPass.Clear();
                    Login.Clear();
                    break;
                }


                if (Password.Length < 8 || Password.Length > 99)
                {
                    Note.ForeColor = Color.Red;
                    Note.Text = "Пароль должен быть от 8-и символов";
                    Pass.Clear();
                    ValidPass.Clear();
                    Login.Clear();
                    break;

                }

                HashedPass = PasswordHasher.HashPassword(Password);
                HashedValidation = PasswordHasher.HashPassword(Validation);
                if (HashedPass != HashedValidation)
                {
                    Note.ForeColor = Color.Red;
                    Pass.Clear();
                    ValidPass.Clear();
                    Note.Text = "Пароли не совпадают";
                    break;
                }

                string queryString = $"INSERT INTO users(Login, Password) VALUES ('{LoginValue}','{HashedPass}')";

                SqlCommand command = new SqlCommand(queryString, DataBase.getConnection());

                DataBase.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    Note.ForeColor = Color.Green;
                    Note.Text = "Вы Зарегистрировались!";
                }
                else
                {
                    Note.ForeColor = Color.Red;
                    Note.Text = "Аккаунт не зарегистрирован!";
                }

                DataBase.ClosedConnection();
                LoginValue = "";
                Password = "";
                Validation = "";
                Pass.Clear();
                ValidPass.Clear();
                Login.Clear();

            }
        }

        private Boolean check()
        {
            string login = Login.Text;
            string Hash = PasswordHasher.HashPassword(Pass.Text);

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = $"SELECT Login, Password FROM users WHERE Login = '{login}' AND Password = '{Hash}'";
            SqlCommand command = new SqlCommand(queryString, DataBase.getConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                Note.ForeColor = Color.Red;
                Note.Text = "Такой аккаунт уже есть";
                return true;
            }
            else 
            {
                return false;
            }
            
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage mainPage = new MainPage();
            mainPage.Show();
        }

        private void Login_TextChanged_1(object sender, EventArgs e)
        {

        }
    }

    //создаем класс PasswordHasher хеширующий пароль
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Преобразуем пароль в байтовый массив UTF-8
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

                // Вычисляем хеш
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);

                // Преобразуем байтовый массив хеша в строку шестнадцатеричных символов
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
