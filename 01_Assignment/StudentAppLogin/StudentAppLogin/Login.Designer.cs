
namespace StudentAppLogin
{
    partial class frm_Login_Form
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
            this.lbn_Login_Form = new System.Windows.Forms.Label();
            this.lbn_Username = new System.Windows.Forms.Label();
            this.lbn_Password = new System.Windows.Forms.Label();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbn_Login_Form
            // 
            this.lbn_Login_Form.AutoSize = true;
            this.lbn_Login_Form.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbn_Login_Form.Font = new System.Drawing.Font("Georgia", 30.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Login_Form.ForeColor = System.Drawing.Color.Black;
            this.lbn_Login_Form.Location = new System.Drawing.Point(279, 32);
            this.lbn_Login_Form.Name = "lbn_Login_Form";
            this.lbn_Login_Form.Size = new System.Drawing.Size(290, 59);
            this.lbn_Login_Form.TabIndex = 0;
            this.lbn_Login_Form.Text = "Login Form";
            // 
            // lbn_Username
            // 
            this.lbn_Username.AutoSize = true;
            this.lbn_Username.Font = new System.Drawing.Font("Georgia", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Username.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbn_Username.Location = new System.Drawing.Point(81, 167);
            this.lbn_Username.Name = "lbn_Username";
            this.lbn_Username.Size = new System.Drawing.Size(177, 41);
            this.lbn_Username.TabIndex = 1;
            this.lbn_Username.Text = "Username";
            // 
            // lbn_Password
            // 
            this.lbn_Password.AutoSize = true;
            this.lbn_Password.Font = new System.Drawing.Font("Georgia", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Password.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbn_Password.Location = new System.Drawing.Point(89, 295);
            this.lbn_Password.Name = "lbn_Password";
            this.lbn_Password.Size = new System.Drawing.Size(166, 41);
            this.lbn_Password.TabIndex = 2;
            this.lbn_Password.Text = "Password";
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.White;
            this.btn_Submit.Font = new System.Drawing.Font("Georgia", 20.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(289, 424);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(224, 54);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // tb_Username
            // 
            this.tb_Username.BackColor = System.Drawing.Color.White;
            this.tb_Username.Location = new System.Drawing.Point(514, 164);
            this.tb_Username.MaxLength = 30;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(327, 46);
            this.tb_Username.TabIndex = 1;
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.White;
            this.tb_Password.Location = new System.Drawing.Point(514, 295);
            this.tb_Password.MaxLength = 20;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '$';
            this.tb_Password.Size = new System.Drawing.Size(327, 46);
            this.tb_Password.TabIndex = 2;
            // 
            // frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(916, 532);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbn_Password);
            this.Controls.Add(this.lbn_Username);
            this.Controls.Add(this.lbn_Login_Form);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "frm_Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbn_Login_Form;
        private System.Windows.Forms.Label lbn_Username;
        private System.Windows.Forms.Label lbn_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
    }
}

