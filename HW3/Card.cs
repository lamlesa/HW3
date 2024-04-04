
using System;
using System.Windows.Forms;
using System.Data.SQLite;
using MySqlX.XDevAPI;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HW3
{
    public partial class Card : Form
    {
        public static string path = "C:\\Users\\ламлеса\\source\\repos\\HW3\\HW3\\DataBase\\Hotel.db";
        public static SQLiteConnection connection = new SQLiteConnection();
        public static SQLiteCommand command = new SQLiteCommand();
        public string Room { get; set; }
        public Card(string room)
        {
            InitializeComponent();
            command.Connection = connection;
            connection.ConnectionString = @"Data Source=" + path + ";New=False;Version=3";
            var dt = new DataTable();
            Room = room;

            connection.Open();
            //var room = int.Parse(clients.CurrentRow.Cells[0].Value.ToString());
            command.CommandText = "Select * from Clients WHERE `Номер` = @room";
            command.Parameters.AddWithValue("@room", room);


            var reader = command.ExecuteReader();
            if (reader.Read())
            {
               
                name_textbox.Text = reader.GetString(1);
                
                birth_textbox.Text = reader.GetString(7);
                
                
                DateTime start = DateTime.Parse(reader.GetString(3));
                DateTime end = DateTime.Parse(reader.GetString(4));

                textBox1.Text = (end - start).Days.ToString();
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
}