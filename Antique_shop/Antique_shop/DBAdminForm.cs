using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Antique_shop
{
    class DBAdminForm : Form
    {
        public string ConStr =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Antique_shop_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public DBAdminForm()
        {
            InitializeComponent();
        }

        private TabControl tc_main;
        private TabPage tp_shop_users;
        private TabPage tp_antiques;
        private TabPage tp_setout;
        private TabPage tp_acquirers;
        private TabPage tp_cashbox;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private TextBox tb_shop_user_password;
        private TextBox tb_shop_user_login;
        private TextBox tb_story_content;
        private TextBox tb_story_title;
        private TextBox tb_antique_thing_storage_conditions;
        private TextBox tb_antique_thing_description;
        private TextBox tb_antique_thing_title;
        private DataGridView dgv_main;
        private ComboBox cb_antique_thing_story_id;
        private ComboBox cb_setout_antique_thing_id;
        private TextBox tb_setout_position_price;
        private TextBox tb_acquirer_last_name;
        private TextBox tb_acquirer_first_name;
        private DateTimePicker dtp_sale_date;
        private ComboBox cb_sale_acquirer_id;
        private ComboBox cb_sale_setout_position_id;
        private TabPage tp_story_archive;
    

    private void tc_main_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if ((tc_main.SelectedTab.Name) switch
            {
                "tp_shop_users" => ValidateShopUsersForm(),
                "tp_story_archive" => ValidateStoryArchiveForm(),
                "tp_antiques" => ValidateAntiquesForm(),
                "tp_setout" => ValidateSetoutForm(),
                "tp_acquirers" => ValidateAcquirersForm(),
                "tp_cashbox" => ValidateCashBoxForm(),
                _ => false
            })
            {
                using var connection = new SqlConnection(ConStr);
                try
                {
                    connection.Open();
                    var cmdText =
                        (tc_main.SelectedTab.Name) switch
                        {//TODO: доделать команды
                            "tp_shop_users" => $"INSERT INTO shop_users (shop_user_login,shop_user_password) VALUES ('{tb_shop_user_login.Text}','{tb_shop_user_password.Text}')",
                            "tp_story_archive" => $"INSERT INTO story_archive (story_title,story_content) VALUES ('{tb_story_title.Text}','{tb_story_content.Text}')",
                            "tp_antiques" => $"INSERT INTO antiques (shop_user_login,shop_user_password) VALUES ('SenjorAdmin','!2#qWeRtY1@3')",
                            "tp_setout" => $"INSERT INTO setout (shop_user_login,shop_user_password) VALUES ('SenjorAdmin','!2#qWeRtY1@3')",
                            "tp_acquirers" => $"INSERT INTO acquirers (shop_user_login,shop_user_password) VALUES ('SenjorAdmin','!2#qWeRtY1@3')",
                            "tp_cashbox" => $"INSERT INTO cashbox (shop_user_login,shop_user_password) VALUES ('SenjorAdmin','!2#qWeRtY1@3')",
                            _ => throw new ArgumentOutOfRangeException()
                        };
                    using var command = new SqlCommand(cmdText, connection);
                    if (command.ExecuteNonQuery()>0)
                    {
                        MessageBox.Show(Properties.Strings.DBAdminForm_MB_ElementAdd_Succes_text);
                        UpdateDataGrid();
                    }
                    else
                    {
                        MessageBox.Show(Properties.Strings.SignInForm_MB_SignInFieldsValidationFailed_text, Properties.Strings.SignInForm_MB_SignInFieldsValidationFailed_caption);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //TODO: сделать валидацию для каждой формы ввода
        public bool ValidateShopUsersForm()
        {
            return true;
        }

        public bool ValidateStoryArchiveForm()
        {
            return true;
        }

        public bool ValidateAntiquesForm()
        {
            return true;
        }

        public bool ValidateSetoutForm()
        {
            return true;
        }

        public bool ValidateAcquirersForm()
        {
            return true;
        }

        public bool ValidateCashBoxForm()
        {
            return true;
        }

        public void UpdateDataGrid()
        {
            using var connection = new SqlConnection(ConStr);
            try
            {
                connection.Open();
                var cmdText =
                    (tc_main.SelectedTab.Name) switch
                    {
                        "tp_shop_users" => "SELECT * FROM shop_users",
                        "tp_story_archive" => "SELECT * FROM story_archive",
                        "tp_antiques" => "SELECT * FROM antiques",
                        "tp_setout" => "SELECT * FROM setout",
                        "tp_acquirers" => "SELECT * FROM acquirers",
                        "tp_cashbox" => "SELECT * FROM cashbox",
                        _ => throw new ArgumentOutOfRangeException()
                    };
                using var dataAdapter = new SqlDataAdapter(cmdText, connection);
                var dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dgv_main.DataSource = dataSet.Tables[0];

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        private void InitializeComponent()
        {
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_shop_users = new System.Windows.Forms.TabPage();
            this.tb_shop_user_password = new System.Windows.Forms.TextBox();
            this.tb_shop_user_login = new System.Windows.Forms.TextBox();
            this.tp_story_archive = new System.Windows.Forms.TabPage();
            this.tb_story_content = new System.Windows.Forms.TextBox();
            this.tb_story_title = new System.Windows.Forms.TextBox();
            this.tp_antiques = new System.Windows.Forms.TabPage();
            this.cb_antique_thing_story_id = new System.Windows.Forms.ComboBox();
            this.tb_antique_thing_storage_conditions = new System.Windows.Forms.TextBox();
            this.tb_antique_thing_description = new System.Windows.Forms.TextBox();
            this.tb_antique_thing_title = new System.Windows.Forms.TextBox();
            this.tp_setout = new System.Windows.Forms.TabPage();
            this.cb_setout_antique_thing_id = new System.Windows.Forms.ComboBox();
            this.tb_setout_position_price = new System.Windows.Forms.TextBox();
            this.tp_acquirers = new System.Windows.Forms.TabPage();
            this.tb_acquirer_last_name = new System.Windows.Forms.TextBox();
            this.tb_acquirer_first_name = new System.Windows.Forms.TextBox();
            this.tp_cashbox = new System.Windows.Forms.TabPage();
            this.dtp_sale_date = new System.Windows.Forms.DateTimePicker();
            this.cb_sale_acquirer_id = new System.Windows.Forms.ComboBox();
            this.cb_sale_setout_position_id = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dgv_main = new System.Windows.Forms.DataGridView();
            this.tc_main.SuspendLayout();
            this.tp_shop_users.SuspendLayout();
            this.tp_story_archive.SuspendLayout();
            this.tp_antiques.SuspendLayout();
            this.tp_setout.SuspendLayout();
            this.tp_acquirers.SuspendLayout();
            this.tp_cashbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).BeginInit();
            this.SuspendLayout();
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_shop_users);
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
            // tp_shop_users
            // 
            this.tp_shop_users.Controls.Add(this.tb_shop_user_password);
            this.tp_shop_users.Controls.Add(this.tb_shop_user_login);
            this.tp_shop_users.Location = new System.Drawing.Point(4, 24);
            this.tp_shop_users.Name = "tp_shop_users";
            this.tp_shop_users.Padding = new System.Windows.Forms.Padding(3);
            this.tp_shop_users.Size = new System.Drawing.Size(450, 156);
            this.tp_shop_users.TabIndex = 0;
            this.tp_shop_users.Text = "Пользователи";
            this.tp_shop_users.UseVisualStyleBackColor = true;
            // 
            // tb_shop_user_password
            // 
            this.tb_shop_user_password.Location = new System.Drawing.Point(4, 34);
            this.tb_shop_user_password.Name = "tb_shop_user_password";
            this.tb_shop_user_password.PlaceholderText = "Пароль";
            this.tb_shop_user_password.Size = new System.Drawing.Size(443, 23);
            this.tb_shop_user_password.TabIndex = 1;
            this.tb_shop_user_password.UseSystemPasswordChar = true;
            // 
            // tb_shop_user_login
            // 
            this.tb_shop_user_login.Location = new System.Drawing.Point(4, 4);
            this.tb_shop_user_login.Name = "tb_shop_user_login";
            this.tb_shop_user_login.PlaceholderText = "Логин";
            this.tb_shop_user_login.Size = new System.Drawing.Size(443, 23);
            this.tb_shop_user_login.TabIndex = 0;
            // 
            // tp_story_archive
            // 
            this.tp_story_archive.Controls.Add(this.tb_story_content);
            this.tp_story_archive.Controls.Add(this.tb_story_title);
            this.tp_story_archive.Location = new System.Drawing.Point(4, 24);
            this.tp_story_archive.Name = "tp_story_archive";
            this.tp_story_archive.Padding = new System.Windows.Forms.Padding(3);
            this.tp_story_archive.Size = new System.Drawing.Size(450, 156);
            this.tp_story_archive.TabIndex = 1;
            this.tp_story_archive.Text = "Архив Историй";
            this.tp_story_archive.UseVisualStyleBackColor = true;
            // 
            // tb_story_content
            // 
            this.tb_story_content.Location = new System.Drawing.Point(4, 34);
            this.tb_story_content.Multiline = true;
            this.tb_story_content.Name = "tb_story_content";
            this.tb_story_content.PlaceholderText = "Содержание";
            this.tb_story_content.Size = new System.Drawing.Size(443, 119);
            this.tb_story_content.TabIndex = 1;
            // 
            // tb_story_title
            // 
            this.tb_story_title.Location = new System.Drawing.Point(4, 4);
            this.tb_story_title.Name = "tb_story_title";
            this.tb_story_title.PlaceholderText = "Название";
            this.tb_story_title.Size = new System.Drawing.Size(443, 23);
            this.tb_story_title.TabIndex = 0;
            // 
            // tp_antiques
            // 
            this.tp_antiques.Controls.Add(this.cb_antique_thing_story_id);
            this.tp_antiques.Controls.Add(this.tb_antique_thing_storage_conditions);
            this.tp_antiques.Controls.Add(this.tb_antique_thing_description);
            this.tp_antiques.Controls.Add(this.tb_antique_thing_title);
            this.tp_antiques.Location = new System.Drawing.Point(4, 24);
            this.tp_antiques.Name = "tp_antiques";
            this.tp_antiques.Padding = new System.Windows.Forms.Padding(3);
            this.tp_antiques.Size = new System.Drawing.Size(450, 156);
            this.tp_antiques.TabIndex = 2;
            this.tp_antiques.Text = "Антиквариат";
            this.tp_antiques.UseVisualStyleBackColor = true;
            // 
            // cb_antique_thing_story_id
            // 
            this.cb_antique_thing_story_id.FormattingEnabled = true;
            this.cb_antique_thing_story_id.Location = new System.Drawing.Point(243, 4);
            this.cb_antique_thing_story_id.Name = "cb_antique_thing_story_id";
            this.cb_antique_thing_story_id.Size = new System.Drawing.Size(204, 23);
            this.cb_antique_thing_story_id.TabIndex = 3;
            this.cb_antique_thing_story_id.Text = "История";
            // 
            // tb_antique_thing_storage_conditions
            // 
            this.tb_antique_thing_storage_conditions.Location = new System.Drawing.Point(3, 130);
            this.tb_antique_thing_storage_conditions.Name = "tb_antique_thing_storage_conditions";
            this.tb_antique_thing_storage_conditions.PlaceholderText = "Условия хранения";
            this.tb_antique_thing_storage_conditions.Size = new System.Drawing.Size(444, 23);
            this.tb_antique_thing_storage_conditions.TabIndex = 2;
            // 
            // tb_antique_thing_description
            // 
            this.tb_antique_thing_description.Location = new System.Drawing.Point(4, 34);
            this.tb_antique_thing_description.Multiline = true;
            this.tb_antique_thing_description.Name = "tb_antique_thing_description";
            this.tb_antique_thing_description.PlaceholderText = "Описание";
            this.tb_antique_thing_description.Size = new System.Drawing.Size(443, 90);
            this.tb_antique_thing_description.TabIndex = 1;
            // 
            // tb_antique_thing_title
            // 
            this.tb_antique_thing_title.Location = new System.Drawing.Point(4, 4);
            this.tb_antique_thing_title.Name = "tb_antique_thing_title";
            this.tb_antique_thing_title.PlaceholderText = "Название";
            this.tb_antique_thing_title.Size = new System.Drawing.Size(233, 23);
            this.tb_antique_thing_title.TabIndex = 0;
            // 
            // tp_setout
            // 
            this.tp_setout.Controls.Add(this.cb_setout_antique_thing_id);
            this.tp_setout.Controls.Add(this.tb_setout_position_price);
            this.tp_setout.Location = new System.Drawing.Point(4, 24);
            this.tp_setout.Name = "tp_setout";
            this.tp_setout.Padding = new System.Windows.Forms.Padding(3);
            this.tp_setout.Size = new System.Drawing.Size(450, 156);
            this.tp_setout.TabIndex = 3;
            this.tp_setout.Text = "Витрина";
            this.tp_setout.UseVisualStyleBackColor = true;
            // 
            // cb_setout_antique_thing_id
            // 
            this.cb_setout_antique_thing_id.FormattingEnabled = true;
            this.cb_setout_antique_thing_id.Location = new System.Drawing.Point(4, 4);
            this.cb_setout_antique_thing_id.Name = "cb_setout_antique_thing_id";
            this.cb_setout_antique_thing_id.Size = new System.Drawing.Size(233, 23);
            this.cb_setout_antique_thing_id.TabIndex = 1;
            this.cb_setout_antique_thing_id.Text = "Товар";
            // 
            // tb_setout_position_price
            // 
            this.tb_setout_position_price.Location = new System.Drawing.Point(243, 4);
            this.tb_setout_position_price.Name = "tb_setout_position_price";
            this.tb_setout_position_price.PlaceholderText = "Цена";
            this.tb_setout_position_price.Size = new System.Drawing.Size(204, 23);
            this.tb_setout_position_price.TabIndex = 0;
            // 
            // tp_acquirers
            // 
            this.tp_acquirers.Controls.Add(this.tb_acquirer_last_name);
            this.tp_acquirers.Controls.Add(this.tb_acquirer_first_name);
            this.tp_acquirers.Location = new System.Drawing.Point(4, 24);
            this.tp_acquirers.Name = "tp_acquirers";
            this.tp_acquirers.Padding = new System.Windows.Forms.Padding(3);
            this.tp_acquirers.Size = new System.Drawing.Size(450, 156);
            this.tp_acquirers.TabIndex = 4;
            this.tp_acquirers.Text = "Покупатели";
            this.tp_acquirers.UseVisualStyleBackColor = true;
            // 
            // tb_acquirer_last_name
            // 
            this.tb_acquirer_last_name.Location = new System.Drawing.Point(4, 34);
            this.tb_acquirer_last_name.Name = "tb_acquirer_last_name";
            this.tb_acquirer_last_name.PlaceholderText = "Фамилия";
            this.tb_acquirer_last_name.Size = new System.Drawing.Size(443, 23);
            this.tb_acquirer_last_name.TabIndex = 1;
            // 
            // tb_acquirer_first_name
            // 
            this.tb_acquirer_first_name.Location = new System.Drawing.Point(4, 4);
            this.tb_acquirer_first_name.Name = "tb_acquirer_first_name";
            this.tb_acquirer_first_name.PlaceholderText = "Имя";
            this.tb_acquirer_first_name.Size = new System.Drawing.Size(443, 23);
            this.tb_acquirer_first_name.TabIndex = 0;
            // 
            // tp_cashbox
            // 
            this.tp_cashbox.Controls.Add(this.dtp_sale_date);
            this.tp_cashbox.Controls.Add(this.cb_sale_acquirer_id);
            this.tp_cashbox.Controls.Add(this.cb_sale_setout_position_id);
            this.tp_cashbox.Location = new System.Drawing.Point(4, 24);
            this.tp_cashbox.Name = "tp_cashbox";
            this.tp_cashbox.Padding = new System.Windows.Forms.Padding(3);
            this.tp_cashbox.Size = new System.Drawing.Size(450, 156);
            this.tp_cashbox.TabIndex = 5;
            this.tp_cashbox.Text = "Касса";
            this.tp_cashbox.UseVisualStyleBackColor = true;
            // 
            // dtp_sale_date
            // 
            this.dtp_sale_date.Location = new System.Drawing.Point(4, 33);
            this.dtp_sale_date.Name = "dtp_sale_date";
            this.dtp_sale_date.Size = new System.Drawing.Size(233, 23);
            this.dtp_sale_date.TabIndex = 2;
            // 
            // cb_sale_acquirer_id
            // 
            this.cb_sale_acquirer_id.FormattingEnabled = true;
            this.cb_sale_acquirer_id.Location = new System.Drawing.Point(244, 4);
            this.cb_sale_acquirer_id.Name = "cb_sale_acquirer_id";
            this.cb_sale_acquirer_id.Size = new System.Drawing.Size(203, 23);
            this.cb_sale_acquirer_id.TabIndex = 1;
            this.cb_sale_acquirer_id.Text = "Покупатель";
            // 
            // cb_sale_setout_position_id
            // 
            this.cb_sale_setout_position_id.FormattingEnabled = true;
            this.cb_sale_setout_position_id.Location = new System.Drawing.Point(4, 4);
            this.cb_sale_setout_position_id.Name = "cb_sale_setout_position_id";
            this.cb_sale_setout_position_id.Size = new System.Drawing.Size(233, 23);
            this.cb_sale_setout_position_id.TabIndex = 0;
            this.cb_sale_setout_position_id.Text = "Товар";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 202);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "Добавить";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(97, 202);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Изменить";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(178, 202);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dgv_main
            // 
            this.dgv_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_main.Location = new System.Drawing.Point(16, 231);
            this.dgv_main.MultiSelect = false;
            this.dgv_main.Name = "dgv_main";
            this.dgv_main.RowTemplate.Height = 25;
            this.dgv_main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_main.Size = new System.Drawing.Size(450, 410);
            this.dgv_main.TabIndex = 4;
            // 
            // DBAdminForm
            // 
            this.ClientSize = new System.Drawing.Size(482, 653);
            this.Controls.Add(this.dgv_main);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.tc_main);
            this.Name = "DBAdminForm";
            this.tc_main.ResumeLayout(false);
            this.tp_shop_users.ResumeLayout(false);
            this.tp_shop_users.PerformLayout();
            this.tp_story_archive.ResumeLayout(false);
            this.tp_story_archive.PerformLayout();
            this.tp_antiques.ResumeLayout(false);
            this.tp_antiques.PerformLayout();
            this.tp_setout.ResumeLayout(false);
            this.tp_setout.PerformLayout();
            this.tp_acquirers.ResumeLayout(false);
            this.tp_acquirers.PerformLayout();
            this.tp_cashbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_main)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
