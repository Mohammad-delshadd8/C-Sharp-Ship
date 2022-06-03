namespace Ship
{

    public partial class Main_form : Form
    {
        int price = 250;
        int price_start = 0;
        int price_way = 0;
        int price_cargo_type = 0;
        int price_cargo_description = 0;
        int price_repository = 0;
        int price_worker = 0;

        public string result_price;
        public string result_start;
        public string result_destination;
        public string result_workers;
        public string result_time;
        public string result_repository;
        public string result_ship_code;



        public Main_form()
        {

            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cbo_destination.Text = null;
            cbo_start.Text = null;
            btn_price.Enabled = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            txt_price.Clear();
            txt_price.ForeColor = Color.Blue;
            txt_price.Text =
                "\n per Way          :   " + price_way.ToString() + " $" +
                "\n per Type         :   " + price_cargo_type.ToString() + " $" +
                "\n per Specialty    :   " + price_cargo_description.ToString() + " $" +
                "\n per Repository   :   " + price_repository.ToString() + " $" +
                "\n per Workers      :   " + price_worker.ToString() + " $" +
                "\n---------------------------------------------------------\n" +
                "Total price ( Tax added ) :   " + price.ToString() + " $";
            btn_price.Visible = false;
            btn_order.Visible = true;

            if (chBx_privacy.Checked == true)
            {
                progressBar1.Value = progressBar1.Value + 30;
            }
            if (chBx_licences.Checked == true)
            {
                progressBar1.Value = progressBar1.Value + 35;
            }
            if (chBx_insurance.Checked == true)
            {
                progressBar1.Value = progressBar1.Value + 35;
            }

            if (progressBar1.Value == 100)
            {
                lbl_result.ForeColor = Color.Green;
                lbl_result.Text = "Complete";
            }

            if (progressBar1.Value != 100)
            {
                lbl_result.ForeColor = Color.Red;
                lbl_result.Text = "Call for Help";
            }



            if (chBx_Repository.Checked == true)
            {
                result_repository = "Repository : Yes";

            }
            if (chBx_Repository.Checked == false)
            {
                result_repository = "Repository : No";

            }
            result_price = "Total price : " + Convert.ToString(price) + "$";
            result_start = "Loading place : " + cbo_start.SelectedItem;
            result_destination = "Delivary place : " + cbo_destination.SelectedItem;
            result_workers = "Number of workers : " + Convert.ToString(num_worker.Value);
            result_time = "Loading time : " + dateTimePicker1.Text;

        }

        private void rdBtn_dry_CheckedChanged(object sender, EventArgs e)
        {
            price_cargo_type = 0;
            price_cargo_type = price_cargo_type + 400;
            price = price + price_cargo_type;
        }

        private void cbo_start_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_start.SelectedItem == cbo_start.Items[2] ||
                cbo_start.SelectedItem == cbo_start.Items[4] ||
                cbo_start.SelectedItem == cbo_start.Items[5] ||
                cbo_start.SelectedItem == cbo_start.Items[6] ||
                cbo_start.SelectedItem == cbo_start.Items[7] ||
                cbo_start.SelectedItem == cbo_start.Items[9])
            {
                price_start = 0;
                price_start = price + 1200;
            }
            else
            {
                price_start = 0;
                price_start = price + 1000;
            }


        }

        private void cbo_destination_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_start.SelectedItem == cbo_start.Items[2] ||
                cbo_start.SelectedItem == cbo_start.Items[4] ||
                cbo_start.SelectedItem == cbo_start.Items[5] ||
                cbo_start.SelectedItem == cbo_start.Items[6] ||
                cbo_start.SelectedItem == cbo_start.Items[7] ||
                cbo_start.SelectedItem == cbo_start.Items[9])
            {
                price_way = 0;
                price_way = price_start + 1200;
                price = price + price_way;




            }
            else
            {
                price_way = 0;
                price_way = price_start + 1000;
                price = price + price_way;


            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdBtn_container_CheckedChanged(object sender, EventArgs e)
        {
            price_cargo_type = 0;
            price_cargo_type = price_cargo_type + 400;
            price = price + price_cargo_type;
        }

        private void rdBtn_liquid_CheckedChanged(object sender, EventArgs e)
        {
            price_cargo_type = 0;
            price_cargo_type = price_cargo_type + 500;
            price = price + price_cargo_type;
        }

        private void rdBtn_cold_CheckedChanged(object sender, EventArgs e)
        {
            price_cargo_type = 0;
            price_cargo_type = price_cargo_type + 600;
            price = price + price_cargo_type;
        }

        private void rdBtn_car_CheckedChanged(object sender, EventArgs e)
        {
            price_cargo_type = 0;
            price_cargo_type = price_cargo_type + 600;
            price = price + price_cargo_type;
        }

        private void chBx_food_CheckedChanged(object sender, EventArgs e)
        {
            price_cargo_description = price_cargo_description + 500;
            price = price + price_cargo_description;
        }

        private void chBx_break_CheckedChanged(object sender, EventArgs e)
        {
            price_cargo_description = price_cargo_description + 700;
            price = price + price_cargo_description;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            price_cargo_description = price_cargo_description + 600;
            price = price + price_cargo_description;
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            price_cargo_description = price_cargo_description + 600;
            price = price + price_cargo_description;
        }

        private void chBx_Repository_CheckedChanged(object sender, EventArgs e)
        {
            price_repository = 0;
            price_repository = price_repository + 1000;
            price = price + price_repository;
        }

        private void num_worker_ValueChanged(object sender, EventArgs e)
        {
            int workers = Convert.ToInt32(num_worker.Value);
            price_worker = 0;
            price_worker = 300 * workers;
            price = price + price_worker;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            num_worker.Value = 3;

            cbo_destination.Text = null;
            cbo_start.Text = null;

            dateTimePicker1.ResetText();

            chBx_break.Checked = false;
            chBx_chemical.Checked = false;
            chBx_dangrous.Checked = false;
            chBx_food.Checked = false;
            chBx_Repository.Checked = false;
            chBx_break.Checked = false;
            chBx_privacy.Checked = false;
            chBx_licences.Checked = false;
            chBx_insurance.Checked = false;

            rdBtn_car.Checked = false;
            rdBtn_cold.Checked = false;
            rdBtn_container.Checked = false;
            rdBtn_dry.Checked = false;
            rdBtn_liquid.Checked = false;
            rdBtn_dry.Checked = false;

            price = 250;
            price_start = 0;
            price_way = 0;
            price_cargo_type = 0;
            price_cargo_description = 0;
            price_repository = 0;
            price_worker = 0;

            btn_price.Visible = true;
            btn_order.Visible = false;
            btn_price.Enabled = false;

            txt_price.Clear();
            txt_price.ForeColor = Color.Black;
            txt_price.Text = "          Press price button \n         Price will be shown here...";
            txt_Insurance.Clear();
            txt_licences.Clear();
            txt_Insurance.Visible = false;
            txt_licences.Visible = false;

            lbl_result.ForeColor = Color.Orange;
            lbl_result.Text = "Ordering...";


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chBx_privacy_CheckedChanged(object sender, EventArgs e)
        {

            btn_price.Enabled = true;
        }

        private void btn_order_Click(object sender, EventArgs e)
        {

            Random random = new Random();
            int randNum = random.Next(4232, 8965);
            result_ship_code = "Ship code : " + Convert.ToString(randNum);
            txt_price.ForeColor = Color.Green;
            txt_price.Text = "\n ---------------- Receipt ---------------- " +
                 "\n " + result_ship_code +
                "\n " + result_time +
                "\n " + result_start +
                "\n " + result_destination +
                "\n " + result_workers +
                "\n " + result_repository +
                "\n-------  " + result_price + "  -------";
            MessageBox.Show("Done, Our team will call you in 24 hours ", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();


        }

        private void chBx_insurance_CheckedChanged(object sender, EventArgs e)
        {
            txt_Insurance.Visible = true;
        }

        private void chBx_licences_CheckedChanged(object sender, EventArgs e)
        {
            txt_licences.Visible = true;

        }
    }
}
