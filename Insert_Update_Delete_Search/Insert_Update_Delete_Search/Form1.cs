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

namespace Insert_Update_Delete_Search
{
    public partial class Frm_Insert_Update_Delete_Search : Form
    {
        public Frm_Insert_Update_Delete_Search()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-38U3S54;Initial Catalog=Insert_Update_Delete_Search_DB;Integrated Security=True");

        void Con_Open()
        {
            if(Con.State!=ConnectionState.Open)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State!=ConnectionState.Closed)
            {
                Con.Close();
            }
        }



        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)||(e.KeyChar==(char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar==(char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Frm_Insert_Update_Delete_Search_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'insert_Update_Delete_Search_DBDataSet.User_Table' table. You can move, or remove it, as needed.
            this.user_TableTableAdapter.Fill(this.insert_Update_Delete_Search_DBDataSet.User_Table);

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Con_Open();

            if(tb_ID.Text!= " " && tb_Name.Text!=" " && tb_Age.Text!= " ")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insert Into User_Table(ID,Name,Age) Values(@ID,@Name,@Age)";

                cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_ID.Text;
                cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Age", SqlDbType.Float).Value = tb_Age.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Succesfully Saved");
                Clear_Controls();


            }
            else
            {
                MessageBox.Show("Fill All The Fields First");
            }
            Con_Close();
        }


        void Clear_Controls()
        {
            tb_ID.Clear();
            tb_Name.Clear();
            tb_Age.Clear();

        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand cmd = new SqlCommand("Update User_Table Set Name=@Name,Age=@Age Where ID=@ID",Con);
            cmd.Connection = Con;

            cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_ID.Text;
            cmd.Parameters.Add("Name", SqlDbType.NVarChar).Value = tb_Name.Text;
            cmd.Parameters.Add("Age", SqlDbType.Float).Value = tb_Age.Text;

            cmd.ExecuteNonQuery();
            Con_Close();
            MessageBox.Show("Succesfully Updated");

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd = new SqlCommand();


            Con_Open();
            SqlCommand cmd = new SqlCommand("Delete  User_Table where ID=@ID", Con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(tb_ID.Text));
            cmd.ExecuteNonQuery();
            Con_Close();
            MessageBox.Show("Successfully Deleted");
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            
            Con_Open();

            SqlCommand cmd = new SqlCommand("Select * from User_Table where ID=@ID", Con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(tb_ID.Text));
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            Con_Close();
        }
    }
}
