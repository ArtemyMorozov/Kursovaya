namespace Kursovaya1._0
{
    partial class EnterData
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
            this.tFIO = new System.Windows.Forms.TextBox();
            this.FIO = new System.Windows.Forms.TextBox();
            this.tPassport = new System.Windows.Forms.TextBox();
            this.tBirthday = new System.Windows.Forms.TextBox();
            this.tEmail = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Oformit = new System.Windows.Forms.Button();
            this.Birthday = new System.Windows.Forms.MaskedTextBox();
            this.Passport = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tFIO
            // 
            this.tFIO.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFIO.Location = new System.Drawing.Point(12, 12);
            this.tFIO.Name = "tFIO";
            this.tFIO.ReadOnly = true;
            this.tFIO.Size = new System.Drawing.Size(283, 34);
            this.tFIO.TabIndex = 0;
            this.tFIO.Text = "ФИО";
            this.tFIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FIO
            // 
            this.FIO.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIO.Location = new System.Drawing.Point(12, 52);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(283, 34);
            this.FIO.TabIndex = 1;
            this.FIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FIO_KeyPress);
            // 
            // tPassport
            // 
            this.tPassport.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPassport.Location = new System.Drawing.Point(524, 12);
            this.tPassport.Name = "tPassport";
            this.tPassport.ReadOnly = true;
            this.tPassport.Size = new System.Drawing.Size(217, 34);
            this.tPassport.TabIndex = 3;
            this.tPassport.Text = "Серия и № паспорта";
            this.tPassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBirthday
            // 
            this.tBirthday.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBirthday.Location = new System.Drawing.Point(301, 12);
            this.tBirthday.Name = "tBirthday";
            this.tBirthday.ReadOnly = true;
            this.tBirthday.Size = new System.Drawing.Size(217, 34);
            this.tBirthday.TabIndex = 5;
            this.tBirthday.Text = "Дата рождения";
            this.tBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tEmail
            // 
            this.tEmail.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tEmail.Location = new System.Drawing.Point(747, 12);
            this.tEmail.Name = "tEmail";
            this.tEmail.ReadOnly = true;
            this.tEmail.Size = new System.Drawing.Size(274, 34);
            this.tEmail.TabIndex = 6;
            this.tEmail.Text = "Email";
            this.tEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(747, 52);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(274, 34);
            this.Email.TabIndex = 7;
            this.Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Email_KeyPress);
            // 
            // Oformit
            // 
            this.Oformit.Enabled = false;
            this.Oformit.Location = new System.Drawing.Point(418, 186);
            this.Oformit.Name = "Oformit";
            this.Oformit.Size = new System.Drawing.Size(220, 65);
            this.Oformit.TabIndex = 8;
            this.Oformit.Text = "Далее";
            this.Oformit.UseVisualStyleBackColor = true;
            this.Oformit.Click += new System.EventHandler(this.Oformit_Click);
            // 
            // Birthday
            // 
            this.Birthday.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Birthday.Location = new System.Drawing.Point(301, 52);
            this.Birthday.Mask = "00/00/0000";
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(217, 34);
            this.Birthday.TabIndex = 9;
            this.Birthday.ValidatingType = typeof(System.DateTime);
            // 
            // Passport
            // 
            this.Passport.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Passport.Location = new System.Drawing.Point(524, 52);
            this.Passport.Mask = "0000 000000";
            this.Passport.Name = "Passport";
            this.Passport.Size = new System.Drawing.Size(217, 34);
            this.Passport.TabIndex = 10;
            this.Passport.ValidatingType = typeof(System.DateTime);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(12, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(939, 26);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Я подтверждаю корректность введенной информации и даю согласие на обработку персо" +
    "нальных данных";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // enterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1038, 268);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Passport);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.Oformit);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.tEmail);
            this.Controls.Add(this.tBirthday);
            this.Controls.Add(this.tPassport);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.tFIO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "enterData";
            this.Text = "enterData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tFIO;
        private System.Windows.Forms.TextBox FIO;
        private System.Windows.Forms.TextBox tPassport;
        private System.Windows.Forms.TextBox tBirthday;
        private System.Windows.Forms.TextBox tEmail;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button Oformit;
        private System.Windows.Forms.MaskedTextBox Birthday;
        private System.Windows.Forms.MaskedTextBox Passport;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}