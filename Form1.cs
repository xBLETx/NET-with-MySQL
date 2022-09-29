using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NET_with_MySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn;

            // строка подключения к БД
            string connStr = "server=192.168.25.23;port=3306;user=test;" +
                "database=test;password=12345;";
            // создаём объект для подключения к БД

            conn = new MySqlConnection(connStr);
            
            // устанавливаем соединение с БД
            conn.Open();
            // запрос
            string sql = $"SELECT name FROM stud WHERE id=1";
            // объект для выполнения SQL-запроса
            MySqlCommand command = new MySqlCommand(sql, conn);
            // выполняем запрос и получаем ответ
            string name = command.ExecuteScalar().ToString();
            // выводим ответ в TextBox
            label1.Text = name;
            // закрываем соединение с БД
            conn.Close();
        }
    }
}
