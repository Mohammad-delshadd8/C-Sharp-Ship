namespace Ship
{
    partial class Sign_in_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_in_form));
            this.btn_signin = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_Pass = new System.Windows.Forms.Label();
            this.lbl_signUp = new System.Windows.Forms.Label();
            this.libl_SignUpbtn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn_signin
            // 
            this.btn_signin.AutoSize = true;
            this.btn_signin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_signin.Location = new System.Drawing.Point(255, 209);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(147, 41);
            this.btn_signin.TabIndex = 0;
            this.btn_signin.Text = "sign in";
            this.btn_signin.UseVisualStyleBackColor = false;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.Location = new System.Drawing.Point(112, 65);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(92, 21);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username : ";
            this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Location = new System.Drawing.Point(223, 65);
            this.txt_username.MaxLength = 50;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(227, 25);
            this.txt_username.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pass.Location = new System.Drawing.Point(223, 117);
            this.txt_pass.MaxLength = 10;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(227, 25);
            this.txt_pass.TabIndex = 4;
            // 
            // lbl_Pass
            // 
            this.lbl_Pass.AutoSize = true;
            this.lbl_Pass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Pass.Location = new System.Drawing.Point(112, 117);
            this.lbl_Pass.Name = "lbl_Pass";
            this.lbl_Pass.Size = new System.Drawing.Size(87, 21);
            this.lbl_Pass.TabIndex = 3;
            this.lbl_Pass.Text = "Password : ";
            // 
            // lbl_signUp
            // 
            this.lbl_signUp.AutoSize = true;
            this.lbl_signUp.Location = new System.Drawing.Point(255, 266);
            this.lbl_signUp.Name = "lbl_signUp";
            this.lbl_signUp.Size = new System.Drawing.Size(85, 19);
            this.lbl_signUp.TabIndex = 5;
            this.lbl_signUp.Text = "No account?";
            // 
            // libl_SignUpbtn
            // 
            this.libl_SignUpbtn.AutoSize = true;
            this.libl_SignUpbtn.Location = new System.Drawing.Point(346, 266);
            this.libl_SignUpbtn.Name = "libl_SignUpbtn";
            this.libl_SignUpbtn.Size = new System.Drawing.Size(57, 19);
            this.libl_SignUpbtn.TabIndex = 6;
            this.libl_SignUpbtn.TabStop = true;
            this.libl_SignUpbtn.Text = "Sign Up";
            this.libl_SignUpbtn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.libl_SignUpbtn_LinkClicked);
            // 
            // Sign_in_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.libl_SignUpbtn);
            this.Controls.Add(this.lbl_signUp);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_Pass);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_signin);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sign_in_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shiping system - Sign in";
            this.Load += new System.EventHandler(this.Sign_in_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_signin;
        private Label lbl_username;
        private TextBox txt_username;
        private TextBox txt_pass;
        private Label lbl_Pass;
        private Label lbl_signUp;
        private LinkLabel libl_SignUpbtn;
    }
}