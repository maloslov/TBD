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
        
        public Form2(SqlConnection con)
        {
            InitializeComponent();
            connection = con;
            refreshData();
        }

        private DataSet getDataFromDB(string commanda)
        {
            var data = new DataSet();
            {
                using (var adapter = new SqlDataAdapter(commanda, connection))
                {
                        adapter.Fill(data);
                }
                return data;

            }
        }
        private void executeCommand(string commanda)
        {
            try
            {
                using(var sql = connection.CreateCommand())
                {
                    sql.CommandText = commanda;
                    sql.ExecuteNonQuery();
                }
                refreshData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refreshData()
        {
            DataSet data = new DataSet();
            {
                textEmployee6.Items.Clear();
                data = getDataFromDB("SELECT * FROM v_department;");
                if (data.Tables.Count > 0)
                    foreach (DataRow i in data.Tables[0].Rows)
                        textEmployee6.Items.Add(i.ItemArray[0]);
                textCome2.Items.Clear();
                data = getDataFromDB("SELECT * FROM v_contract;");
                if (data.Tables.Count > 0)
                    foreach (DataRow i in data.Tables[0].Rows)
                        textCome2.Items.Add(i.ItemArray[0]);
                textContent3.Items.Clear();
                data = getDataFromDB("SELECT * FROM v_content_type;");
                if (data.Tables.Count > 0)
                    foreach (DataRow i in data.Tables[0].Rows)
                        textContent3.Items.Add(i.ItemArray[0]);
                textContent4.Items.Clear();
                data = getDataFromDB("SELECT * FROM v_producer;");
                if (data.Tables.Count > 0)
                    foreach (DataRow i in data.Tables[0].Rows)
                        textContent4.Items.Add(i.ItemArray[0]);
                textContract2.Items.Clear();
                data = getDataFromDB("SELECT * FROM v_contract_type;");
                if (data.Tables.Count > 0)
                    foreach (DataRow i in data.Tables[0].Rows)
                        textContract2.Items.Add(i.ItemArray[0]);
                textContract3.Items.Clear();
                data = getDataFromDB("SELECT * FROM v_counterpart;");
                if (data.Tables.Count > 0)
                    foreach (DataRow i in data.Tables[0].Rows)
                        textContract3.Items.Add(i.ItemArray[0]);
                textContract4.Items.Clear();
                data = getDataFromDB("SELECT * FROM v_content;");
                if (data.Tables.Count > 0)
                    foreach (DataRow i in data.Tables[0].Rows)
                        textContract4.Items.Add(i.ItemArray[0]);
                textEmployee5.Items.Clear();
                data = getDataFromDB("SELECT * FROM v_duty;");
                if (data.Tables.Count > 0)
                    foreach (DataRow i in data.Tables[0].Rows)
                        textEmployee5.Items.Add(i.ItemArray[0]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var commanda = "";
            switch (comboBox1.Text)
            {
                case "Отделы":
                    commanda = "SELECT * FROM v_department;";
                    break;
                case "Должности":
                    commanda = "SELECT * FROM v_duty;";
                    break;
                case "Сотрудники":
                    commanda = "SELECT * FROM v_employee;";
                    break;
                case "Типы договоров":
                    commanda = "SELECT * FROM v_contract_type;";
                    break;
                case "Типы контента":
                    commanda = "SELECT * FROM v_content_type;";
                    break;
                case "Производители":
                    commanda = "SELECT * FROM v_producer;";
                    break;
                case "Контент":
                    commanda = "SELECT * FROM v_content;";
                    break;
                case "Контрагенты":
                    commanda = "SELECT * FROM v_counterpart;";
                    break;
                case "Договоры":
                    commanda = "SELECT * FROM v_contract;";
                    break;
                case "Расходы":
                    commanda = "SELECT * FROM v_outcome;";
                    break;
                case "Поступления":
                    commanda = "SELECT * FROM v_income;";
                    break;
                default:
                    return;
            }
            {
                DataSet data = getDataFromDB(commanda);
                if (data.Tables.Count > 0)
                    dataGridView1.DataSource = data.Tables[0];
            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            {
                foreach (string s in textEmployee6.Items)
                    if (s.Equals(textDepartment.Text))
                        return;
                executeCommand($"INSERT INTO t_department(f_name) VALUES('{textDepartment.Text}');");
            }
        }

        private void btnContentType_Click(object sender, EventArgs e)
        {
            {
                foreach (string s in textContent3.Items)
                    if (s.Equals(textContentType.Text))
                        return;
                executeCommand($"INSERT INTO t_content_type(f_name) VALUES('{textContentType.Text}');");
            }
        }

        private void btnContractType_Click(object sender, EventArgs e)
        {
            {
                foreach (string s in textContract2.Items)
                    if (s.Equals(textContractType.Text))
                        return;
                executeCommand($"INSERT INTO t_contract_type(f_name) VALUES('{textContractType.Text}');");
            }
        }

        private void btnProducer_Click(object sender, EventArgs e)
        {
            {
                foreach (string s in textContent4.Items)
                    if (s.Equals(textProducer.Text))
                        return;
                executeCommand($"INSERT INTO t_producer(f_name) VALUES('{textProducer.Text}');");
            }
        }

        private void btnDuty_Click(object sender, EventArgs e)
        {
            {
                foreach (string s in textEmployee5.Items)
                    if (s.Equals(textDuty1.Text))
                        return;
                executeCommand($"INSERT INTO t_duty(f_name,f_salary) " +
                    $"VALUES('{textDuty1.Text}',{Convert.ToDouble(textDuty2.Text)});");
            }
        }

        private void btnCounterpart_Click(object sender, EventArgs e)
        {
            {
                foreach (string s in textContract3.Items)
                    if (s.Equals(textCounterpart1.Text))
                        return;
                executeCommand($"INSERT INTO t_counterpart(f_name,f_fullname) " +
                    $"VALUES('{textCounterpart1.Text}','{textCounterpart2.Text}');");
            }
        }

        private void btnOutcome_Click(object sender, EventArgs e)
        {
            {
                executeCommand($"INSERT INTO t_outcome(f_amount,f_contract,f_date) " +
                    $"VALUES({Convert.ToDouble(textCome1.Text)}" +
                    $",(SELECT f_id FROM t_contract WHERE f_name = '{textCome2.Text}')" +
                    $",{textCome3Date.Value});");
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            {
                executeCommand($"INSERT INTO t_income(f_amount,f_contract,f_date) " +
                    $"VALUES({Convert.ToDouble(textCome1.Text)}" +
                    $",(SELECT f_id FROM t_contract WHERE f_name = '{textCome2.Text}')" +
                    $",convert(date,'{textCome3Date.Value.ToShortDateString().Split(' ')[0]}'));");
            }
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            {
                foreach (string s in textContract4.Items)
                    if (s.Equals(textContent1.Text))
                        return;
                executeCommand($"INSERT INTO t_content(f_name,f_chrono,f_type,f_producer,f_commentary) " +
                    $"VALUES('{textContent1.Text}',{Convert.ToInt32(textContent2.Text)}" +
                    $",(SELECT f_id FROM t_content_type WHERE f_name = '{textContent3.Text}')" +
                    $",(SELECT f_id FROM t_producer WHERE f_name = '{textContent4.Text}')" +
                    $",'{textContent5.Text}');");
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            {
                foreach (string s in textCome2.Items)
                    if (s.Equals(textContract1.Text))
                        return;
                executeCommand($"INSERT INTO t_contract(f_name,f_type,f_counterpart,f_content,f_date,d_commentary) " +
                    $"VALUES('{textContract1.Text}'" +
                    $",(SELECT f_id FROM t_contract_type WHERE f_name = '{textContract2.Text})')" +
                    $",(SELECT f_id FROM t_counterpart WHERE f_name = '{textContract3.Text}')" +
                    $",(SELECT f_id FROM t_content WHERE f_name = '{textContract4.Text}')" +
                    $",convert(date,'{textContract5Date.Value.ToShortDateString().Split(' ')[0]}')" +
                    $",'{textContract6.Text}');");
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            {
                executeCommand($"INSERT INTO t_employee(f_firstname,f_secondname,f_thirdname,f_pass," +
                    $"f_duty,f_department,f_date,f_iswork) " +
                    $"VALUES('{textEmployee1.Text}','{textEmployee2.Text}','{textEmployee3.Text}'" +
                    $",'{(textEmployee4.Text)}'" +
                    $",(SELECT f_id FROM t_duty WHERE f_name = '{textEmployee5.Text}')" +
                    $",(SELECT f_id FROM t_department WHERE f_name = '{textEmployee6.Text}')" +
                    $",convert(date,'{textEmployee7Date.Value.ToShortDateString().Split(' ')[0]}')" +
                    $",{(textEmployee8Check.Checked ? 0 : 1)});");
            }
        }

        private void textDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("();".Contains(e.KeyChar))
                e.Handled = true;
            else e.Handled = false;
        }
    }
}
