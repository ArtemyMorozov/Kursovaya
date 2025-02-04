namespace Kursovaya1._0
{
    partial class PrintTicketForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.departure = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1058, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Печать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.MenuText;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(199, 154);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(344, 27);
            this.name.TabIndex = 1;
            // 
            // departure
            // 
            this.departure.BackColor = System.Drawing.SystemColors.MenuText;
            this.departure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.departure.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departure.ForeColor = System.Drawing.Color.White;
            this.departure.Location = new System.Drawing.Point(200, 254);
            this.departure.Name = "departure";
            this.departure.ReadOnly = true;
            this.departure.Size = new System.Drawing.Size(344, 27);
            this.departure.TabIndex = 2;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.SystemColors.MenuText;
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Location = new System.Drawing.Point(275, 317);
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Size = new System.Drawing.Size(267, 23);
            this.date.TabIndex = 3;
            // 
            // PrintTicketForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackgroundImage = global::Kursovaya1._0.Properties.Resources.yplane;
            this.ClientSize = new System.Drawing.Size(1082, 456);
            this.Controls.Add(this.date);
            this.Controls.Add(this.departure);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PrintTicketForm";
            this.Text = "PrintTicketForm";
            this.Load += new System.EventHandler(this.PrintTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox departure;
        private System.Windows.Forms.TextBox date;
    }
}