
namespace Insert_Update_Delete_Search
{
    partial class Frm_Insert_Update_Delete_Search
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Insert_Update_Delete_Search = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Age = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insert_Update_Delete_Search_DBDataSet = new Insert_Update_Delete_Search.Insert_Update_Delete_Search_DBDataSet();
            this.user_TableTableAdapter = new Insert_Update_Delete_Search.Insert_Update_Delete_Search_DBDataSetTableAdapters.User_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_Update_Delete_Search_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Insert_Update_Delete_Search
            // 
            this.lbl_Insert_Update_Delete_Search.AutoSize = true;
            this.lbl_Insert_Update_Delete_Search.Font = new System.Drawing.Font("Georgia", 20.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Insert_Update_Delete_Search.Location = new System.Drawing.Point(360, 20);
            this.lbl_Insert_Update_Delete_Search.Name = "lbl_Insert_Update_Delete_Search";
            this.lbl_Insert_Update_Delete_Search.Size = new System.Drawing.Size(566, 41);
            this.lbl_Insert_Update_Delete_Search.TabIndex = 0;
            this.lbl_Insert_Update_Delete_Search.Text = "Insert Update Delete Search in SQL";
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(81, 148);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(40, 31);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "lD";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Age.Location = new System.Drawing.Point(81, 333);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(62, 31);
            this.lbl_Age.TabIndex = 2;
            this.lbl_Age.Text = "Age";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(81, 242);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(86, 31);
            this.lbl_Name.TabIndex = 3;
            this.lbl_Name.Text = "Name";
            // 
            // tb_ID
            // 
            this.tb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ID.Location = new System.Drawing.Point(291, 145);
            this.tb_ID.MaxLength = 20;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(334, 43);
            this.tb_ID.TabIndex = 1;
            
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(291, 242);
            this.tb_Name.MaxLength = 80;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(334, 43);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Age
            // 
            this.tb_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Age.Location = new System.Drawing.Point(291, 327);
            this.tb_Age.MaxLength = 2;
            this.tb_Age.Name = "tb_Age";
            this.tb_Age.Size = new System.Drawing.Size(334, 43);
            this.tb_Age.TabIndex = 3;
            this.tb_Age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Insert
            // 
            this.btn_Insert.BackColor = System.Drawing.Color.Silver;
            this.btn_Insert.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Insert.Location = new System.Drawing.Point(72, 468);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(120, 66);
            this.btn_Insert.TabIndex = 7;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Silver;
            this.btn_Delete.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(788, 459);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(120, 66);
            this.btn_Delete.TabIndex = 8;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Silver;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(959, 459);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(120, 66);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Silver;
            this.btn_Update.Font = new System.Drawing.Font("Georgia", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Location = new System.Drawing.Point(253, 468);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(120, 66);
            this.btn_Update.TabIndex = 10;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(684, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(564, 285);
            this.dataGridView1.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "User_Table";
            this.userTableBindingSource.DataSource = this.insert_Update_Delete_Search_DBDataSet;
            // 
            // insert_Update_Delete_Search_DBDataSet
            // 
            this.insert_Update_Delete_Search_DBDataSet.DataSetName = "Insert_Update_Delete_Search_DBDataSet";
            this.insert_Update_Delete_Search_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // user_TableTableAdapter
            // 
            this.user_TableTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Insert_Update_Delete_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.tb_Age);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_ID);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Insert_Update_Delete_Search);
            this.Name = "Frm_Insert_Update_Delete_Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Insert Update Delete Search";
            this.Load += new System.EventHandler(this.Frm_Insert_Update_Delete_Search_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insert_Update_Delete_Search_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Insert_Update_Delete_Search;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Age;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Insert_Update_Delete_Search_DBDataSet insert_Update_Delete_Search_DBDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private Insert_Update_Delete_Search_DBDataSetTableAdapters.User_TableTableAdapter user_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
    }
}

