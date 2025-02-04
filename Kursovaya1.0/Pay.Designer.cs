namespace Kursovaya1._0
{
    partial class Pay
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
            this.infoPay1 = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.gb = new System.Windows.Forms.CheckBox();
            this.gn = new System.Windows.Forms.CheckBox();
            this.number = new System.Windows.Forms.MaskedTextBox();
            this.tNumber = new System.Windows.Forms.TextBox();
            this.cDate = new System.Windows.Forms.TextBox();
            this.mm = new System.Windows.Forms.MaskedTextBox();
            this.gg = new System.Windows.Forms.MaskedTextBox();
            this.tPay = new System.Windows.Forms.TextBox();
            this.gNal = new System.Windows.Forms.CheckBox();
            this.PushPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoPay1
            // 
            this.infoPay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.infoPay1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoPay1.Location = new System.Drawing.Point(9, 9);
            this.infoPay1.Margin = new System.Windows.Forms.Padding(0);
            this.infoPay1.Name = "infoPay1";
            this.infoPay1.ReadOnly = true;
            this.infoPay1.Size = new System.Drawing.Size(199, 32);
            this.infoPay1.TabIndex = 0;
            this.infoPay1.Text = "Итого к оплате:";
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.SystemColors.Control;
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.amount.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amount.Location = new System.Drawing.Point(206, 9);
            this.amount.Margin = new System.Windows.Forms.Padding(0);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(199, 32);
            this.amount.TabIndex = 1;
            this.amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(404, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(38, 32);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "р.";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(9, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(433, 32);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Выберите тип оплаты:";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(9, 100);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(236, 32);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "Банковская карта";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(9, 143);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(236, 32);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Наличный расчет";
            // 
            // gb
            // 
            this.gb.AutoSize = true;
            this.gb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb.Location = new System.Drawing.Point(254, 110);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(18, 17);
            this.gb.TabIndex = 6;
            this.gb.UseVisualStyleBackColor = true;
            this.gb.CheckedChanged += new System.EventHandler(this.gb_CheckedChanged);
            // 
            // gn
            // 
            this.gn.AutoSize = true;
            this.gn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gn.Location = new System.Drawing.Point(254, 153);
            this.gn.Name = "gn";
            this.gn.Size = new System.Drawing.Size(18, 17);
            this.gn.TabIndex = 7;
            this.gn.UseVisualStyleBackColor = true;
            this.gn.CheckedChanged += new System.EventHandler(this.gn_CheckedChanged);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(9, 233);
            this.number.Mask = "0000 0000 0000 0000";
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(236, 34);
            this.number.TabIndex = 8;
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number.Visible = false;
            // 
            // tNumber
            // 
            this.tNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tNumber.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tNumber.Location = new System.Drawing.Point(9, 198);
            this.tNumber.Margin = new System.Windows.Forms.Padding(0);
            this.tNumber.Name = "tNumber";
            this.tNumber.ReadOnly = true;
            this.tNumber.Size = new System.Drawing.Size(236, 32);
            this.tNumber.TabIndex = 9;
            this.tNumber.Text = "Номер карты";
            this.tNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tNumber.Visible = false;
            // 
            // cDate
            // 
            this.cDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cDate.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cDate.Location = new System.Drawing.Point(254, 198);
            this.cDate.Margin = new System.Windows.Forms.Padding(0);
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Size = new System.Drawing.Size(158, 32);
            this.cDate.TabIndex = 10;
            this.cDate.Text = "месяц/год";
            this.cDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cDate.Visible = false;
            // 
            // mm
            // 
            this.mm.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mm.Location = new System.Drawing.Point(254, 233);
            this.mm.Mask = "00";
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(79, 34);
            this.mm.TabIndex = 11;
            this.mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mm.Visible = false;
            // 
            // gg
            // 
            this.gg.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gg.Location = new System.Drawing.Point(333, 233);
            this.gg.Mask = "00";
            this.gg.Name = "gg";
            this.gg.Size = new System.Drawing.Size(79, 34);
            this.gg.TabIndex = 12;
            this.gg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gg.Visible = false;
            // 
            // tPay
            // 
            this.tPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPay.Location = new System.Drawing.Point(9, 198);
            this.tPay.Margin = new System.Windows.Forms.Padding(0);
            this.tPay.Name = "tPay";
            this.tPay.Size = new System.Drawing.Size(433, 32);
            this.tPay.TabIndex = 13;
            this.tPay.Text = "Внесите необходимую сумму";
            this.tPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tPay.Visible = false;
            // 
            // gNal
            // 
            this.gNal.AutoSize = true;
            this.gNal.BackColor = System.Drawing.Color.White;
            this.gNal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gNal.Location = new System.Drawing.Point(9, 235);
            this.gNal.Name = "gNal";
            this.gNal.Size = new System.Drawing.Size(194, 29);
            this.gNal.TabIndex = 14;
            this.gNal.Text = "Сумма внесена";
            this.gNal.UseVisualStyleBackColor = false;
            this.gNal.Visible = false;
            // 
            // PushPay
            // 
            this.PushPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.PushPay.Location = new System.Drawing.Point(124, 355);
            this.PushPay.Name = "PushPay";
            this.PushPay.Size = new System.Drawing.Size(221, 76);
            this.PushPay.TabIndex = 15;
            this.PushPay.Text = "Оплатить";
            this.PushPay.UseVisualStyleBackColor = false;
            this.PushPay.Click += new System.EventHandler(this.PushPay_Click);
            // 
            // pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(451, 491);
            this.Controls.Add(this.PushPay);
            this.Controls.Add(this.gNal);
            this.Controls.Add(this.tPay);
            this.Controls.Add(this.gg);
            this.Controls.Add(this.mm);
            this.Controls.Add(this.cDate);
            this.Controls.Add(this.tNumber);
            this.Controls.Add(this.number);
            this.Controls.Add(this.gn);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.infoPay1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "pay";
            this.Text = "pay";
            this.Load += new System.EventHandler(this.pay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox infoPay1;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox gb;
        private System.Windows.Forms.CheckBox gn;
        private System.Windows.Forms.MaskedTextBox number;
        private System.Windows.Forms.TextBox tNumber;
        private System.Windows.Forms.TextBox cDate;
        private System.Windows.Forms.MaskedTextBox mm;
        private System.Windows.Forms.MaskedTextBox gg;
        private System.Windows.Forms.TextBox tPay;
        private System.Windows.Forms.CheckBox gNal;
        private System.Windows.Forms.Button PushPay;
    }
}