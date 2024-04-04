using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace HW3
{
    public partial class Card : Form
    {
        public static string path = "../../DataBase/Hotel.db";
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

            command.CommandText = "Select * from Clients WHERE `Номер` = @room";
            command.Parameters.AddWithValue("@room", room);

            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                name_textbox.Text = reader.GetString(1);
                DateTime start = DateTime.Parse(reader.GetString(3));
                DateTime end = DateTime.Parse(reader.GetString(4));
                days_textbox.Text = (end - start).Days.ToString();
                birth_textbox.Text = reader.GetString(7);
                payment.SelectedItem = reader.GetString(5);
                if (reader.GetString(6) == "Да")
                {
                    animals.Checked = true;
                }
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