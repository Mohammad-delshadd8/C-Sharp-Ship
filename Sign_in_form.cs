namespace Ship
{
    public partial class Sign_in_form : Form
    {
        public Sign_in_form()
        {
          
            InitializeComponent();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            string username = "Mo";
            string password = "1234";
            if (txt_username.Text == username & txt_pass.Text == password)
            {
                this.Hide();
                new Main_form().ShowDialog();
               

            }
            else {
                MessageBox.Show("Wrong Username or Password. Please try again.", "Wrong!" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_pass.Clear();
                txt_username.Clear();
            }

        }

        private void libl_SignUpbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Sign_up_form().ShowDialog();
           

        }

        private void Sign_in_form_Load(object sender, EventArgs e)
        {

        }
    }
}