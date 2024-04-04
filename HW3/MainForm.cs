﻿using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

using Microsoft.Data.Sqlite;

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
            if(clients.SelectedRows.Count > 0)
            {

                command.Connection = connection;
                connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
                var dt = new DataTable();


                connection.Open();
                var room = int.Parse(clients.CurrentRow.Cells[0].Value.ToString());
                command.CommandText = "Select `Номер`,`ФИО`,`Дата Рождения` from Clients WHERE `Номер` = @room";
                command.Parameters.AddWithValue("@room", room);


                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                 
                    var form = new Card(reader.GetString(0));
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Нет данных об этом пользователе.");
                }
                reader.Close();
                dt.Clear();

                connection.Close();


            }
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            command.Connection = connection;
            connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
            var dt = new DataTable();
            clients.DataSource = dt; 
            string state = "Зарезервировано";
            connection.Open(); 
            command.CommandText = "Select `Номер`,`ФИО`,`Дата рождения` from Clients WHERE `Статус` = @status";
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
            command.CommandText = "Select `Номер`,`ФИО`,`Дата рождения` from Clients WHERE `Статус` = @status";
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
            command.CommandText = "Select `Номер`,`ФИО`,`Дата рождения` from Clients WHERE `Статус` = @status";
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
            command.CommandText = "Select `Номер`,`ФИО`,`Дата рождения` from Clients WHERE `Статус` = @status";
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
              
                
                connection.Open();
                var room = int.Parse(clients.CurrentRow.Cells[0].Value.ToString());
                command.CommandText = "Select * from Clients WHERE `Номер` = @room";
                command.Parameters.AddWithValue("@room", room);
               

                var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    textBox1.Text = reader.GetString(0);
                    name_textbox.Text = reader.GetString(1);
                    status_combobox.SelectedItem = reader.GetString(2);
                    checkin.Text = reader.GetString(3);
                    checkout.Text = reader.GetString(4);
                    u_pic.ImageLocation = "C:\\Users\\ламлеса\\source\\repos\\HW3\\HW3\\Pictures\\" + reader.GetString(1) + ".jpg";
                    u_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    MessageBox.Show("Нет данных об этом пользователе.");
                }
                reader.Close();
                dt.Clear();
                
                connection.Close();
                
                
                
                
                //name_textbox.Text = clients.CurrentRow.Cells[1].Value.ToString();
                //checkin.


            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command.Connection = connection;
            connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
            var dt = new DataTable();
            clients.DataSource = dt;
            string room = search.Text;
            connection.Open();
            command.CommandText = "Select `Номер`,`ФИО`,`Дата рождения` from Clients WHERE `Номер` = @room";
            command.Parameters.AddWithValue("@status", room);

            dt.Clear();
            dt.Load(command.ExecuteReader());
            connection.Close();
        }

        
    }
}