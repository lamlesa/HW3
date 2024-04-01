using Diary;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace HW3
{
    public partial class Card : Form
    {
        public Card(int id)
        {
            InitializeComponent();
            var db = new DataBase();

            db.OpenConnection();

            var command = new MySqlCommand("SELECT * FROM `clients` WHERE `ID` = @id", db.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                SNP_textbox.Text = reader.GetString("Surname");
                SNP_textbox.Text += " " + reader.GetString("Name");
                SNP_textbox.Text += " " + reader.GetString("Patronymic");
                birth_textbox.Text = reader.GetDateTime("BirthDate").ToString();
            }
            else
            {
                MessageBox.Show("Нет данных об этом пользователе.");
            }

            db.CloseConnection();
        }
    }
}