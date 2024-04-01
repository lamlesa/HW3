using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HW3
{
    public partial class MainForm : Form
    {
        public static string path = "C:\\Users\\ламлеса\\source\\repos\\HW3\\HW3\\DataBase\\Hotel.db";
        public static SQLiteConnection connection = new SQLiteConnection();
        public static SQLiteCommand command = new SQLiteCommand();

        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Elapsed += TimerTick;
            timer.Enabled = true;

            
            command.Connection = connection;
            connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
            var dt = new DataTable();
            clients.DataSource = dt; 

            connection.Open(); 
            command.CommandText = "Select * from Clients";
            dt.Clear();
            dt.Load(command.ExecuteReader());
            connection.Close(); 
        }
        System.Timers.Timer timer = new System.Timers.Timer();

        public void TimerTick(object sender, EventArgs e)
        {
            var str = DateTime.Now.ToString();
            if (time_label.InvokeRequired) time_label.Invoke(new Action<string>((s) => time_label.Text = s), str);
            else time_label.Text = str;
        }

        private void ShowCard(object sender, EventArgs e)
        {
            var form = new Card(1);
            form.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            command.Connection = connection;
            connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
            var dt = new DataTable();
            clients.DataSource = dt; 
            string state = "Зарезервировано";
            connection.Open(); 
            command.CommandText = "Select * from Clients WHERE `Статус` = @status";
            command.Parameters.AddWithValue("@status", state);

            dt.Clear();
            dt.Load(command.ExecuteReader());
            connection.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            command.Connection = connection;
            connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
            var dt = new DataTable();
            clients.DataSource = dt; // связываешь DataTable и таблицу на форме (просто dt)
            string state = "Свободные";
            connection.Open(); // открываешь соединение с БД
            command.CommandText = "Select * from Clients WHERE `Статус` = @status";
            command.Parameters.AddWithValue("@status", state);

            dt.Clear();
            dt.Load(command.ExecuteReader()); // выполняешь SQL-запрос
            connection.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            command.Connection = connection;
            connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
            var dt = new DataTable();
            clients.DataSource = dt;
            string state = "Заняты";
            connection.Open(); 
            command.CommandText = "Select * from Clients WHERE `Статус` = @status";
            command.Parameters.AddWithValue("@status", state);

            dt.Clear();
            dt.Load(command.ExecuteReader()); 
            connection.Close();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            command.Connection = connection;
            connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
            var dt = new DataTable();
            clients.DataSource = dt; 
            string state = "Выписываются";
            connection.Open(); 
            command.CommandText = "Select * from Clients WHERE `Статус` = @status";
            command.Parameters.AddWithValue("@status", state);

            dt.Clear();
            dt.Load(command.ExecuteReader()); 
            connection.Close();
        }

        private void ViewInfo(object sender, DataGridViewCellEventArgs e)
        {
            if (clients.SelectedRows.Count > 0)
            {
                command.Connection = connection;

                connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
                var dt = new DataTable();
                
                var room = int.Parse(clients.CurrentRow.Cells[0].Value.ToString());
                connection.Open(); 
                command.CommandText = "Select * from Clients WHERE `Номер` = @room";
                command.Parameters.AddWithValue("@room", room);
                var reader = command.ExecuteReader();
                if (reader.Read())
                {
       
                    name_textbox.Text = reader.GetString(2);
                    
                }
                else
                {
                    MessageBox.Show("Нет данных об этом пользователе.");
                }
                dt.Clear();
                dt.Load(command.ExecuteReader()); 
                connection.Close();
            }
            
        }
    }
}