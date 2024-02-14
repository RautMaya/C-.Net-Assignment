using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentAppLogin
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
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

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            S_Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = DBCon;
            Cmd.CommandText = "Select Count(*) From Login_Details Where Username = @urn And Password = @psw";

            Cmd.Parameters.Add("urn", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("psw", SqlDbType.NVarChar).Value = tb_Password.Text;

            int Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Succesfully", "Welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Shared_Content.LoggedInUser = tb_Username.Text;
                frm_Student_Details Obj = new frm_Student_Details();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login_Failed_Enter_Correct_Username_Password", "Try_Again");
            }

            tb_Username.Clear();
            tb_Password.Clear();

            tb_Username.Focus();

            S_Con_Close();



        }
    }
}
