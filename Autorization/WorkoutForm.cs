using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autorization
{
    public partial class WorkoutForm : Form
    {

        public WorkoutForm()
        {
            InitializeComponent();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected int fieldCount = 0;
        protected List<TextBox> textBoxes = new List<TextBox>();
        protected List<NumericUpDown> numerics = new List<NumericUpDown>();
        protected void AddExercise_Click(object sender, EventArgs e)
        {
            if (fieldCount < 10)
            {
                fieldCount++;
                Label label = new Label();
                label.Text = $"Упражнение {fieldCount}:";
                label.Location = new System.Drawing.Point(428, -20 + fieldCount * 50);
                this.Controls.Add(label);

                TextBox textBox = new TextBox();
                textBox.Location = new System.Drawing.Point(428, 3 + fieldCount * 50);
                textBox.Name = $"textBox{fieldCount}";
                textBox.Size = new System.Drawing.Size(200, 20);
                this.Controls.Add(textBox);
                textBoxes.Add(textBox);
                

                NumericUpDown numericUpDown = new NumericUpDown();
                numericUpDown.Location = new System.Drawing.Point(668, 3 + fieldCount * 50); 
                numericUpDown.Name = $"Numeric{fieldCount}"; 
                numericUpDown.Size = new System.Drawing.Size(50, 20);
                numericUpDown.Maximum = 50;
                this.Controls.Add(numericUpDown);
                numerics.Add(numericUpDown);
            }
            else
            {
                this.AddExercise.Enabled = false;
            }
        }

        private void AddWorkoutContent_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            DataBase db = new DataBase();
            string queryString1 = $"SELECT Id FROM users WHERE Login = '{UserName.Text}'";
            SqlCommand command1 = new SqlCommand(queryString1, db.getConnection());
            db.OpenConnection();
            int userId = 0;
            //int WkId;
            SqlDataReader reader = command1.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                userId = reader.GetInt32(0);
                reader.Close();
            }
                
            
           string Exercises = string.Empty;
            if (WorkoutName.Text == "")
            {
                WorkoutName.Text = "Тренировка";
            }
            
            //string queryString4 = $"SELECT Id FROM Workouts WHERE userId = '{userId}'";
            //reader = command2.ExecuteReader();
            //reader.Read();
            //WkId = reader.GetInt32(0); 
            //reader.Close();
            for (int i = 0; i < fieldCount; i++)
            {
                Exercises += $"{textBoxes[i].Text} на {numerics[i].Value} подходов.\n";
              //  string queryString3 = $"INSERT INTO Exercises(Name, Sets, WorkoutID) VALUES ('{textBoxes[i].Text}', '{numerics[i].Value}', {WkId})";
              //  SqlCommand command3 = new SqlCommand(queryString3, db.getConnection());
            }
            string queryString2 = $"INSERT INTO Workouts(userId, WorkoutName, WorkoutDate, WorkoutType,) VALUES ({userId}, {WorkoutName.Text},{WorkoutDate.Value},{WorkoutType.Text})";
            SqlCommand command2 = new SqlCommand(queryString2, db.getConnection());
            MainPage mainPage = new MainPage();
            mainPage.UserName = this.UserName;
            this.Hide();
            mainPage.Show();
        }

        private void WorkoutName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
