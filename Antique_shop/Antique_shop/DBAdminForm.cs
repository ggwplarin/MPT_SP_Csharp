using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Antique_shop
{
    class DBAdminForm: Form
    {
        public DBAdminForm()
        {
            InitializeComponent();
        }
        private TabControl tc_main;
        private TabPage tabPage1;
        private TabPage tp_antiques;
        private TabPage tp_setout;
        private TabPage tp_acquirers;
        private TabPage tp_cashbox;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox8;
        private TextBox textBox10;
        private TextBox textBox9;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private TabPage tp_story_archive;

        private void InitializeComponent()
        {
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tp_story_archive = new System.Windows.Forms.TabPage();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tp_antiques = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tp_setout = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.tp_acquirers = new System.Windows.Forms.TabPage();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.tp_cashbox = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tc_main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tp_story_archive.SuspendLayout();
            this.tp_antiques.SuspendLayout();
            this.tp_setout.SuspendLayout();
            this.tp_acquirers.SuspendLayout();
            this.tp_cashbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tabPage1);
            this.tc_main.Controls.Add(this.tp_story_archive);
            this.tc_main.Controls.Add(this.tp_antiques);
            this.tc_main.Controls.Add(this.tp_setout);
            this.tc_main.Controls.Add(this.tp_acquirers);
            this.tc_main.Controls.Add(this.tp_cashbox);
            this.tc_main.Location = new System.Drawing.Point(12, 12);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(458, 184);
            this.tc_main.TabIndex = 0;
            this.tc_main.SelectedIndexChanged += new System.EventHandler(this.tc_main_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 156);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(4, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Пароль";
            this.textBox2.Size = new System.Drawing.Size(443, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Логин";
            this.textBox1.Size = new System.Drawing.Size(443, 23);
            this.textBox1.TabIndex = 0;
            // 
            // tp_story_archive
            // 
            this.tp_story_archive.Controls.Add(this.textBox4);
            this.tp_story_archive.Controls.Add(this.textBox3);
            this.tp_story_archive.Location = new System.Drawing.Point(4, 24);
            this.tp_story_archive.Name = "tp_story_archive";
            this.tp_story_archive.Padding = new System.Windows.Forms.Padding(3);
            this.tp_story_archive.Size = new System.Drawing.Size(450, 156);
            this.tp_story_archive.TabIndex = 1;
            this.tp_story_archive.Text = "Архив Историй";
            this.tp_story_archive.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(4, 34);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Содержание";
            this.textBox4.Size = new System.Drawing.Size(443, 119);
            this.textBox4.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Название";
            this.textBox3.Size = new System.Drawing.Size(443, 23);
            this.textBox3.TabIndex = 0;
            // 
            // tp_antiques
            // 
            this.tp_antiques.Controls.Add(this.comboBox1);
            this.tp_antiques.Controls.Add(this.textBox7);
            this.tp_antiques.Controls.Add(this.textBox6);
            this.tp_antiques.Controls.Add(this.textBox5);
            this.tp_antiques.Location = new System.Drawing.Point(4, 24);
            this.tp_antiques.Name = "tp_antiques";
            this.tp_antiques.Padding = new System.Windows.Forms.Padding(3);
            this.tp_antiques.Size = new System.Drawing.Size(450, 156);
            this.tp_antiques.TabIndex = 2;
            this.tp_antiques.Text = "Антиквариат";
            this.tp_antiques.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(243, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "История";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(3, 130);
            this.textBox7.Name = "textBox7";
            this.textBox7.PlaceholderText = "Условия хранения";
            this.textBox7.Size = new System.Drawing.Size(444, 23);
            this.textBox7.TabIndex = 2;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(4, 34);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.PlaceholderText = "Описание";
            this.textBox6.Size = new System.Drawing.Size(443, 90);
            this.textBox6.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "Название";
            this.textBox5.Size = new System.Drawing.Size(233, 23);
            this.textBox5.TabIndex = 0;
            // 
            // tp_setout
            // 
            this.tp_setout.Controls.Add(this.comboBox2);
            this.tp_setout.Controls.Add(this.textBox8);
            this.tp_setout.Location = new System.Drawing.Point(4, 24);
            this.tp_setout.Name = "tp_setout";
            this.tp_setout.Padding = new System.Windows.Forms.Padding(3);
            this.tp_setout.Size = new System.Drawing.Size(450, 156);
            this.tp_setout.TabIndex = 3;
            this.tp_setout.Text = "Витрина";
            this.tp_setout.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(233, 23);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "Товар";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(243, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.PlaceholderText = "Цена";
            this.textBox8.Size = new System.Drawing.Size(204, 23);
            this.textBox8.TabIndex = 0;
            // 
            // tp_acquirers
            // 
            this.tp_acquirers.Controls.Add(this.textBox10);
            this.tp_acquirers.Controls.Add(this.textBox9);
            this.tp_acquirers.Location = new System.Drawing.Point(4, 24);
            this.tp_acquirers.Name = "tp_acquirers";
            this.tp_acquirers.Padding = new System.Windows.Forms.Padding(3);
            this.tp_acquirers.Size = new System.Drawing.Size(450, 156);
            this.tp_acquirers.TabIndex = 4;
            this.tp_acquirers.Text = "Покупатели";
            this.tp_acquirers.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(4, 34);
            this.textBox10.Name = "textBox10";
            this.textBox10.PlaceholderText = "Фамилия";
            this.textBox10.Size = new System.Drawing.Size(443, 23);
            this.textBox10.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(4, 4);
            this.textBox9.Name = "textBox9";
            this.textBox9.PlaceholderText = "Имя";
            this.textBox9.Size = new System.Drawing.Size(443, 23);
            this.textBox9.TabIndex = 0;
            // 
            // tp_cashbox
            // 
            this.tp_cashbox.Controls.Add(this.dateTimePicker1);
            this.tp_cashbox.Controls.Add(this.comboBox4);
            this.tp_cashbox.Controls.Add(this.comboBox3);
            this.tp_cashbox.Location = new System.Drawing.Point(4, 24);
            this.tp_cashbox.Name = "tp_cashbox";
            this.tp_cashbox.Padding = new System.Windows.Forms.Padding(3);
            this.tp_cashbox.Size = new System.Drawing.Size(450, 156);
            this.tp_cashbox.TabIndex = 5;
            this.tp_cashbox.Text = "Касса";
            this.tp_cashbox.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(4, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(244, 4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(203, 23);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.Text = "Покупатель";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(4, 4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(233, 23);
            this.comboBox3.TabIndex = 0;
            this.comboBox3.Text = "Товар";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(97, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(178, 202);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(450, 410);
            this.dataGridView1.TabIndex = 4;
            // 
            // DBAdminForm
            // 
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tc_main);
            this.Name = "DBAdminForm";
            this.tc_main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tp_story_archive.ResumeLayout(false);
            this.tp_story_archive.PerformLayout();
            this.tp_antiques.ResumeLayout(false);
            this.tp_antiques.PerformLayout();
            this.tp_setout.ResumeLayout(false);
            this.tp_setout.PerformLayout();
            this.tp_acquirers.ResumeLayout(false);
            this.tp_acquirers.PerformLayout();
            this.tp_cashbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        private void tc_main_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
