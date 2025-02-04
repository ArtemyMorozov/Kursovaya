namespace Kursovaya1._0
{
    partial class Edit
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.date2 = new System.Windows.Forms.MaskedTextBox();
            this.date1 = new System.Windows.Forms.MaskedTextBox();
            this.time = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.seats = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Insert = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.obmovit = new System.Windows.Forms.Button();
            this.cDate = new System.Windows.Forms.MaskedTextBox();
            this.cSeats = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.cCity = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.soldTicketsView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whereToGo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soldTicketsView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(580, 426);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabPage1.Controls.Add(this.date2);
            this.tabPage1.Controls.Add(this.date1);
            this.tabPage1.Controls.Add(this.time);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.cost);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.seats);
            this.tabPage1.Controls.Add(this.textBox8);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.City);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.Insert);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(572, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавление и удаление";
            // 
            // date2
            // 
            this.date2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date2.Location = new System.Drawing.Point(382, 46);
            this.date2.Mask = "00/00/0000 90:00";
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(182, 34);
            this.date2.TabIndex = 17;
            this.date2.ValidatingType = typeof(System.DateTime);
            this.date2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date2_KeyPress);
            // 
            // date1
            // 
            this.date1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date1.Location = new System.Drawing.Point(194, 46);
            this.date1.Mask = "00/00/0000 90:00";
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(182, 34);
            this.date1.TabIndex = 16;
            this.date1.ValidatingType = typeof(System.DateTime);
            this.date1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date1_KeyPress);
            // 
            // time
            // 
            this.time.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time.Location = new System.Drawing.Point(6, 158);
            this.time.Mask = "00:00";
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(182, 34);
            this.time.TabIndex = 15;
            this.time.Click += new System.EventHandler(this.time_Click);
            this.time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.time_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(304, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 95);
            this.button1.TabIndex = 14;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cost
            // 
            this.cost.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cost.Location = new System.Drawing.Point(382, 158);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(182, 34);
            this.cost.TabIndex = 13;
            this.cost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cost_KeyPress);
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(382, 118);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(182, 34);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = "Цена";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seats
            // 
            this.seats.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seats.Location = new System.Drawing.Point(194, 158);
            this.seats.Name = "seats";
            this.seats.Size = new System.Drawing.Size(182, 34);
            this.seats.TabIndex = 11;
            this.seats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.seats_KeyPress);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(194, 118);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(182, 34);
            this.textBox8.TabIndex = 10;
            this.textBox8.Text = "Свободные места";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(6, 118);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(182, 34);
            this.textBox6.TabIndex = 8;
            this.textBox6.Text = "Время в пути";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(382, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(182, 34);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "Дата прибытия";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // City
            // 
            this.City.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.City.Location = new System.Drawing.Point(6, 46);
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(182, 34);
            this.City.TabIndex = 5;
            this.City.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.City_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(194, 6);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(182, 34);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Дата вылета";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(182, 34);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Пункт назначения";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Insert.Location = new System.Drawing.Point(6, 246);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(260, 95);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Добавить";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabPage2.Controls.Add(this.obmovit);
            this.tabPage2.Controls.Add(this.cDate);
            this.tabPage2.Controls.Add(this.cSeats);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.cCity);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(572, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Изменение";
            // 
            // obmovit
            // 
            this.obmovit.Location = new System.Drawing.Point(160, 200);
            this.obmovit.Name = "obmovit";
            this.obmovit.Size = new System.Drawing.Size(260, 95);
            this.obmovit.TabIndex = 7;
            this.obmovit.Text = "Изменить";
            this.obmovit.UseVisualStyleBackColor = true;
            this.obmovit.Click += new System.EventHandler(this.obmovit_Click);
            // 
            // cDate
            // 
            this.cDate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cDate.Location = new System.Drawing.Point(194, 46);
            this.cDate.Mask = "00/00/0000 90:00";
            this.cDate.Name = "cDate";
            this.cDate.Size = new System.Drawing.Size(182, 34);
            this.cDate.TabIndex = 6;
            this.cDate.ValidatingType = typeof(System.DateTime);
            this.cDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cDate_KeyPress);
            // 
            // cSeats
            // 
            this.cSeats.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cSeats.Location = new System.Drawing.Point(382, 46);
            this.cSeats.Name = "cSeats";
            this.cSeats.Size = new System.Drawing.Size(182, 34);
            this.cSeats.TabIndex = 5;
            this.cSeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cSeats_KeyPress);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(382, 6);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(182, 34);
            this.textBox9.TabIndex = 3;
            this.textBox9.Text = "Свободные места";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(194, 6);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(182, 34);
            this.textBox7.TabIndex = 2;
            this.textBox7.Text = "Дата вылета";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cCity
            // 
            this.cCity.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cCity.Location = new System.Drawing.Point(6, 46);
            this.cCity.Name = "cCity";
            this.cCity.Size = new System.Drawing.Size(182, 34);
            this.cCity.TabIndex = 1;
            this.cCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cCity_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(6, 6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(182, 34);
            this.textBox3.TabIndex = 0;
            this.textBox3.Text = "Пункт назначения";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.soldTicketsView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(572, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Статистика";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // soldTicketsView
            // 
            this.soldTicketsView.AllowUserToAddRows = false;
            this.soldTicketsView.AllowUserToDeleteRows = false;
            this.soldTicketsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.soldTicketsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.whereToGo,
            this.departureDate,
            this.pass,
            this.birthday,
            this.email});
            this.soldTicketsView.Location = new System.Drawing.Point(-4, 3);
            this.soldTicketsView.Name = "soldTicketsView";
            this.soldTicketsView.ReadOnly = true;
            this.soldTicketsView.RowHeadersWidth = 51;
            this.soldTicketsView.RowTemplate.Height = 24;
            this.soldTicketsView.Size = new System.Drawing.Size(576, 398);
            this.soldTicketsView.TabIndex = 0;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Имя";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 125;
            // 
            // whereToGo
            // 
            this.whereToGo.DataPropertyName = "whereToGo";
            this.whereToGo.HeaderText = "Пункт назначения";
            this.whereToGo.MinimumWidth = 6;
            this.whereToGo.Name = "whereToGo";
            this.whereToGo.ReadOnly = true;
            this.whereToGo.Width = 125;
            // 
            // departureDate
            // 
            this.departureDate.DataPropertyName = "departureDate";
            this.departureDate.HeaderText = "Дата вылета";
            this.departureDate.MinimumWidth = 6;
            this.departureDate.Name = "departureDate";
            this.departureDate.ReadOnly = true;
            this.departureDate.Width = 125;
            // 
            // pass
            // 
            this.pass.DataPropertyName = "pass";
            this.pass.HeaderText = "Паспорт";
            this.pass.MinimumWidth = 6;
            this.pass.Name = "pass";
            this.pass.ReadOnly = true;
            this.pass.Width = 125;
            // 
            // birthday
            // 
            this.birthday.DataPropertyName = "birthday";
            this.birthday.HeaderText = "Дата рождения";
            this.birthday.MinimumWidth = 6;
            this.birthday.Name = "birthday";
            this.birthday.ReadOnly = true;
            this.birthday.Width = 125;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 125;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Edit";
            this.Text = "edit";
            this.Load += new System.EventHandler(this.edit_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.soldTicketsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox seats;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox date2;
        private System.Windows.Forms.MaskedTextBox date1;
        private System.Windows.Forms.MaskedTextBox time;
        private System.Windows.Forms.Button obmovit;
        private System.Windows.Forms.MaskedTextBox cDate;
        private System.Windows.Forms.TextBox cSeats;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox cCity;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView soldTicketsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn whereToGo;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}