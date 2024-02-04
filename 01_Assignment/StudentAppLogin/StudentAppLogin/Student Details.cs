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

namespace StudentAppLogin
{
    public partial class frm_Student_Details : Form
    {
        public frm_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection DBCon = new SqlConnection(@"Data Source=DESKTOP-38U3S54;Initial Catalog=StudentAppLogin_DB;Integrated Security=True");
        void S_Con_Open()
        {
            if (DBCon.State!=ConnectionState.Open)
            {
                DBCon.Open();

            }
        }
        void S_Con_Close()
        {
            if (DBCon.State!=ConnectionState.Closed)
            {
                DBCon.Close();

            }
        }
        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List Obj = new frm_Student_List();
            Obj.Show();
            this.Hide();
           
        }
        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Full_Name.Clear();
            tb_Mobile_No.Clear();

            dtp_Date_Of_Birth.ResetText();
            cmb_Course.SelectedIndex = -1;
        }


        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            S_Con_Open();

            if (tb_Roll_No.Text!=""&&tb_Full_Name.Text!=""&&tb_Mobile_No.Text!=""&&cmb_Course.Text!="")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = DBCon;
                Cmd.CommandText = "Insert Into Student_Details(Roll_No,Full_Name,Date_Of_Birth,Mobile_No,Course) Values(@RNo,@Nm,@Dob,@MNo,@Course)";

                Cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Full_Name.Text;
                Cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_Date_Of_Birth.Text;
                Cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Student Information Saved Succesfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("1st Fill all Fields", "Incomplete Data ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            S_Con_Close();

        }

       

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login_Form Obj = new frm_Login_Form();
            Obj.Show();
            this.Hide();
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)||(e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;

            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;

            }

        }
    }
}
