
namespace TBDClient
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDepartment = new System.Windows.Forms.Button();
            this.btnDuty = new System.Windows.Forms.Button();
            this.textDuty2 = new System.Windows.Forms.TextBox();
            this.textDuty1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCounterpart = new System.Windows.Forms.Button();
            this.textCounterpart2 = new System.Windows.Forms.TextBox();
            this.textCounterpart1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnContent = new System.Windows.Forms.Button();
            this.textContent = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnContractType = new System.Windows.Forms.Button();
            this.textContractType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textProducer = new System.Windows.Forms.TextBox();
            this.btnProducer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOutcome = new System.Windows.Forms.Button();
            this.textCome1 = new System.Windows.Forms.TextBox();
            this.textCome3Date = new System.Windows.Forms.DateTimePicker();
            this.textCome2 = new System.Windows.Forms.ComboBox();
            this.btnIncome = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(537, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(529, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите отчет:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(516, 357);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Получить выбранный отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Отделы",
            "Должности",
            "Сотрудники",
            "Типы договоров",
            "Типы контента",
            "Производители",
            "Контент",
            "Контрагенты",
            "Договоры",
            "Расходы",
            "Поступления"});
            this.comboBox1.Location = new System.Drawing.Point(123, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(529, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Добавление";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage10);
            this.tabControl2.Controls.Add(this.tabPage11);
            this.tabControl2.Controls.Add(this.tabPage12);
            this.tabControl2.Controls.Add(this.tabPage13);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(7, 7);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(522, 392);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnIncome);
            this.tabPage3.Controls.Add(this.textCome2);
            this.tabPage3.Controls.Add(this.textCome3Date);
            this.tabPage3.Controls.Add(this.textCome1);
            this.tabPage3.Controls.Add(this.btnOutcome);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.textProducer);
            this.tabPage3.Controls.Add(this.btnProducer);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.btnContractType);
            this.tabPage3.Controls.Add(this.textContractType);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnContent);
            this.tabPage3.Controls.Add(this.textContent);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.btnCounterpart);
            this.tabPage3.Controls.Add(this.textCounterpart2);
            this.tabPage3.Controls.Add(this.textCounterpart1);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.btnDuty);
            this.tabPage3.Controls.Add(this.textDuty2);
            this.tabPage3.Controls.Add(this.textDuty1);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.btnDepartment);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.textDepartment);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(514, 366);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Общее";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage10
            // 
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(514, 366);
            this.tabPage10.TabIndex = 7;
            this.tabPage10.Text = "Контент";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // tabPage11
            // 
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(514, 366);
            this.tabPage11.TabIndex = 8;
            this.tabPage11.Text = "Договоры";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // tabPage12
            // 
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(514, 366);
            this.tabPage12.TabIndex = 9;
            this.tabPage12.Text = "Поступления";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // tabPage13
            // 
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(514, 366);
            this.tabPage13.TabIndex = 10;
            this.tabPage13.Text = "Расходы";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // textDepartment
            // 
            this.textDepartment.Location = new System.Drawing.Point(88, 15);
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(114, 20);
            this.textDepartment.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый отдел:";
            // 
            // btnDepartment
            // 
            this.btnDepartment.Location = new System.Drawing.Point(9, 45);
            this.btnDepartment.Name = "btnDepartment";
            this.btnDepartment.Size = new System.Drawing.Size(193, 23);
            this.btnDepartment.TabIndex = 2;
            this.btnDepartment.Text = "Добавить новый отдел";
            this.btnDepartment.UseVisualStyleBackColor = true;
            // 
            // btnDuty
            // 
            this.btnDuty.Location = new System.Drawing.Point(246, 70);
            this.btnDuty.Name = "btnDuty";
            this.btnDuty.Size = new System.Drawing.Size(262, 23);
            this.btnDuty.TabIndex = 9;
            this.btnDuty.Text = "Добавить должность";
            this.btnDuty.UseVisualStyleBackColor = true;
            // 
            // textDuty2
            // 
            this.textDuty2.Location = new System.Drawing.Point(368, 44);
            this.textDuty2.Name = "textDuty2";
            this.textDuty2.Size = new System.Drawing.Size(100, 20);
            this.textDuty2.TabIndex = 8;
            // 
            // textDuty1
            // 
            this.textDuty1.Location = new System.Drawing.Point(368, 12);
            this.textDuty1.Name = "textDuty1";
            this.textDuty1.Size = new System.Drawing.Size(100, 20);
            this.textDuty1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Оклад должности:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Название должности:";
            // 
            // btnCounterpart
            // 
            this.btnCounterpart.Location = new System.Drawing.Point(246, 188);
            this.btnCounterpart.Name = "btnCounterpart";
            this.btnCounterpart.Size = new System.Drawing.Size(262, 23);
            this.btnCounterpart.TabIndex = 14;
            this.btnCounterpart.Text = "Добавить контрагента";
            this.btnCounterpart.UseVisualStyleBackColor = true;
            // 
            // textCounterpart2
            // 
            this.textCounterpart2.Location = new System.Drawing.Point(376, 151);
            this.textCounterpart2.Name = "textCounterpart2";
            this.textCounterpart2.Size = new System.Drawing.Size(100, 20);
            this.textCounterpart2.TabIndex = 13;
            // 
            // textCounterpart1
            // 
            this.textCounterpart1.Location = new System.Drawing.Point(376, 114);
            this.textCounterpart1.Name = "textCounterpart1";
            this.textCounterpart1.Size = new System.Drawing.Size(100, 20);
            this.textCounterpart1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Полное название:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Название контрагента:";
            // 
            // btnContent
            // 
            this.btnContent.Location = new System.Drawing.Point(9, 114);
            this.btnContent.Name = "btnContent";
            this.btnContent.Size = new System.Drawing.Size(193, 23);
            this.btnContent.TabIndex = 17;
            this.btnContent.Text = "Добавить новый тип";
            this.btnContent.UseVisualStyleBackColor = true;
            // 
            // textContent
            // 
            this.textContent.Location = new System.Drawing.Point(91, 83);
            this.textContent.Name = "textContent";
            this.textContent.Size = new System.Drawing.Size(111, 20);
            this.textContent.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Тип контента:";
            // 
            // btnContractType
            // 
            this.btnContractType.Location = new System.Drawing.Point(9, 188);
            this.btnContractType.Name = "btnContractType";
            this.btnContractType.Size = new System.Drawing.Size(193, 23);
            this.btnContractType.TabIndex = 20;
            this.btnContractType.Text = "Добавить новый тип договоров";
            this.btnContractType.UseVisualStyleBackColor = true;
            // 
            // textContractType
            // 
            this.textContractType.Location = new System.Drawing.Point(92, 152);
            this.textContractType.Name = "textContractType";
            this.textContractType.Size = new System.Drawing.Size(110, 20);
            this.textContractType.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Тип договора:";
            // 
            // textProducer
            // 
            this.textProducer.Location = new System.Drawing.Point(102, 228);
            this.textProducer.Name = "textProducer";
            this.textProducer.Size = new System.Drawing.Size(100, 20);
            this.textProducer.TabIndex = 23;
            // 
            // btnProducer
            // 
            this.btnProducer.Location = new System.Drawing.Point(9, 260);
            this.btnProducer.Name = "btnProducer";
            this.btnProducer.Size = new System.Drawing.Size(193, 23);
            this.btnProducer.TabIndex = 22;
            this.btnProducer.Text = "Добавить производителя";
            this.btnProducer.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Производитель:";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(514, 366);
            this.tabPage4.TabIndex = 11;
            this.tabPage4.Text = "Сотрудники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(259, 239);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Сумма:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Договор:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 288);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Дата:";
            // 
            // btnOutcome
            // 
            this.btnOutcome.Location = new System.Drawing.Point(246, 325);
            this.btnOutcome.Name = "btnOutcome";
            this.btnOutcome.Size = new System.Drawing.Size(115, 23);
            this.btnOutcome.TabIndex = 27;
            this.btnOutcome.Text = "Добавить расход";
            this.btnOutcome.UseVisualStyleBackColor = true;
            // 
            // textCome1
            // 
            this.textCome1.Location = new System.Drawing.Point(309, 236);
            this.textCome1.Name = "textCome1";
            this.textCome1.Size = new System.Drawing.Size(167, 20);
            this.textCome1.TabIndex = 28;
            // 
            // textCome3Date
            // 
            this.textCome3Date.Location = new System.Drawing.Point(309, 288);
            this.textCome3Date.Name = "textCome3Date";
            this.textCome3Date.Size = new System.Drawing.Size(167, 20);
            this.textCome3Date.TabIndex = 30;
            // 
            // textCome2
            // 
            this.textCome2.FormattingEnabled = true;
            this.textCome2.Location = new System.Drawing.Point(309, 261);
            this.textCome2.Name = "textCome2";
            this.textCome2.Size = new System.Drawing.Size(167, 21);
            this.textCome2.TabIndex = 31;
            // 
            // btnIncome
            // 
            this.btnIncome.Location = new System.Drawing.Point(368, 325);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(140, 23);
            this.btnIncome.TabIndex = 32;
            this.btnIncome.Text = "Добавить поступление";
            this.btnIncome.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Новая телевизионная сеть";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Button btnDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDepartment;
        private System.Windows.Forms.TextBox textProducer;
        private System.Windows.Forms.Button btnProducer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnContractType;
        private System.Windows.Forms.TextBox textContractType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnContent;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCounterpart;
        private System.Windows.Forms.TextBox textCounterpart2;
        private System.Windows.Forms.TextBox textCounterpart1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDuty;
        private System.Windows.Forms.TextBox textDuty2;
        private System.Windows.Forms.TextBox textDuty1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.ComboBox textCome2;
        private System.Windows.Forms.DateTimePicker textCome3Date;
        private System.Windows.Forms.TextBox textCome1;
        private System.Windows.Forms.Button btnOutcome;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
    }
}