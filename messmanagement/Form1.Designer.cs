namespace messmanagement
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.ForgotPasswordlinkLabel = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Googlebutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateAccountlinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(39, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mess Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your email address";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Your Password\r\n";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(35, 135);
            this.EmailtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(273, 20);
            this.EmailtextBox.TabIndex = 5;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(35, 176);
            this.PasswordtextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(273, 20);
            this.PasswordtextBox.TabIndex = 6;
            // 
            // LogInbutton
            // 
            this.LogInbutton.BackColor = System.Drawing.Color.Red;
            this.LogInbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInbutton.ForeColor = System.Drawing.Color.White;
            this.LogInbutton.Location = new System.Drawing.Point(35, 203);
            this.LogInbutton.Margin = new System.Windows.Forms.Padding(2);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(272, 22);
            this.LogInbutton.TabIndex = 7;
            this.LogInbutton.Text = "Login Now\r\n";
            this.LogInbutton.UseVisualStyleBackColor = false;
            this.LogInbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ForgotPasswordlinkLabel
            // 
            this.ForgotPasswordlinkLabel.AutoSize = true;
            this.ForgotPasswordlinkLabel.Location = new System.Drawing.Point(215, 227);
            this.ForgotPasswordlinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ForgotPasswordlinkLabel.Name = "ForgotPasswordlinkLabel";
            this.ForgotPasswordlinkLabel.Size = new System.Drawing.Size(92, 13);
            this.ForgotPasswordlinkLabel.TabIndex = 8;
            this.ForgotPasswordlinkLabel.TabStop = true;
            this.ForgotPasswordlinkLabel.Text = "Forgot Password?\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 250);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "or";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::messmanagement.Properties.Resources.project_picture;
            this.pictureBox1.Location = new System.Drawing.Point(41, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Googlebutton
            // 
            this.Googlebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Googlebutton.Location = new System.Drawing.Point(35, 265);
            this.Googlebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Googlebutton.Name = "Googlebutton";
            this.Googlebutton.Size = new System.Drawing.Size(272, 26);
            this.Googlebutton.TabIndex = 10;
            this.Googlebutton.Text = "Continue with Google";
            this.Googlebutton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 299);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "or";
            // 
            // CreateAccountlinkLabel
            // 
            this.CreateAccountlinkLabel.AutoSize = true;
            this.CreateAccountlinkLabel.Location = new System.Drawing.Point(88, 318);
            this.CreateAccountlinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CreateAccountlinkLabel.Name = "CreateAccountlinkLabel";
            this.CreateAccountlinkLabel.Size = new System.Drawing.Size(164, 13);
            this.CreateAccountlinkLabel.TabIndex = 12;
            this.CreateAccountlinkLabel.TabStop = true;
            this.CreateAccountlinkLabel.Text = "New here? Create Account Now.";
            this.CreateAccountlinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 369);
            this.Controls.Add(this.CreateAccountlinkLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Googlebutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ForgotPasswordlinkLabel);
            this.Controls.Add(this.LogInbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.LinkLabel ForgotPasswordlinkLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Googlebutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel CreateAccountlinkLabel;
    }
}

