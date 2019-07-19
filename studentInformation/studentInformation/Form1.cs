using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentInformation

{
    public partial class Form1 : Form
    {

        string firstname = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void B_submit_Click(object sender, EventArgs e)
        {
            firstname = tb_firstName.Text;
            MessageBox.Show(firstname);
           
        }
    }
}
