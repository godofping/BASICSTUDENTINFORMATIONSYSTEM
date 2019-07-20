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
    public partial class Form1 : Form
    {

        string connectionString = @"Server=localhost;Database=student_information_db;Uid=root;Pwd=;";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            loadSections();
            loadDataGridView();
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
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("addStudents", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("tb_firstName", tb_firstName.Text.Trim());
                    cmd.Parameters.AddWithValue("tb_lastName", tb_lastName.Text.Trim());
                    cmd.Parameters.AddWithValue("cb_section", cb_section.SelectedValue.ToString());

                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("SUCCESS");
                        clearFields();
                        loadDataGridView();
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
            MessageBox.Show(cb_section.SelectedValue.ToString());
        }

        private void disableForm(string Status)
        {
            if (Status.Equals("enabled"))
            {
                tb_firstName.Enabled = true;
                tb_lastName.Enabled = true;
                cb_section.Enabled = true;
            }
            else if (Status.Equals("disabled"))
            {
                tb_firstName.Enabled = false;
                tb_lastName.Enabled = false;
                cb_section.Enabled = false;
            }
        }

        private void loadDataGridView()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                using (MySqlDataAdapter adapter = new MySqlDataAdapter("select studentId as 'Student ID', concat(firstName, ' ', lastName) as 'Full Name', section as Section from students_view", conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dg_students.DataSource = ds.Tables[0];
                }


            }

            dg_students.Columns[0].Width = 65;
            dg_students.Columns[1].Width = 180;
        }
    }
}
