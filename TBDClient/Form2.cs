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
            try
            {
                var data = new DataSet();
                using (var adapter = new SqlDataAdapter(commanda, connection))
                {
                    adapter.Fill(data);
                }
                return data;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
                return null;
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
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }
        private void refreshData()
        {
            DataSet data = new DataSet();
            try
            {
                data = getDataFromDB("SELECT f_name FROM v_contract;");
                foreach (DataRow i in data.Tables[0].Rows)
                    textCome2.Items.Add(i.ItemArray[0]);
                data = getDataFromDB("SELECT f_name FROM v_content_type;");
                foreach (DataRow i in data.Tables[0].Rows)
                    textContent3.Items.Add(i.ItemArray[0]);
                data = getDataFromDB("SELECT f_name FROM v_producer;");
                foreach (DataRow i in data.Tables[0].Rows)
                    textContent4.Items.Add(i.ItemArray[0]);
                data = getDataFromDB("SELECT f_name FROM v_contract_type;");
                foreach (DataRow i in data.Tables[0].Rows)
                    textContract2.Items.Add(i.ItemArray[0]);
                data = getDataFromDB("SELECT f_name FROM v_counterpart;");
                foreach (DataRow i in data.Tables[0].Rows)
                    textContract3.Items.Add(i.ItemArray[0]);
                data = getDataFromDB("SELECT f_name FROM v_content;");
                foreach (DataRow i in data.Tables[0].Rows)
                    textContract4.Items.Add(i.ItemArray[0]);
                data = getDataFromDB("SELECT f_name FROM v_duty;");
                foreach (DataRow i in data.Tables[0].Rows)
                    textEmployee5.Items.Add(i.ItemArray[0]);
                data = getDataFromDB("SELECT f_name FROM v_department;");
                foreach (DataRow i in data.Tables[0].Rows)
                    textEmployee6.Items.Add(i.ItemArray[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
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
            try
            {
                DataSet data = getDataFromDB(commanda);
                dataGridView1.DataSource = data.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_department(f_name) VALUES('{textDepartment.Text}');");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnContentType_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_content_type(f_name) VALUES('{textContentType.Text}');");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnContractType_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_contract(f_name) VALUES('{textContractType.Text}');");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnProducer_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_producer(f_name) VALUES('{textProducer.Text}');");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnDuty_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_department(f_name,f_salary) " +
                    $"VALUES('{textDuty1.Text}',{Convert.ToDouble(textDuty2.Text)});");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnCounterpart_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_counterpart(f_name,f_fullname) " +
                    $"VALUES('{textCounterpart1.Text}',{textCounterpart2.Text});");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnOutcome_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_outcome(f_amount,f_contract,f_date) " +
                    $"VALUES({Convert.ToDouble(textCome1.Text)}" +
                    $",(SELECT f_id FROM t_contract WHERE f_name = '{textCome2.Text}')" +
                    $",{textCome3Date.Value});");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnIncome_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_income(f_amount,f_contract,f_date) " +
                    $"VALUES({Convert.ToDouble(textCome1.Text)}" +
                    $",(SELECT f_id FROM t_contract WHERE f_name = '{textCome2.Text}')" +
                    $",{textCome3Date.Value});");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnContent_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_content(f_name,f_chrono,f_type,f_producer,f_commentary) " +
                    $"VALUES('{textContent1.Text}',{Convert.ToInt32(textContent2.Text)}" +
                    $",(SELECT f_id FROM t_content_type WHERE f_name = '{textContent3.Text}')" +
                    $",(SELECT f_id FROM t_producer WHERE f_name = '{textContent4.Text}')" +
                    $",'{textContent5.Text}');");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_contract(f_name,f_type,f_counterpart,f_content,f_date,d_commentary) " +
                    $"VALUES('{textContract1.Text}'" +
                    $",(SELECT f_id FROM t_contract_type WHERE f_name = '{textContract2.Text})')" +
                    $",(SELECT f_id FROM t_counterpart WHERE f_name = '{textContract3.Text}')" +
                    $",(SELECT f_id FROM t_content WHERE f_name = '{textContract4.Text}')" +
                    $",{textContract5Date.Value},'{textContract6.Text}');");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                executeCommand($"INSERT INTO t_employee(f_firstname,f_secondname,f_thirdname,f_pass," +
                    $"f_duty,f_department,f_date,f_iswork) " +
                    $"VALUES('{textEmployee1.Text}','{textEmployee2.Text}','{textEmployee3}'" +
                    $",{Convert.ToInt32(textContent4.Text)}" +
                    $",(SELECT f_id FROM t_duty WHERE f_name = '{textEmployee5.Text}')" +
                    $",(SELECT f_id FROM t_department WHERE f_name = '{textEmployee6.Text}')" +
                    $",{textEmployee7Date.Value},{Convert.ToByte(textEmployee8Check.Checked)});");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\r\n{ex.StackTrace}");
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
