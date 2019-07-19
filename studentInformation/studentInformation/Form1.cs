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
            clearFields();
            loadSections();
        }


        private void B_clear_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private void clearFields()
        {
            tb_firstName.Clear();
            tb_lastName.Clear();
            cb_section.ResetText();

        }


        private void loadSections()
        {
            using (MySqlConnection c = new MySqlConnection(connectionString))
            {
                c.Open();

                var sql = "SELECT * from section_table";
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
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("studentAddorEdit", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                //mySqlCmd.Parameters.AddWithValue("");
            }
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_section.SelectedValue.ToString());
        }
    }
}
