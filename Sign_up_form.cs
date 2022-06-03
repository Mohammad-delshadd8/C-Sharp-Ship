using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ship
{
    public partial class Sign_up_form : Form
    {
        public Sign_up_form()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void libl_SignInbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Sign_in_form().ShowDialog();
            



        }

        private void btn_signUp_Click(object sender, EventArgs e)
        {
            if (txt_pass_signUp.Text == txt_confirmPass.Text)
            {
                MessageBox.Show("Username :" + txt_username_signUp.Text + "\n Password: " + txt_pass_signUp.Text, "Login Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new Main_form().ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Confirm your password please", "Wrong!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pass_signUp.Clear();
                txt_confirmPass.Clear();

            }
        }

        private void txt_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (int)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }
    }
    
}
