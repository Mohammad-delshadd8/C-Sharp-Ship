namespace Ship
{
    partial class Main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_form));
            this.cbo_start = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_destination = new System.Windows.Forms.Label();
            this.cbo_destination = new System.Windows.Forms.ComboBox();
            this.chBx_chemical = new System.Windows.Forms.CheckBox();
            this.rdBtn_liquid = new System.Windows.Forms.RadioButton();
            this.rdBtn_cold = new System.Windows.Forms.RadioButton();
            this.rdBtn_container = new System.Windows.Forms.RadioButton();
            this.rdBtn_dry = new System.Windows.Forms.RadioButton();
            this.rdBtn_car = new System.Windows.Forms.RadioButton();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.chBx_dangrous = new System.Windows.Forms.CheckBox();
            this.chBx_food = new System.Windows.Forms.CheckBox();
            this.chBx_break = new System.Windows.Forms.CheckBox();
            this.lbl_description = new System.Windows.Forms.Label();
            this.num_worker = new System.Windows.Forms.NumericUpDown();
            this.lbl_worker = new System.Windows.Forms.Label();
            this.lbl_Repository = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_percent = new System.Windows.Forms.Label();
            this.lbl_percent_sign = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.RichTextBox();
            this.btn_price = new System.Windows.Forms.Button();
            this.chBx_Repository = new System.Windows.Forms.CheckBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.chBx_privacy = new System.Windows.Forms.CheckBox();
            this.lbl_Privcy = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.chBx_insurance = new System.Windows.Forms.CheckBox();
            this.lbl_Insuramce = new System.Windows.Forms.Label();
            this.chBx_licences = new System.Windows.Forms.CheckBox();
            this.lbl_licence = new System.Windows.Forms.Label();
            this.txt_Insurance = new System.Windows.Forms.TextBox();
            this.txt_licences = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_worker)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_start
            // 
            this.cbo_start.FormattingEnabled = true;
            this.cbo_start.Items.AddRange(new object[] {
            "Rajaei, Iran",
            "Shanghai, China",
            "LA, USA",
            "Busan, South korea ",
            "Roterdam, Netherlands",
            "Colombo, Srilanka",
            "Algeciras, Spain",
            "Bermen, Germany",
            "Tokyo, Japan ",
            "Santos, Brazil",
            "Salalah, Oman "});
            this.cbo_start.Location = new System.Drawing.Point(181, 126);
            this.cbo_start.Name = "cbo_start";
            this.cbo_start.Size = new System.Drawing.Size(121, 23);
            this.cbo_start.TabIndex = 0;
            this.cbo_start.SelectedIndexChanged += new System.EventHandler(this.cbo_start_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 39);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(57, 39);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(88, 19);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "loading date:";
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_start.Location = new System.Drawing.Point(55, 130);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(87, 19);
            this.lbl_start.TabIndex = 3;
            this.lbl_start.Text = "loading port:";
            // 
            // lbl_destination
            // 
            this.lbl_destination.AutoSize = true;
            this.lbl_destination.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_destination.Location = new System.Drawing.Point(515, 130);
            this.lbl_destination.Name = "lbl_destination";
            this.lbl_destination.Size = new System.Drawing.Size(82, 19);
            this.lbl_destination.TabIndex = 5;
            this.lbl_destination.Text = "Destination:";
            // 
            // cbo_destination
            // 
            this.cbo_destination.FormattingEnabled = true;
            this.cbo_destination.Items.AddRange(new object[] {
            "Rajaei, Iran",
            "Shanghai, China",
            "LA, USA",
            "Busan, South korea ",
            "Roterdam, Netherlands",
            "Colombo, Srilanka",
            "Algeciras, Spain",
            "Bermen, Germany",
            "Tokyo, Japan ",
            "Santos, Brazil",
            "Salalah, Oman "});
            this.cbo_destination.Location = new System.Drawing.Point(629, 126);
            this.cbo_destination.Name = "cbo_destination";
            this.cbo_destination.Size = new System.Drawing.Size(121, 23);
            this.cbo_destination.TabIndex = 4;
            this.cbo_destination.SelectedIndexChanged += new System.EventHandler(this.cbo_destination_SelectedIndexChanged);
            // 
            // chBx_chemical
            // 
            this.chBx_chemical.AutoSize = true;
            this.chBx_chemical.Location = new System.Drawing.Point(233, 278);
            this.chBx_chemical.Name = "chBx_chemical";
            this.chBx_chemical.Size = new System.Drawing.Size(86, 19);
            this.chBx_chemical.TabIndex = 12;
            this.chBx_chemical.Text = "Chemichal ";
            this.chBx_chemical.UseVisualStyleBackColor = true;
            this.chBx_chemical.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rdBtn_liquid
            // 
            this.rdBtn_liquid.AutoSize = true;
            this.rdBtn_liquid.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtn_liquid.Location = new System.Drawing.Point(424, 218);
            this.rdBtn_liquid.Name = "rdBtn_liquid";
            this.rdBtn_liquid.Size = new System.Drawing.Size(64, 23);
            this.rdBtn_liquid.TabIndex = 8;
            this.rdBtn_liquid.Text = "Liquid";
            this.rdBtn_liquid.UseVisualStyleBackColor = true;
            this.rdBtn_liquid.CheckedChanged += new System.EventHandler(this.rdBtn_liquid_CheckedChanged);
            // 
            // rdBtn_cold
            // 
            this.rdBtn_cold.AutoSize = true;
            this.rdBtn_cold.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtn_cold.Location = new System.Drawing.Point(540, 217);
            this.rdBtn_cold.Name = "rdBtn_cold";
            this.rdBtn_cold.Size = new System.Drawing.Size(94, 23);
            this.rdBtn_cold.TabIndex = 9;
            this.rdBtn_cold.Text = "Refrigrated";
            this.rdBtn_cold.UseVisualStyleBackColor = true;
            this.rdBtn_cold.CheckedChanged += new System.EventHandler(this.rdBtn_cold_CheckedChanged);
            // 
            // rdBtn_container
            // 
            this.rdBtn_container.AutoSize = true;
            this.rdBtn_container.Checked = true;
            this.rdBtn_container.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtn_container.Location = new System.Drawing.Point(168, 217);
            this.rdBtn_container.Name = "rdBtn_container";
            this.rdBtn_container.Size = new System.Drawing.Size(87, 23);
            this.rdBtn_container.TabIndex = 10;
            this.rdBtn_container.TabStop = true;
            this.rdBtn_container.Text = "Container";
            this.rdBtn_container.UseVisualStyleBackColor = true;
            this.rdBtn_container.CheckedChanged += new System.EventHandler(this.rdBtn_container_CheckedChanged);
            // 
            // rdBtn_dry
            // 
            this.rdBtn_dry.AutoSize = true;
            this.rdBtn_dry.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtn_dry.Location = new System.Drawing.Point(303, 218);
            this.rdBtn_dry.Name = "rdBtn_dry";
            this.rdBtn_dry.Size = new System.Drawing.Size(49, 23);
            this.rdBtn_dry.TabIndex = 11;
            this.rdBtn_dry.Text = "Dry";
            this.rdBtn_dry.UseVisualStyleBackColor = true;
            this.rdBtn_dry.CheckedChanged += new System.EventHandler(this.rdBtn_dry_CheckedChanged);
            // 
            // rdBtn_car
            // 
            this.rdBtn_car.AutoSize = true;
            this.rdBtn_car.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtn_car.Location = new System.Drawing.Point(678, 217);
            this.rdBtn_car.Name = "rdBtn_car";
            this.rdBtn_car.Size = new System.Drawing.Size(98, 23);
            this.rdBtn_car.TabIndex = 13;
            this.rdBtn_car.Text = "Automative";
            this.rdBtn_car.UseVisualStyleBackColor = true;
            this.rdBtn_car.CheckedChanged += new System.EventHandler(this.rdBtn_car_CheckedChanged);
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_cargo.Location = new System.Drawing.Point(55, 220);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(88, 19);
            this.lbl_cargo.TabIndex = 14;
            this.lbl_cargo.Text = "Cargo type : ";
            // 
            // chBx_dangrous
            // 
            this.chBx_dangrous.AutoSize = true;
            this.chBx_dangrous.Location = new System.Drawing.Point(385, 278);
            this.chBx_dangrous.Name = "chBx_dangrous";
            this.chBx_dangrous.Size = new System.Drawing.Size(80, 19);
            this.chBx_dangrous.TabIndex = 15;
            this.chBx_dangrous.Text = "Dangrous ";
            this.chBx_dangrous.UseVisualStyleBackColor = true;
            this.chBx_dangrous.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // chBx_food
            // 
            this.chBx_food.AutoSize = true;
            this.chBx_food.Location = new System.Drawing.Point(527, 278);
            this.chBx_food.Name = "chBx_food";
            this.chBx_food.Size = new System.Drawing.Size(90, 19);
            this.chBx_food.TabIndex = 17;
            this.chBx_food.Text = "Food / Drug";
            this.chBx_food.UseVisualStyleBackColor = true;
            this.chBx_food.CheckedChanged += new System.EventHandler(this.chBx_food_CheckedChanged);
            // 
            // chBx_break
            // 
            this.chBx_break.AutoSize = true;
            this.chBx_break.Location = new System.Drawing.Point(678, 277);
            this.chBx_break.Name = "chBx_break";
            this.chBx_break.Size = new System.Drawing.Size(81, 19);
            this.chBx_break.TabIndex = 18;
            this.chBx_break.Text = "Braek bulk";
            this.chBx_break.UseVisualStyleBackColor = true;
            this.chBx_break.CheckedChanged += new System.EventHandler(this.chBx_break_CheckedChanged);
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_description.Location = new System.Drawing.Point(55, 276);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(132, 19);
            this.lbl_description.TabIndex = 19;
            this.lbl_description.Text = "Cargo description :  ";
            // 
            // num_worker
            // 
            this.num_worker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_worker.Location = new System.Drawing.Point(293, 335);
            this.num_worker.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_worker.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_worker.Name = "num_worker";
            this.num_worker.Size = new System.Drawing.Size(49, 25);
            this.num_worker.TabIndex = 20;
            this.num_worker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_worker.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.num_worker.ValueChanged += new System.EventHandler(this.num_worker_ValueChanged);
            // 
            // lbl_worker
            // 
            this.lbl_worker.AutoSize = true;
            this.lbl_worker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_worker.Location = new System.Drawing.Point(57, 337);
            this.lbl_worker.Name = "lbl_worker";
            this.lbl_worker.Size = new System.Drawing.Size(214, 19);
            this.lbl_worker.TabIndex = 21;
            this.lbl_worker.Text = "How many workers do you need?";
            this.lbl_worker.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_Repository
            // 
            this.lbl_Repository.AutoSize = true;
            this.lbl_Repository.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Repository.Location = new System.Drawing.Point(55, 365);
            this.lbl_Repository.Name = "lbl_Repository";
            this.lbl_Repository.Size = new System.Drawing.Size(116, 19);
            this.lbl_Repository.TabIndex = 22;
            this.lbl_Repository.Text = "I need Repository";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.LimeGreen;
            this.progressBar1.Location = new System.Drawing.Point(619, 39);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(140, 28);
            this.progressBar1.TabIndex = 25;
            // 
            // lbl_percent
            // 
            this.lbl_percent.AutoSize = true;
            this.lbl_percent.Location = new System.Drawing.Point(638, 80);
            this.lbl_percent.Name = "lbl_percent";
            this.lbl_percent.Size = new System.Drawing.Size(0, 15);
            this.lbl_percent.TabIndex = 26;
            this.lbl_percent.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lbl_percent_sign
            // 
            this.lbl_percent_sign.AutoSize = true;
            this.lbl_percent_sign.Location = new System.Drawing.Point(690, 70);
            this.lbl_percent_sign.Name = "lbl_percent_sign";
            this.lbl_percent_sign.Size = new System.Drawing.Size(0, 15);
            this.lbl_percent_sign.TabIndex = 27;
            // 
            // txt_price
            // 
            this.txt_price.BackColor = System.Drawing.SystemColors.Control;
            this.txt_price.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_price.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_price.Location = new System.Drawing.Point(48, 407);
            this.txt_price.Name = "txt_price";
            this.txt_price.ReadOnly = true;
            this.txt_price.Size = new System.Drawing.Size(271, 142);
            this.txt_price.TabIndex = 0;
            this.txt_price.Text = "\n\n\n\n                             Press \"price\" button\n                         Pr" +
    "ice will be shown here ... ";
            this.txt_price.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btn_price
            // 
            this.btn_price.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_price.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_price.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_price.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_price.Location = new System.Drawing.Point(657, 494);
            this.btn_price.Name = "btn_price";
            this.btn_price.Size = new System.Drawing.Size(119, 38);
            this.btn_price.TabIndex = 28;
            this.btn_price.Text = "Price";
            this.btn_price.UseVisualStyleBackColor = false;
            this.btn_price.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // chBx_Repository
            // 
            this.chBx_Repository.AutoSize = true;
            this.chBx_Repository.Location = new System.Drawing.Point(198, 368);
            this.chBx_Repository.Name = "chBx_Repository";
            this.chBx_Repository.Size = new System.Drawing.Size(15, 14);
            this.chBx_Repository.TabIndex = 29;
            this.chBx_Repository.UseVisualStyleBackColor = true;
            this.chBx_Repository.CheckedChanged += new System.EventHandler(this.chBx_Repository_CheckedChanged);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Crimson;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_clear.Location = new System.Drawing.Point(515, 494);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(119, 38);
            this.btn_clear.TabIndex = 30;
            this.btn_clear.Text = "Clear ";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // chBx_privacy
            // 
            this.chBx_privacy.AutoSize = true;
            this.chBx_privacy.Location = new System.Drawing.Point(695, 448);
            this.chBx_privacy.Name = "chBx_privacy";
            this.chBx_privacy.Size = new System.Drawing.Size(15, 14);
            this.chBx_privacy.TabIndex = 32;
            this.chBx_privacy.UseVisualStyleBackColor = true;
            this.chBx_privacy.CheckedChanged += new System.EventHandler(this.chBx_privacy_CheckedChanged);
            // 
            // lbl_Privcy
            // 
            this.lbl_Privcy.AutoSize = true;
            this.lbl_Privcy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Privcy.Location = new System.Drawing.Point(515, 448);
            this.lbl_Privcy.Name = "lbl_Privcy";
            this.lbl_Privcy.Size = new System.Drawing.Size(164, 17);
            this.lbl_Privcy.TabIndex = 31;
            this.lbl_Privcy.Text = "I accept terms of services";
            // 
            // btn_order
            // 
            this.btn_order.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_order.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_order.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_order.Location = new System.Drawing.Point(657, 494);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(119, 38);
            this.btn_order.TabIndex = 33;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = false;
            this.btn_order.Visible = false;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // chBx_insurance
            // 
            this.chBx_insurance.AutoSize = true;
            this.chBx_insurance.Location = new System.Drawing.Point(695, 387);
            this.chBx_insurance.Name = "chBx_insurance";
            this.chBx_insurance.Size = new System.Drawing.Size(15, 14);
            this.chBx_insurance.TabIndex = 35;
            this.chBx_insurance.UseVisualStyleBackColor = true;
            this.chBx_insurance.CheckedChanged += new System.EventHandler(this.chBx_insurance_CheckedChanged);
            // 
            // lbl_Insuramce
            // 
            this.lbl_Insuramce.AutoSize = true;
            this.lbl_Insuramce.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Insuramce.Location = new System.Drawing.Point(515, 384);
            this.lbl_Insuramce.Name = "lbl_Insuramce";
            this.lbl_Insuramce.Size = new System.Drawing.Size(147, 17);
            this.lbl_Insuramce.TabIndex = 34;
            this.lbl_Insuramce.Text = "My cargo has Insurance";
            // 
            // chBx_licences
            // 
            this.chBx_licences.AutoSize = true;
            this.chBx_licences.Location = new System.Drawing.Point(695, 419);
            this.chBx_licences.Name = "chBx_licences";
            this.chBx_licences.Size = new System.Drawing.Size(15, 14);
            this.chBx_licences.TabIndex = 37;
            this.chBx_licences.UseVisualStyleBackColor = true;
            this.chBx_licences.CheckedChanged += new System.EventHandler(this.chBx_licences_CheckedChanged);
            // 
            // lbl_licence
            // 
            this.lbl_licence.AutoSize = true;
            this.lbl_licence.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_licence.Location = new System.Drawing.Point(515, 416);
            this.lbl_licence.Name = "lbl_licence";
            this.lbl_licence.Size = new System.Drawing.Size(169, 17);
            this.lbl_licence.TabIndex = 38;
            this.lbl_licence.Text = "My cargo has legal licences";
            // 
            // txt_Insurance
            // 
            this.txt_Insurance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Insurance.Location = new System.Drawing.Point(719, 385);
            this.txt_Insurance.MaxLength = 6;
            this.txt_Insurance.Name = "txt_Insurance";
            this.txt_Insurance.Size = new System.Drawing.Size(60, 16);
            this.txt_Insurance.TabIndex = 39;
            this.txt_Insurance.Visible = false;
            // 
            // txt_licences
            // 
            this.txt_licences.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_licences.Location = new System.Drawing.Point(719, 416);
            this.txt_licences.MaxLength = 6;
            this.txt_licences.Name = "txt_licences";
            this.txt_licences.Size = new System.Drawing.Size(60, 16);
            this.txt_licences.TabIndex = 40;
            this.txt_licences.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(672, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 41;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.ForeColor = System.Drawing.Color.Orange;
            this.lbl_result.Location = new System.Drawing.Point(657, 70);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(64, 15);
            this.lbl_result.TabIndex = 42;
            this.lbl_result.Text = "ordering ...";
            // 
            // Main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 561);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_licences);
            this.Controls.Add(this.txt_Insurance);
            this.Controls.Add(this.lbl_licence);
            this.Controls.Add(this.chBx_licences);
            this.Controls.Add(this.chBx_insurance);
            this.Controls.Add(this.lbl_Insuramce);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.chBx_privacy);
            this.Controls.Add(this.lbl_Privcy);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.chBx_Repository);
            this.Controls.Add(this.btn_price);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.lbl_percent_sign);
            this.Controls.Add(this.lbl_percent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_Repository);
            this.Controls.Add(this.lbl_worker);
            this.Controls.Add(this.num_worker);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.chBx_break);
            this.Controls.Add(this.chBx_food);
            this.Controls.Add(this.chBx_dangrous);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.rdBtn_car);
            this.Controls.Add(this.chBx_chemical);
            this.Controls.Add(this.rdBtn_dry);
            this.Controls.Add(this.rdBtn_container);
            this.Controls.Add(this.rdBtn_cold);
            this.Controls.Add(this.rdBtn_liquid);
            this.Controls.Add(this.lbl_destination);
            this.Controls.Add(this.cbo_destination);
            this.Controls.Add(this.lbl_start);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbo_start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipping System";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_worker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbo_start;
        private DateTimePicker dateTimePicker1;
        private Label lbl_date;
        private Label lbl_start;
        private Label lbl_destination;
        private ComboBox cbo_destination;
        private CheckBox chBx_chemical;
        private RadioButton rdBtn_liquid;
        private RadioButton rdBtn_cold;
        private RadioButton rdBtn_container;
        private RadioButton rdBtn_dry;
        private RadioButton rdBtn_car;
        private Label lbl_cargo;
        private CheckBox chBx_dangrous;
        private CheckBox chBx_food;
        private CheckBox chBx_break;
        private Label lbl_description;
        private NumericUpDown num_worker;
        private Label lbl_worker;
        private Label lbl_Repository;
        private ProgressBar progressBar1;
        private Label lbl_percent;
        private Label lbl_percent_sign;
        private RichTextBox txt_price;
        private Button btn_price;
        private CheckBox chBx_Repository;
        private Button btn_clear;
        private CheckBox chBx_privacy;
        private Label lbl_Privcy;
        private Button btn_order;
        private CheckBox chBx_insurance;
        private Label lbl_Insuramce;
        private CheckBox chBx_licences;
        private Label lbl_licence;
        private TextBox txt_Insurance;
        private TextBox txt_licences;
        private Label label1;
        private Label lbl_result;
    }
}