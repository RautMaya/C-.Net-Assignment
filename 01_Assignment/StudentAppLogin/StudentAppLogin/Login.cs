using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAppLogin
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Admin" && tb_Password.Text == "123")
            {
                MessageBox.Show("Login Succesfully", "Welcome");
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



        }
    }
}
