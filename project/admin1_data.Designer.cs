
namespace project
{
    partial class admin1_data
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.Update2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Remove2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Admin_record = new System.Windows.Forms.DataGridView();
            this.SN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Admin_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Save2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.male_select = new System.Windows.Forms.RadioButton();
            this.custom_select = new System.Windows.Forms.RadioButton();
            this.female_select = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Admin_record)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Last_name";
            // 
            // Update2
            // 
            this.Update2.BackColor = System.Drawing.Color.Gold;
            this.Update2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update2.ForeColor = System.Drawing.SystemColors.Window;
            this.Update2.Location = new System.Drawing.Point(195, 435);
            this.Update2.Name = "Update2";
            this.Update2.Size = new System.Drawing.Size(77, 44);
            this.Update2.TabIndex = 58;
            this.Update2.Text = "Update";
            this.Update2.UseVisualStyleBackColor = false;
            this.Update2.Click += new System.EventHandler(this.Update_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(155, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(102, 22);
            this.textBox2.TabIndex = 45;
            // 
            // Remove2
            // 
            this.Remove2.BackColor = System.Drawing.Color.Red;
            this.Remove2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove2.ForeColor = System.Drawing.SystemColors.Window;
            this.Remove2.Location = new System.Drawing.Point(102, 435);
            this.Remove2.Name = "Remove2";
            this.Remove2.Size = new System.Drawing.Size(87, 44);
            this.Remove2.TabIndex = 57;
            this.Remove2.Text = "Remove";
            this.Remove2.UseVisualStyleBackColor = false;
            this.Remove2.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.OrangeRed;
            this.label9.Location = new System.Drawing.Point(546, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(238, 37);
            this.label9.TabIndex = 62;
            this.label9.Text = "Admin Record";
            // 
            // Admin_record
            // 
            this.Admin_record.AllowUserToAddRows = false;
            this.Admin_record.AllowUserToDeleteRows = false;
            this.Admin_record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Admin_record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SN,
            this.Admin_Id,
            this.First_name,
            this.Last_name,
            this.Address,
            this.Contact_no,
            this.Gender,
            this.Email,
            this.password,
            this.Action});
            this.Admin_record.Location = new System.Drawing.Point(278, 81);
            this.Admin_record.Name = "Admin_record";
            this.Admin_record.ReadOnly = true;
            this.Admin_record.Size = new System.Drawing.Size(861, 398);
            this.Admin_record.TabIndex = 61;
            this.Admin_record.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Admin_record_CellClick);
            // 
            // SN
            // 
            this.SN.HeaderText = "SN";
            this.SN.Name = "SN";
            this.SN.ReadOnly = true;
            this.SN.Width = 30;
            // 
            // Admin_Id
            // 
            this.Admin_Id.HeaderText = "Admin_Id";
            this.Admin_Id.Name = "Admin_Id";
            this.Admin_Id.ReadOnly = true;
            this.Admin_Id.Width = 70;
            // 
            // First_name
            // 
            this.First_name.HeaderText = "First_name";
            this.First_name.Name = "First_name";
            this.First_name.ReadOnly = true;
            // 
            // Last_name
            // 
            this.Last_name.HeaderText = "Last_name";
            this.Last_name.Name = "Last_name";
            this.Last_name.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Contact_no
            // 
            this.Contact_no.HeaderText = "Contact_no";
            this.Contact_no.Name = "Contact_no";
            this.Contact_no.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            this.Gender.Width = 70;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Width = 85;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Width = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 60;
            this.label8.Text = "Admin Id";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(25, 81);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(232, 22);
            this.textBox7.TabIndex = 59;
            // 
            // Save2
            // 
            this.Save2.BackColor = System.Drawing.Color.ForestGreen;
            this.Save2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save2.ForeColor = System.Drawing.SystemColors.Window;
            this.Save2.Location = new System.Drawing.Point(25, 435);
            this.Save2.Name = "Save2";
            this.Save2.Size = new System.Drawing.Size(71, 44);
            this.Save2.TabIndex = 56;
            this.Save2.Text = "Save";
            this.Save2.UseVisualStyleBackColor = false;
            this.Save2.Click += new System.EventHandler(this.Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "New Password";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(25, 396);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(238, 22);
            this.textBox6.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 16);
            this.label6.TabIndex = 53;
            this.label6.Text = "E-mail";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(25, 346);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(238, 22);
            this.textBox5.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.male_select);
            this.groupBox1.Controls.Add(this.custom_select);
            this.groupBox1.Controls.Add(this.female_select);
            this.groupBox1.Location = new System.Drawing.Point(25, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 46);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // male_select
            // 
            this.male_select.AutoSize = true;
            this.male_select.Location = new System.Drawing.Point(6, 18);
            this.male_select.Name = "male_select";
            this.male_select.Size = new System.Drawing.Size(48, 17);
            this.male_select.TabIndex = 9;
            this.male_select.TabStop = true;
            this.male_select.Text = "Male";
            this.male_select.UseVisualStyleBackColor = true;
            // 
            // custom_select
            // 
            this.custom_select.AutoSize = true;
            this.custom_select.Location = new System.Drawing.Point(172, 18);
            this.custom_select.Name = "custom_select";
            this.custom_select.Size = new System.Drawing.Size(60, 17);
            this.custom_select.TabIndex = 10;
            this.custom_select.TabStop = true;
            this.custom_select.Text = "Custom";
            this.custom_select.UseVisualStyleBackColor = true;
            // 
            // female_select
            // 
            this.female_select.AutoSize = true;
            this.female_select.Location = new System.Drawing.Point(82, 19);
            this.female_select.Name = "female_select";
            this.female_select.Size = new System.Drawing.Size(59, 17);
            this.female_select.TabIndex = 8;
            this.female_select.TabStop = true;
            this.female_select.Text = "Female";
            this.female_select.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Contact No";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(25, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(232, 22);
            this.textBox4.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(25, 175);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(232, 22);
            this.textBox3.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "First_name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(25, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 22);
            this.textBox1.TabIndex = 43;
            // 
            // admin1_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Update2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Remove2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Admin_record);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Save2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Name = "admin1_data";
            this.Size = new System.Drawing.Size(1156, 520);
            this.Load += new System.EventHandler(this.admin1_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Admin_record)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Update2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Remove2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Admin_record;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Save2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton male_select;
        private System.Windows.Forms.RadioButton custom_select;
        private System.Windows.Forms.RadioButton female_select;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Admin_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Action;
    }
}
