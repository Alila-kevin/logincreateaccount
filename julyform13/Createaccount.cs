using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace julyform13
{
    public partial class Createaccount : Form
    {
        public Createaccount()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            // Check if all fields have been filled
            if (!string.IsNullOrEmpty(txtbfname.Text) && !string.IsNullOrEmpty(txtbuser.Text) && !string.IsNullOrEmpty(txtbno.Text) && !string.IsNullOrEmpty(txtmail.Text) && !string.IsNullOrEmpty(txtbpass.Text) && !string.IsNullOrEmpty(txtcpass.Text))
            {
                string name = txtbfname.Text;
               string mpass = txtbpass.Text;
               string kpass = txtcpass.Text;

                if (mpass != kpass)
                {
                    MessageBox.Show("The passaword provided doesn't match!!");
                }
                else
                {

                    // Perform the save operation here (e.g., save data to a database or file)

                    MessageBox.Show($"Save successfully with the name {name} provided");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Classic Classic = new Classic();
            Classic.Show();
        }
    }
}
