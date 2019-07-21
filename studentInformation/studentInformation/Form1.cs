using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace studentInformation

{
    public partial class mainForm : Form
    {

        string connectionString = @"Server=localhost;Database=student_information_db;Uid=root;Pwd=;";
        string mode = "";
        int studentId = 0;

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            loadSections();
            loadDataGridView();
            disableForm(true);
        }


        private void B_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private void clearFields()
        {
            tb_firstName.Clear();
            tb_lastName.Clear();
            cb_section.SelectedIndex = 0;

        }


        private void loadSections()
        {
            using (MySqlConnection c = new MySqlConnection(connectionString))
            {
                c.Open();

                var sql = "SELECT * from sections_table";
                using (MySqlCommand cmd = new MySqlCommand(sql, c))
                {
                    var dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    cb_section.ValueMember = "sectionId";
                    cb_section.DisplayMember = "section";
                    cb_section.DataSource = dt;
                }
            }
        }

        private void B_save_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (mode.Equals("add"))
                {
                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {

                        using (MySqlCommand cmd = new MySqlCommand("addStudents", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("_firstName", tb_firstName.Text.Trim());
                            cmd.Parameters.AddWithValue("_lastName", tb_lastName.Text.Trim());
                            cmd.Parameters.AddWithValue("_sectionId", cb_section.SelectedValue.ToString());
                            conn.Open();
                            cmd.ExecuteNonQuery();

                            message("ADDED");
                        }

                    }
                }
                else if (mode.Equals("update"))
                {

                    using (MySqlConnection conn = new MySqlConnection(connectionString))
                    {

                        using (MySqlCommand cmd = new MySqlCommand("updateStudents", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("_studentId", studentId);
                            cmd.Parameters.AddWithValue("_firstName", tb_firstName.Text.Trim());
                            cmd.Parameters.AddWithValue("_lastName", tb_lastName.Text.Trim());
                            cmd.Parameters.AddWithValue("_sectionId", cb_section.SelectedValue.ToString());
                            conn.Open();
                            cmd.ExecuteNonQuery();

                            message("UPDATED");
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            disableForm(false);
            clearFields();
            mode = "add";

        }

        private void disableForm(bool Status)
        {
            tb_firstName.Enabled = !Status;
            tb_lastName.Enabled = !Status;
            cb_section.Enabled = !Status;

            b_add.Enabled = Status;
            b_update.Enabled = Status;
            b_delete.Enabled = Status;

            b_save.Enabled = !Status;
            b_cancel.Enabled = !Status;
            b_clear.Enabled = !Status;
         
        }

        private void loadDataGridView()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("select studentId as 'Student ID', concat(firstName, ' ', lastName) as 'Full Name', section as Section, sectionId,firstName, lastName from students_view where concat(firstName, ' ', lastName) like '%" + tb_search.Text + "%'", conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dg_students.DataSource = ds.Tables[0];
                }
            }

   
            dg_students.Columns["sectionId"].Visible = false;
            dg_students.Columns["firstName"].Visible = false;
            dg_students.Columns["lastName"].Visible = false;

            //dg_students.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void B_cancel_Click(object sender, EventArgs e)
        {
            disableForm(true);
            clearFields();
        }

        private void B_update_Click(object sender, EventArgs e)
        {
            disableForm(false);
            mode = "update";
           
        }



        private void Dg_students_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dg_students.SelectedRows)
            {
                studentId = Convert.ToInt32(row.Cells["Student ID"].Value);
                tb_firstName.Text = row.Cells["firstName"].Value.ToString();
                tb_lastName.Text = row.Cells["lastName"].Value.ToString();
                cb_section.Text = row.Cells["Section"].Value.ToString();

            }
        }

        private void B_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {

                using (MySqlCommand cmd = new MySqlCommand("deleteStudents", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_studentId", studentId);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                    message("DELETED");


                }

            }
        }


        public void message(string message)
        {
            MessageBox.Show(message);
            clearFields();
            loadDataGridView();
            disableForm(true);
        }

        private void Tb_search_TextChanged(object sender, EventArgs e)
        {
            loadDataGridView();
            
        }
    }


   
}
