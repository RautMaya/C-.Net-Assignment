
namespace StudentAppLogin
{
    partial class frm_Student_Details
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
            this.lbn_Add_Student_Details = new System.Windows.Forms.Label();
            this.lbn_Roll_No = new System.Windows.Forms.Label();
            this.lbn_Course = new System.Windows.Forms.Label();
            this.lbn_Date_Of_Birth = new System.Windows.Forms.Label();
            this.lbn_Mobile_No = new System.Windows.Forms.Label();
            this.lbn_Full_Name = new System.Windows.Forms.Label();
            this.tb_Full_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_Date_Of_Birth = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Log_Out = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbn_Add_Student_Details
            // 
            this.lbn_Add_Student_Details.AutoSize = true;
            this.lbn_Add_Student_Details.BackColor = System.Drawing.Color.White;
            this.lbn_Add_Student_Details.Font = new System.Drawing.Font("Mongolian Baiti", 35.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Add_Student_Details.ForeColor = System.Drawing.Color.Black;
            this.lbn_Add_Student_Details.Location = new System.Drawing.Point(274, 21);
            this.lbn_Add_Student_Details.Name = "lbn_Add_Student_Details";
            this.lbn_Add_Student_Details.Size = new System.Drawing.Size(507, 63);
            this.lbn_Add_Student_Details.TabIndex = 0;
            this.lbn_Add_Student_Details.Text = "Add Student Details";
            // 
            // lbn_Roll_No
            // 
            this.lbn_Roll_No.AutoSize = true;
            this.lbn_Roll_No.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Roll_No.ForeColor = System.Drawing.Color.Green;
            this.lbn_Roll_No.Location = new System.Drawing.Point(110, 133);
            this.lbn_Roll_No.Name = "lbn_Roll_No";
            this.lbn_Roll_No.Size = new System.Drawing.Size(136, 41);
            this.lbn_Roll_No.TabIndex = 1;
            this.lbn_Roll_No.Text = "Roll No";
            // 
            // lbn_Course
            // 
            this.lbn_Course.AutoSize = true;
            this.lbn_Course.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Course.ForeColor = System.Drawing.Color.Green;
            this.lbn_Course.Location = new System.Drawing.Point(110, 442);
            this.lbn_Course.Name = "lbn_Course";
            this.lbn_Course.Size = new System.Drawing.Size(125, 41);
            this.lbn_Course.TabIndex = 3;
            this.lbn_Course.Text = "Course";
            // 
            // lbn_Date_Of_Birth
            // 
            this.lbn_Date_Of_Birth.AutoSize = true;
            this.lbn_Date_Of_Birth.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Date_Of_Birth.ForeColor = System.Drawing.Color.Green;
            this.lbn_Date_Of_Birth.Location = new System.Drawing.Point(110, 368);
            this.lbn_Date_Of_Birth.Name = "lbn_Date_Of_Birth";
            this.lbn_Date_Of_Birth.Size = new System.Drawing.Size(223, 41);
            this.lbn_Date_Of_Birth.TabIndex = 4;
            this.lbn_Date_Of_Birth.Text = "Date Of Birth";
            // 
            // lbn_Mobile_No
            // 
            this.lbn_Mobile_No.AutoSize = true;
            this.lbn_Mobile_No.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Mobile_No.ForeColor = System.Drawing.Color.Green;
            this.lbn_Mobile_No.Location = new System.Drawing.Point(110, 289);
            this.lbn_Mobile_No.Name = "lbn_Mobile_No";
            this.lbn_Mobile_No.Size = new System.Drawing.Size(180, 41);
            this.lbn_Mobile_No.TabIndex = 5;
            this.lbn_Mobile_No.Text = "Mobile No";
            // 
            // lbn_Full_Name
            // 
            this.lbn_Full_Name.AutoSize = true;
            this.lbn_Full_Name.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_Full_Name.ForeColor = System.Drawing.Color.Green;
            this.lbn_Full_Name.Location = new System.Drawing.Point(110, 216);
            this.lbn_Full_Name.Name = "lbn_Full_Name";
            this.lbn_Full_Name.Size = new System.Drawing.Size(180, 41);
            this.lbn_Full_Name.TabIndex = 6;
            this.lbn_Full_Name.Text = "Full Name";
            // 
            // tb_Full_Name
            // 
            this.tb_Full_Name.BackColor = System.Drawing.Color.White;
            this.tb_Full_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Full_Name.Location = new System.Drawing.Point(539, 210);
            this.tb_Full_Name.MaxLength = 50;
            this.tb_Full_Name.Name = "tb_Full_Name";
            this.tb_Full_Name.Size = new System.Drawing.Size(479, 47);
            this.tb_Full_Name.TabIndex = 2;
            this.tb_Full_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.BackColor = System.Drawing.Color.White;
            this.tb_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(539, 127);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(479, 47);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.BackColor = System.Drawing.Color.White;
            this.tb_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(539, 283);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(479, 47);
            this.tb_Mobile_No.TabIndex = 3;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_Date_Of_Birth
            // 
            this.dtp_Date_Of_Birth.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Date_Of_Birth.Location = new System.Drawing.Point(539, 362);
            this.dtp_Date_Of_Birth.MinDate = new System.DateTime(2004, 1, 1, 0, 0, 0, 0);
            this.dtp_Date_Of_Birth.Name = "dtp_Date_Of_Birth";
            this.dtp_Date_Of_Birth.Size = new System.Drawing.Size(479, 47);
            this.dtp_Date_Of_Birth.TabIndex = 4;
            this.dtp_Date_Of_Birth.Value = new System.DateTime(2024, 2, 23, 23, 59, 59, 0);
            // 
            // cmb_Course
            // 
            this.cmb_Course.BackColor = System.Drawing.Color.White;
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "MCS",
            "BCA",
            "MCA",
            "Bsc",
            "Msc"});
            this.cmb_Course.Location = new System.Drawing.Point(539, 439);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(479, 49);
            this.cmb_Course.TabIndex = 7;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Black;
            this.btn_Save.Location = new System.Drawing.Point(390, 595);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(174, 51);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.White;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.Black;
            this.btn_Refresh.Location = new System.Drawing.Point(95, 595);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(174, 51);
            this.btn_Refresh.TabIndex = 9;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.White;
            this.btn_Student_List.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Student_List.ForeColor = System.Drawing.Color.Black;
            this.btn_Student_List.Location = new System.Drawing.Point(677, 595);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(276, 51);
            this.btn_Student_List.TabIndex = 10;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_Log_Out
            // 
            this.btn_Log_Out.BackColor = System.Drawing.Color.White;
            this.btn_Log_Out.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Log_Out.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_Log_Out.Location = new System.Drawing.Point(1028, 1);
            this.btn_Log_Out.Name = "btn_Log_Out";
            this.btn_Log_Out.Size = new System.Drawing.Size(127, 46);
            this.btn_Log_Out.TabIndex = 11;
            this.btn_Log_Out.Text = "Log Out";
            this.btn_Log_Out.UseVisualStyleBackColor = false;
            this.btn_Log_Out.Click += new System.EventHandler(this.btn_Log_Out_Click);
            // 
            // frm_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1167, 722);
            this.Controls.Add(this.btn_Log_Out);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_Date_Of_Birth);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.tb_Full_Name);
            this.Controls.Add(this.lbn_Full_Name);
            this.Controls.Add(this.lbn_Mobile_No);
            this.Controls.Add(this.lbn_Date_Of_Birth);
            this.Controls.Add(this.lbn_Course);
            this.Controls.Add(this.lbn_Roll_No);
            this.Controls.Add(this.lbn_Add_Student_Details);
            this.Name = "frm_Student_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbn_Add_Student_Details;
        private System.Windows.Forms.Label lbn_Roll_No;
        private System.Windows.Forms.Label lbn_Course;
        private System.Windows.Forms.Label lbn_Date_Of_Birth;
        private System.Windows.Forms.Label lbn_Mobile_No;
        private System.Windows.Forms.Label lbn_Full_Name;
        private System.Windows.Forms.TextBox tb_Full_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_Date_Of_Birth;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Log_Out;
    }
}