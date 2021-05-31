using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace TBDClient
{
    public partial class Form1 : Form
    {
        private Form2 subform;
        private SqlConnection connection;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = ($@"Data Source={textBox1.Text}
                ;Initial Catalog={textBox2.Text}
                ;User Id = {textBox3.Text}
                ;Password = {textBox4.Text}
                ;Integrated Security=True");
            connection = new SqlConnection(connectionString);
            try
            {
                // Открываем подключение
                connection.Open();
                subform = new Form2(connection);
                subform.FormClosed += new FormClosedEventHandler(subform_closing);
                this.Hide();
                subform.Show();
                MessageBox.Show("Подключение открыто");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void subform_closing(object sender, EventArgs e)
        {
            subform.Hide();
            this.Show();
            // закрываем подключение
            if (!connection.Equals(null))
                connection.Close();
            MessageBox.Show("Подключение закрыто");
        }
    }
}
