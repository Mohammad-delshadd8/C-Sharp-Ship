namespace Ship
{
    partial class Sign_up_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up_form));
            this.libl_SignInbtn = new System.Windows.Forms.LinkLabel();
            this.lbl_signIn = new System.Windows.Forms.Label();
            this.txt_pass_signUp = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.txt_username_signUp = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_signUp = new System.Windows.Forms.Button();
            this.txt_confirmPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // libl_SignInbtn
            // 
            this.libl_SignInbtn.AutoSize = true;
            this.libl_SignInbtn.Location = new System.Drawing.Point(366, 280);
            this.libl_SignInbtn.Name = "libl_SignInbtn";
            this.libl_SignInbtn.Size = new System.Drawing.Size(43, 15);
            this.libl_SignInbtn.TabIndex = 13;
            this.libl_SignInbtn.TabStop = true;
            this.libl_SignInbtn.Text = "Sign in";
            this.libl_SignInbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.libl_SignInbtn_LinkClicked);
            // 
            // lbl_signIn
            // 
            this.lbl_signIn.AutoSize = true;
            this.lbl_signIn.Location = new System.Drawing.Point(262, 280);
            this.lbl_signIn.Name = "lbl_signIn";
            this.lbl_signIn.Size = new System.Drawing.Size(101, 15);
            this.lbl_signIn.TabIndex = 12;
            this.lbl_signIn.Text = "Have an account?";
            // 
            // txt_pass_signUp
            // 
            this.txt_pass_signUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass_signUp.Location = new System.Drawing.Point(262, 123);
            this.txt_pass_signUp.MaxLength = 10;
            this.txt_pass_signUp.Name = "txt_pass_signUp";
            this.txt_pass_signUp.PasswordChar = '*';
            this.txt_pass_signUp.Size = new System.Drawing.Size(133, 23);
            this.txt_pass_signUp.TabIndex = 11;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pass.Location = new System.Drawing.Point(151, 123);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(87, 21);
            this.lbl_Pass.TabIndex = 10;
            this.lbl_Pass.Text = "Password : ";
            // 
            // txt_username_signUp
            // 
            this.txt_username_signUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username_signUp.Location = new System.Drawing.Point(262, 25);
            this.txt_username_signUp.MaxLength = 50;
            this.txt_username_signUp.Name = "txt_username_signUp";
            this.txt_username_signUp.Size = new System.Drawing.Size(133, 23);
            this.txt_username_signUp.TabIndex = 9;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(151, 25);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(92, 21);
            this.lbl_username.TabIndex = 8;
            this.lbl_username.Text = "Username : ";
            // 
            // btn_signUp
            // 
            this.btn_signUp.AutoSize = true;
            this.btn_signUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_signUp.Location = new System.Drawing.Point(262, 223);
            this.btn_signUp.Name = "btn_signUp";
            this.btn_signUp.Size = new System.Drawing.Size(147, 41);
            this.btn_signUp.TabIndex = 7;
            this.btn_signUp.Text = "sign Up";
            this.btn_signUp.UseVisualStyleBackColor = false;
            this.btn_signUp.Click += new System.EventHandler(this.btn_signUp_Click);
            // 
            // txt_confirmPass
            // 
            this.txt_confirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_confirmPass.Location = new System.Drawing.Point(262, 164);
            this.txt_confirmPass.MaxLength = 10;
            this.txt_confirmPass.Name = "txt_confirmPass";
            this.txt_confirmPass.PasswordChar = '*';
            this.txt_confirmPass.Size = new System.Drawing.Size(133, 23);
            this.txt_confirmPass.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(90, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Confirm Password : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_id
            // 
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_id.Location = new System.Drawing.Point(262, 75);
            this.txt_id.MaxLength = 10;
            this.txt_id.Name = "txt_id";
            this.txt_id.ShortcutsEnabled = false;
            this.txt_id.Size = new System.Drawing.Size(133, 23);
            this.txt_id.TabIndex = 17;
            this.txt_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_id_KeyPress);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ID.Location = new System.Drawing.Point(151, 77);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(73, 21);
            this.lbl_ID.TabIndex = 16;
            this.lbl_ID.Text = "ID code : ";
            // 
            // Sign_up_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_confirmPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.libl_SignInbtn);
            this.Controls.Add(this.lbl_signIn);
            this.Controls.Add(this.txt_pass_signUp);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.txt_username_signUp);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_signUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_up_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipping system - Sign up";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel libl_SignInbtn;
        private Label lbl_signIn;
        private TextBox txt_pass_signUp;
        private Label lbl_Pass;
        private TextBox txt_username_signUp;
        private Label lbl_username;
        private Button btn_signUp;
        private TextBox txt_confirmPass;
        private Label label1;
        private TextBox txt_id;
        private Label lbl_ID;
    }
}