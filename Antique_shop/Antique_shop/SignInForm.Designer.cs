
namespace Antique_shop
{
    partial class SignInForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.btn_signIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(12, 44);
            this.tb_password.MaxLength = 32;
            this.tb_password.Name = "tb_password";
            this.tb_password.PlaceholderText = "Пароль";
            this.tb_password.Size = new System.Drawing.Size(182, 23);
            this.tb_password.TabIndex = 1;
            this.tb_password.UseSystemPasswordChar = true;
            this.tb_password.WordWrap = false;
            this.tb_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_password_KeyPress);
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(12, 12);
            this.tb_login.MaxLength = 32;
            this.tb_login.Name = "tb_login";
            this.tb_login.PlaceholderText = "Логин";
            this.tb_login.Size = new System.Drawing.Size(182, 23);
            this.tb_login.TabIndex = 0;
            this.tb_login.WordWrap = false;
            this.tb_login.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_login_KeyPress);
            // 
            // btn_signIn
            // 
            this.btn_signIn.Location = new System.Drawing.Point(12, 74);
            this.btn_signIn.Name = "btn_signIn";
            this.btn_signIn.Size = new System.Drawing.Size(182, 23);
            this.btn_signIn.TabIndex = 2;
            this.btn_signIn.Text = "Войти";
            this.btn_signIn.UseVisualStyleBackColor = true;
            this.btn_signIn.Click += new System.EventHandler(this.btn_signIn_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 109);
            this.Controls.Add(this.btn_signIn);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_password);
            this.Name = "SignInForm";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.Button btn_signIn;
    }
}

