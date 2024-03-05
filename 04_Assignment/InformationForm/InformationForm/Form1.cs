using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationForm
{
    public partial class frm_Information : Form
    {
        public frm_Information()
        {
            InitializeComponent();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) ||(e.KeyChar==(char)Keys.Back) || (e.KeyChar==(char)Keys.Space) ||(e.KeyChar==(char)Keys.ShiftKey) ||(e.KeyChar==(char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = " ";
            bool Flag = true;
            if (tb_Employee_Name.Text!=" ")
            {
                Result = tb_Employee_Name.Text;
                
                { 

                if (cmb_Employee_Department.Text!=" ")
                {
                    Result += " From Department "  + cmb_Employee_Department.Text + " is ";
                }
                if (rb_Female.Checked==true)
                {
                    Result += rb_Female.Text + " And her Working Time Shedule is ";
                }
                else if(rb_Male.Checked==true)
                {
                    Result += rb_Male.Text + " And his Working Time Shedule is ";
                }
                else
                {
                    MessageBox.Show(" Select Gender Of Employee ");
                    Flag = false;
                }
                }
                { 
                if (rb_Morning.Checked==true)
                {
                    Result += rb_Morning.Text + " . ";
                }
                else if (rb_Evening.Checked==true)
                {
                    Result += rb_Evening.Text + " . ";
                }
                else if (rb_Night.Checked==true)
                {
                    Result += rb_Night.Text + " . ";
                }
                else
                {
                    MessageBox.Show("Select Shift Time");
                    Flag = false;
                }
                }
             
            }
            else
            {
                
                MessageBox.Show("Selcet Employee Name");
                Flag = false;
            }
            if (Flag == true)
            {
                tb_Output.Text = Result;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            tb_Employee_Name.Clear();
            tb_Output.Clear();

            cmb_Employee_Department.SelectedIndex = -1;

            rb_Evening.Checked = false;
            rb_Morning.Checked = false;
            rb_Night.Checked = false;

            rb_Female.Checked = false;
            rb_Male.Checked = false;


            tb_Employee_Name.Focus();
        }
    }
}
