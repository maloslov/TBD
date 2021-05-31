using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBDClient
{
    public partial class Form2 : Form
    {
        private readonly SqlConnection connection;
        private string command = "";
        
        public Form2(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Отделы":
                    command = "SELECT * FROM v_department";
                    break;
                case "Должности":
                    command = "SELECT * FROM v_duty";
                    break;
                case "Сотрудники":
                    command = "SELECT * FROM v_employee";
                    break;
                case "Типы договоров":
                    command = "SELECT * FROM v_contract_type";
                    break;
                case "Типы контента":
                    command = "SELECT * FROM v_content_type";
                    break;
                case "Производители":
                    command = "SELECT * FROM v_producer";
                    break;
                case "Контент":
                    command = "SELECT * FROM v_content";
                    break;
                case "Контрагенты":
                    command = "SELECT * FROM v_counterpart";
                    break;
                case "Договоры":
                    command = "SELECT * FROM v_contract";
                    break;
                case "Расходы":
                    command = "SELECT * FROM v_outcome";
                    break;
                case "Поступления":
                    command = "SELECT * FROM v_income";
                    break;
            }
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command, connection);
                DataSet data = new DataSet();
                adapter.Fill(data);
                dataGridView1.DataSource = data.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
